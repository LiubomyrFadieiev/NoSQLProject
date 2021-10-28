using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NeoDAL.DAL;
using NeoDAL.Objects;
using MongoDAL.DAL;
using MongoDAL.Objects;

namespace NoSQLProject
{
    public class BLogic
    {
        NeoUserDal nuDal;
        MongoUserDal muDal;
        MongoPostDal mpDal;
        public BLogic()
        {
            string connString = ConfigurationManager.ConnectionStrings["mongo"].ConnectionString;
            string neoConnString = ConfigurationManager.ConnectionStrings["neo4j"].ConnectionString;
            string username = ConfigurationManager.ConnectionStrings["neologin"].ConnectionString;
            string password = ConfigurationManager.ConnectionStrings["neopassword"].ConnectionString;

            nuDal = new NeoUserDal(neoConnString, username, password);
            muDal = new MongoUserDal(connString);
            mpDal = new MongoPostDal(connString);
        }
        //LogInForm Business Logic
        public (bool,User) Authorize(string credit, string password)
        {
            User user = muDal.GetUserByLogIn(password, credit);
            if (user.firstName != "")
            {
                return (true, user);
            }
            else
            {
                return (false, user);
            }
        }
        //MainForm business logic
        public List<Post> GetPostForStream(User user)
        {
            return mpDal.GetPostForStream(user);
        }
        public List<Post> GetUserPosts(string name)
        {
            return mpDal.GetUserPosts(name);
        }
        public (bool,string[]) GetUserByNickName(string name)
        {
            return muDal.GetUserByNickName(name);
        }
        public long GetFollowers(string name)
        {
            List<NeoUser> list = nuDal.GetFollowers(name);
            return list.Count();
        }
        public long GetFollows(string name)
        {
            List<NeoUser> list = nuDal.GetFollows(name);
            return list.Count();
        }
        public void SetFollowsList(User user, string follows, string action)
        {
            if (action == "add")
            {
                nuDal.SetFollower(user.nickname, follows);
            }else if (action == "remove")
            {
                nuDal.DeleteFollower(user.nickname, follows);
            }
        }
        public int GetLength(string user1, string user2)
        {
            return nuDal.FollowLength(user1, user2);
        }
        public void InsertPost(User user, string body)
        {
            mpDal.InsertPost(user, body);
        }
        //PostForm business logic
        public (bool, Post) GetParentPost(Post post)
        {
            return mpDal.GetParentPost(post);
        }
        public List<Post> GetPostsComments(Post post)
        {
            return mpDal.GetPostComments(post);
        }
        public int GetMaxId()
        {
            return mpDal.GetMaxId();
        }
        public void UpdateComments(Post post, User user, string body)
        {
            mpDal.UpdateComments(post, user, body);
        }
        public void SetLikes(Post post)
        {
            mpDal.SetLikes(post);
        }
    }
}
