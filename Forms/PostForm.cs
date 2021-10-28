using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MongoDAL.Objects;

namespace NoSQLProject.Forms
{
    public partial class PostForm : Form
    {
        BLogic bl;
        private User currentUser;
        private Post currentPost;

        private int displayPostComments;
        private List<Post> streamComments;
        public PostForm(User user, Post post)
        {
            bl = new BLogic();
            currentUser = user;
            currentPost = post;
            displayPostComments = 0;
            (bool, Post) parentPost = bl.GetParentPost(currentPost);
            InitializeComponent();
            if (parentPost.Item1)
            {
                postMenuParent.Text = parentPost.Item2.SetString();
            }
            if (currentPost.comments.Count != 0)
            {
                streamComments = bl.GetPostsComments(currentPost);
                SetStreamComments(displayPostComments);

            }
            postMenuThis.Text = post.SetString();
            if (currentPost.likes.IndexOf(currentUser.nickname) != -1)
            {
                likePost.Text = "unlike";
            }
            else
            {
                likePost.Text = "like";
            }

        }
        private void SetStreamComments(int disp)
        {
            int streamlength = streamComments == null ? 0 : streamComments.Count;
            if (streamlength >= 1)
            {
                postMenuComments.Text = streamComments[Math.Abs(disp % streamlength)].SetString();
                if (streamComments[Math.Abs(disp % streamlength)].likes.IndexOf(currentUser.nickname) != -1)
                {
                    likeComment.Text = "unlike";
                }
                else
                {
                    likeComment.Text = "like";
                }
            }
        }

        private void postMenuUp_Click(object sender, EventArgs e)
        {
            SetStreamComments(--displayPostComments);
        }

        private void postMenuDown_Click(object sender, EventArgs e)
        {
            SetStreamComments(++displayPostComments);
        }

        private void postMenuPublish_Click(object sender, EventArgs e)
        {
            string body = postMenuText.Text;
            bl.InsertPost(currentUser, body);
            currentPost.comments.Add(bl.GetMaxId());
            bl.UpdateComments(currentPost,currentUser,body);
            streamComments = bl.GetPostsComments(currentPost);
        }

        private void likePost_Click(object sender, EventArgs e)
        {
            if (likePost.Text == "like")
            {
                currentPost.likes.Add(currentUser.nickname);
                bl.SetLikes(currentPost);
                UpdatePosts();
                likePost.Text = "unlike";
            }
            else if (likePost.Text == "unlike")
            {
                currentPost.likes.Remove(currentUser.nickname);
                bl.SetLikes(currentPost);
                UpdatePosts();
                likePost.Text = "like";
            }
        }
        private void UpdatePosts()
        {
            if (currentPost.comments.Count != 0)
            {
                postMenuThis.Text = currentPost.SetString();
                streamComments = bl.GetPostsComments(currentPost);
                SetStreamComments(displayPostComments);

            }
        }

        private void likeComment_Click(object sender, EventArgs e)
        {
            Post comment = streamComments[Math.Abs(displayPostComments % streamComments.Count)];
            if (likeComment.Text == "like")
            {
                comment.likes.Add(currentUser.nickname);
                bl.SetLikes(comment);
                UpdatePosts();
                likeComment.Text = "unlike";
            }
            else if (likeComment.Text == "unlike")
            {
                comment.likes.Remove(currentUser.nickname);
                bl.SetLikes(comment);
                UpdatePosts();
                likeComment.Text = "like";
            }
        }
    }
}