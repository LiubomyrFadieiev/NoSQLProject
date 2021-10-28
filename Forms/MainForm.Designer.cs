
namespace NoSQLProject.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.streamTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.post1Button = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.post0Button = new System.Windows.Forms.Button();
            this.postBox1 = new System.Windows.Forms.RichTextBox();
            this.postBox0 = new System.Windows.Forms.RichTextBox();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.search1Button = new System.Windows.Forms.Button();
            this.upSearchText = new System.Windows.Forms.Button();
            this.search0Button = new System.Windows.Forms.Button();
            this.downSearchText = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.lengthButton = new System.Windows.Forms.Button();
            this.searchText0 = new System.Windows.Forms.RichTextBox();
            this.searchText1 = new System.Windows.Forms.RichTextBox();
            this.friendsButton = new System.Windows.Forms.Button();
            this.followersText = new System.Windows.Forms.TextBox();
            this.followsText = new System.Windows.Forms.TextBox();
            this.nicknameText = new System.Windows.Forms.TextBox();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.user1Button = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.user0Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upUserStream = new System.Windows.Forms.Button();
            this.downUserStream = new System.Windows.Forms.Button();
            this.publishText = new System.Windows.Forms.RichTextBox();
            this.userPost0 = new System.Windows.Forms.RichTextBox();
            this.userPost1 = new System.Windows.Forms.RichTextBox();
            this.userFollowers = new System.Windows.Forms.TextBox();
            this.userFollows = new System.Windows.Forms.TextBox();
            this.userNickname = new System.Windows.Forms.TextBox();
            this.userFullName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.streamTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.searchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.profileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.streamTab);
            this.tabControl1.Controls.Add(this.searchTab);
            this.tabControl1.Controls.Add(this.profileTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 622);
            this.tabControl1.TabIndex = 0;
            // 
            // streamTab
            // 
            this.streamTab.Controls.Add(this.splitContainer1);
            this.streamTab.Location = new System.Drawing.Point(4, 29);
            this.streamTab.Name = "streamTab";
            this.streamTab.Padding = new System.Windows.Forms.Padding(3);
            this.streamTab.Size = new System.Drawing.Size(1238, 589);
            this.streamTab.TabIndex = 0;
            this.streamTab.Text = "Stream";
            this.streamTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.post1Button);
            this.splitContainer1.Panel1.Controls.Add(this.downButton);
            this.splitContainer1.Panel1.Controls.Add(this.upButton);
            this.splitContainer1.Panel1.Controls.Add(this.post0Button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.postBox1);
            this.splitContainer1.Panel2.Controls.Add(this.postBox0);
            this.splitContainer1.Size = new System.Drawing.Size(983, 592);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 6;
            // 
            // post1Button
            // 
            this.post1Button.Location = new System.Drawing.Point(220, 303);
            this.post1Button.Name = "post1Button";
            this.post1Button.Size = new System.Drawing.Size(104, 62);
            this.post1Button.TabIndex = 3;
            this.post1Button.Text = "Post";
            this.post1Button.UseVisualStyleBackColor = true;
            this.post1Button.Click += new System.EventHandler(this.post1Button_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(27, 199);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(67, 72);
            this.downButton.TabIndex = 5;
            this.downButton.Text = "DOWN";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(27, 121);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(67, 72);
            this.upButton.TabIndex = 4;
            this.upButton.Text = "UP";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // post0Button
            // 
            this.post0Button.Location = new System.Drawing.Point(220, 5);
            this.post0Button.Name = "post0Button";
            this.post0Button.Size = new System.Drawing.Size(104, 62);
            this.post0Button.TabIndex = 0;
            this.post0Button.Text = "Post";
            this.post0Button.UseVisualStyleBackColor = true;
            this.post0Button.Click += new System.EventHandler(this.post0Button_Click);
            // 
            // postBox1
            // 
            this.postBox1.Location = new System.Drawing.Point(3, 303);
            this.postBox1.Name = "postBox1";
            this.postBox1.ReadOnly = true;
            this.postBox1.Size = new System.Drawing.Size(646, 266);
            this.postBox1.TabIndex = 1;
            this.postBox1.Text = "";
            // 
            // postBox0
            // 
            this.postBox0.Location = new System.Drawing.Point(3, 5);
            this.postBox0.Name = "postBox0";
            this.postBox0.ReadOnly = true;
            this.postBox0.Size = new System.Drawing.Size(646, 266);
            this.postBox0.TabIndex = 0;
            this.postBox0.Text = "";
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.splitContainer2);
            this.searchTab.Location = new System.Drawing.Point(4, 29);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(1238, 589);
            this.searchTab.TabIndex = 1;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.search1Button);
            this.splitContainer2.Panel1.Controls.Add(this.upSearchText);
            this.splitContainer2.Panel1.Controls.Add(this.search0Button);
            this.splitContainer2.Panel1.Controls.Add(this.downSearchText);
            this.splitContainer2.Panel1.Controls.Add(this.searchButton);
            this.splitContainer2.Panel1.Controls.Add(this.searchText);
            this.splitContainer2.Panel1.Controls.Add(this.searchLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lengthButton);
            this.splitContainer2.Panel2.Controls.Add(this.searchText0);
            this.splitContainer2.Panel2.Controls.Add(this.searchText1);
            this.splitContainer2.Panel2.Controls.Add(this.friendsButton);
            this.splitContainer2.Panel2.Controls.Add(this.followersText);
            this.splitContainer2.Panel2.Controls.Add(this.followsText);
            this.splitContainer2.Panel2.Controls.Add(this.nicknameText);
            this.splitContainer2.Panel2.Controls.Add(this.fullNameText);
            this.splitContainer2.Size = new System.Drawing.Size(1232, 583);
            this.splitContainer2.SplitterDistance = 410;
            this.splitContainer2.TabIndex = 0;
            // 
            // search1Button
            // 
            this.search1Button.Location = new System.Drawing.Point(317, 350);
            this.search1Button.Name = "search1Button";
            this.search1Button.Size = new System.Drawing.Size(90, 56);
            this.search1Button.TabIndex = 10;
            this.search1Button.Text = "Post";
            this.search1Button.UseVisualStyleBackColor = true;
            this.search1Button.Click += new System.EventHandler(this.search1Button_Click);
            // 
            // upSearchText
            // 
            this.upSearchText.Location = new System.Drawing.Point(23, 247);
            this.upSearchText.Name = "upSearchText";
            this.upSearchText.Size = new System.Drawing.Size(130, 66);
            this.upSearchText.TabIndex = 4;
            this.upSearchText.Text = "Up";
            this.upSearchText.UseVisualStyleBackColor = true;
            this.upSearchText.Click += new System.EventHandler(this.upSearchText_Click);
            // 
            // search0Button
            // 
            this.search0Button.Location = new System.Drawing.Point(317, 165);
            this.search0Button.Name = "search0Button";
            this.search0Button.Size = new System.Drawing.Size(90, 56);
            this.search0Button.TabIndex = 9;
            this.search0Button.Text = "Post";
            this.search0Button.UseVisualStyleBackColor = true;
            this.search0Button.Click += new System.EventHandler(this.search0Button_Click);
            // 
            // downSearchText
            // 
            this.downSearchText.Location = new System.Drawing.Point(23, 319);
            this.downSearchText.Name = "downSearchText";
            this.downSearchText.Size = new System.Drawing.Size(130, 66);
            this.downSearchText.TabIndex = 3;
            this.downSearchText.Text = "Down";
            this.downSearchText.UseVisualStyleBackColor = true;
            this.downSearchText.Click += new System.EventHandler(this.downSearchText_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(104, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 35);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(73, 49);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(200, 26);
            this.searchText.TabIndex = 1;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(69, 26);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(190, 20);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search User by nickname";
            // 
            // lengthButton
            // 
            this.lengthButton.BackColor = System.Drawing.Color.LightYellow;
            this.lengthButton.Enabled = false;
            this.lengthButton.Location = new System.Drawing.Point(419, 113);
            this.lengthButton.Name = "lengthButton";
            this.lengthButton.Size = new System.Drawing.Size(219, 46);
            this.lengthButton.TabIndex = 9;
            this.lengthButton.Text = "Find Length";
            this.lengthButton.UseVisualStyleBackColor = false;
            this.lengthButton.Click += new System.EventHandler(this.lengthButton_Click);
            // 
            // searchText0
            // 
            this.searchText0.Location = new System.Drawing.Point(3, 165);
            this.searchText0.Name = "searchText0";
            this.searchText0.ReadOnly = true;
            this.searchText0.Size = new System.Drawing.Size(635, 179);
            this.searchText0.TabIndex = 8;
            this.searchText0.Text = "";
            // 
            // searchText1
            // 
            this.searchText1.Location = new System.Drawing.Point(3, 350);
            this.searchText1.Name = "searchText1";
            this.searchText1.ReadOnly = true;
            this.searchText1.Size = new System.Drawing.Size(635, 235);
            this.searchText1.TabIndex = 7;
            this.searchText1.Text = "";
            // 
            // friendsButton
            // 
            this.friendsButton.Location = new System.Drawing.Point(419, 51);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(219, 56);
            this.friendsButton.TabIndex = 6;
            this.friendsButton.Text = "Follow";
            this.friendsButton.UseVisualStyleBackColor = true;
            this.friendsButton.Click += new System.EventHandler(this.friendsButton_Click);
            // 
            // followersText
            // 
            this.followersText.Location = new System.Drawing.Point(217, 81);
            this.followersText.Name = "followersText";
            this.followersText.ReadOnly = true;
            this.followersText.Size = new System.Drawing.Size(196, 26);
            this.followersText.TabIndex = 5;
            // 
            // followsText
            // 
            this.followsText.Location = new System.Drawing.Point(22, 81);
            this.followsText.Name = "followsText";
            this.followsText.ReadOnly = true;
            this.followsText.Size = new System.Drawing.Size(189, 26);
            this.followsText.TabIndex = 4;
            // 
            // nicknameText
            // 
            this.nicknameText.Location = new System.Drawing.Point(22, 49);
            this.nicknameText.Name = "nicknameText";
            this.nicknameText.ReadOnly = true;
            this.nicknameText.Size = new System.Drawing.Size(391, 26);
            this.nicknameText.TabIndex = 3;
            // 
            // fullNameText
            // 
            this.fullNameText.Location = new System.Drawing.Point(22, 19);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.ReadOnly = true;
            this.fullNameText.Size = new System.Drawing.Size(616, 26);
            this.fullNameText.TabIndex = 2;
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.splitContainer3);
            this.profileTab.Location = new System.Drawing.Point(4, 29);
            this.profileTab.Name = "profileTab";
            this.profileTab.Size = new System.Drawing.Size(1238, 589);
            this.profileTab.TabIndex = 2;
            this.profileTab.Text = "Profile";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.user1Button);
            this.splitContainer3.Panel1.Controls.Add(this.publishButton);
            this.splitContainer3.Panel1.Controls.Add(this.user0Button);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.upUserStream);
            this.splitContainer3.Panel1.Controls.Add(this.downUserStream);
            this.splitContainer3.Panel1.Controls.Add(this.publishText);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.userPost0);
            this.splitContainer3.Panel2.Controls.Add(this.userPost1);
            this.splitContainer3.Panel2.Controls.Add(this.userFollowers);
            this.splitContainer3.Panel2.Controls.Add(this.userFollows);
            this.splitContainer3.Panel2.Controls.Add(this.userNickname);
            this.splitContainer3.Panel2.Controls.Add(this.userFullName);
            this.splitContainer3.Size = new System.Drawing.Size(1238, 589);
            this.splitContainer3.SplitterDistance = 411;
            this.splitContainer3.TabIndex = 0;
            // 
            // user1Button
            // 
            this.user1Button.Location = new System.Drawing.Point(334, 535);
            this.user1Button.Name = "user1Button";
            this.user1Button.Size = new System.Drawing.Size(75, 43);
            this.user1Button.TabIndex = 17;
            this.user1Button.Text = "Post";
            this.user1Button.UseVisualStyleBackColor = true;
            this.user1Button.Click += new System.EventHandler(this.user1Button_Click);
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(152, 239);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(90, 54);
            this.publishButton.TabIndex = 16;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // user0Button
            // 
            this.user0Button.Location = new System.Drawing.Point(334, 294);
            this.user0Button.Name = "user0Button";
            this.user0Button.Size = new System.Drawing.Size(75, 43);
            this.user0Button.TabIndex = 16;
            this.user0Button.Text = "Post";
            this.user0Button.UseVisualStyleBackColor = true;
            this.user0Button.Click += new System.EventHandler(this.user0Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Write a post";
            // 
            // upUserStream
            // 
            this.upUserStream.Location = new System.Drawing.Point(39, 343);
            this.upUserStream.Name = "upUserStream";
            this.upUserStream.Size = new System.Drawing.Size(130, 66);
            this.upUserStream.TabIndex = 18;
            this.upUserStream.Text = "Up";
            this.upUserStream.UseVisualStyleBackColor = true;
            this.upUserStream.Click += new System.EventHandler(this.upUserStream_Click);
            // 
            // downUserStream
            // 
            this.downUserStream.Location = new System.Drawing.Point(39, 415);
            this.downUserStream.Name = "downUserStream";
            this.downUserStream.Size = new System.Drawing.Size(130, 66);
            this.downUserStream.TabIndex = 17;
            this.downUserStream.Text = "Down";
            this.downUserStream.UseVisualStyleBackColor = true;
            this.downUserStream.Click += new System.EventHandler(this.downUserStream_Click);
            // 
            // publishText
            // 
            this.publishText.Location = new System.Drawing.Point(0, 74);
            this.publishText.Name = "publishText";
            this.publishText.Size = new System.Drawing.Size(409, 159);
            this.publishText.TabIndex = 16;
            this.publishText.Text = "";
            // 
            // userPost0
            // 
            this.userPost0.Location = new System.Drawing.Point(19, 158);
            this.userPost0.Name = "userPost0";
            this.userPost0.ReadOnly = true;
            this.userPost0.Size = new System.Drawing.Size(635, 179);
            this.userPost0.TabIndex = 15;
            this.userPost0.Text = "";
            // 
            // userPost1
            // 
            this.userPost1.Location = new System.Drawing.Point(19, 343);
            this.userPost1.Name = "userPost1";
            this.userPost1.ReadOnly = true;
            this.userPost1.Size = new System.Drawing.Size(635, 235);
            this.userPost1.TabIndex = 14;
            this.userPost1.Text = "";
            // 
            // userFollowers
            // 
            this.userFollowers.Location = new System.Drawing.Point(361, 74);
            this.userFollowers.Name = "userFollowers";
            this.userFollowers.ReadOnly = true;
            this.userFollowers.Size = new System.Drawing.Size(293, 26);
            this.userFollowers.TabIndex = 12;
            // 
            // userFollows
            // 
            this.userFollows.Location = new System.Drawing.Point(38, 74);
            this.userFollows.Name = "userFollows";
            this.userFollows.ReadOnly = true;
            this.userFollows.Size = new System.Drawing.Size(317, 26);
            this.userFollows.TabIndex = 11;
            // 
            // userNickname
            // 
            this.userNickname.Location = new System.Drawing.Point(38, 42);
            this.userNickname.Name = "userNickname";
            this.userNickname.ReadOnly = true;
            this.userNickname.Size = new System.Drawing.Size(616, 26);
            this.userNickname.TabIndex = 10;
            // 
            // userFullName
            // 
            this.userFullName.Location = new System.Drawing.Point(38, 12);
            this.userFullName.Name = "userFullName";
            this.userFullName.ReadOnly = true;
            this.userFullName.Size = new System.Drawing.Size(616, 26);
            this.userFullName.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 664);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.streamTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage streamTab;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox postBox1;
        private System.Windows.Forms.RichTextBox postBox0;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox nicknameText;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.TextBox followersText;
        private System.Windows.Forms.TextBox followsText;
        private System.Windows.Forms.Button upSearchText;
        private System.Windows.Forms.Button downSearchText;
        private System.Windows.Forms.RichTextBox searchText0;
        private System.Windows.Forms.RichTextBox searchText1;
        private System.Windows.Forms.Button friendsButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upUserStream;
        private System.Windows.Forms.Button downUserStream;
        private System.Windows.Forms.RichTextBox publishText;
        private System.Windows.Forms.RichTextBox userPost0;
        private System.Windows.Forms.RichTextBox userPost1;
        private System.Windows.Forms.TextBox userFollowers;
        private System.Windows.Forms.TextBox userFollows;
        private System.Windows.Forms.TextBox userNickname;
        private System.Windows.Forms.TextBox userFullName;
        private System.Windows.Forms.Button post1Button;
        private System.Windows.Forms.Button post0Button;
        private System.Windows.Forms.Button search1Button;
        private System.Windows.Forms.Button search0Button;
        private System.Windows.Forms.Button user1Button;
        private System.Windows.Forms.Button user0Button;
        private System.Windows.Forms.Button lengthButton;
    }
}
