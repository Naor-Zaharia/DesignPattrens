namespace WindowsFacebook
{
    public partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openedTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumsActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.likedPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchYourFeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeNewPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumsOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookOnYourAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookOnFriendsAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkFriendStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniqeFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soulMateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.labelCurrentUsername = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openedTabsToolStripMenuItem,
            this.albumsActionsToolStripMenuItem,
            this.postOperationsToolStripMenuItem,
            this.albumsOperationsToolStripMenuItem,
            this.groupsOperationsToolStripMenuItem,
            this.userActionsToolStripMenuItem,
            this.checkFriendStatusToolStripMenuItem,
            this.uniqeFeaturesToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.openedTabsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MainMenuStrip";
            // 
            // openedTabsToolStripMenuItem
            // 
            this.openedTabsToolStripMenuItem.Name = "openedTabsToolStripMenuItem";
            this.openedTabsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.openedTabsToolStripMenuItem.Text = "Opened Tabs";
            // 
            // albumsActionsToolStripMenuItem
            // 
            this.albumsActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.friendListToolStripMenuItem,
            this.likedPagesToolStripMenuItem,
            this.eventsToolStripMenuItem});
            this.albumsActionsToolStripMenuItem.Name = "albumsActionsToolStripMenuItem";
            this.albumsActionsToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.albumsActionsToolStripMenuItem.Text = "Profile Operations";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.myProfileToolStripMenuItem.Text = "My profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.lookOnYourProfileToolStripMenuItem_Click);
            // 
            // friendListToolStripMenuItem
            // 
            this.friendListToolStripMenuItem.Name = "friendListToolStripMenuItem";
            this.friendListToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.friendListToolStripMenuItem.Text = "Friends list";
            this.friendListToolStripMenuItem.Click += new System.EventHandler(this.getYouFriendsListToolStripMenuItem_Click);
            // 
            // likedPagesToolStripMenuItem
            // 
            this.likedPagesToolStripMenuItem.Name = "likedPagesToolStripMenuItem";
            this.likedPagesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.likedPagesToolStripMenuItem.Text = "Liked Pages";
            this.likedPagesToolStripMenuItem.Click += new System.EventHandler(this.likedPagesToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // postOperationsToolStripMenuItem
            // 
            this.postOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchYourFeedToolStripMenuItem,
            this.writeNewPostToolStripMenuItem});
            this.postOperationsToolStripMenuItem.Name = "postOperationsToolStripMenuItem";
            this.postOperationsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.postOperationsToolStripMenuItem.Text = "Posts Operations";
            // 
            // watchYourFeedToolStripMenuItem
            // 
            this.watchYourFeedToolStripMenuItem.Name = "watchYourFeedToolStripMenuItem";
            this.watchYourFeedToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.watchYourFeedToolStripMenuItem.Text = "Watch your feed";
            this.watchYourFeedToolStripMenuItem.Click += new System.EventHandler(this.watchYourFeedToolStripMenuItem_Click);
            // 
            // writeNewPostToolStripMenuItem
            // 
            this.writeNewPostToolStripMenuItem.Name = "writeNewPostToolStripMenuItem";
            this.writeNewPostToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.writeNewPostToolStripMenuItem.Text = "Write new post";
            this.writeNewPostToolStripMenuItem.Click += new System.EventHandler(this.writeNewPostToolStripMenuItem_Click);
            // 
            // albumsOperationsToolStripMenuItem
            // 
            this.albumsOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookOnYourAlbumsToolStripMenuItem,
            this.lookOnFriendsAlbumsToolStripMenuItem});
            this.albumsOperationsToolStripMenuItem.Name = "albumsOperationsToolStripMenuItem";
            this.albumsOperationsToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.albumsOperationsToolStripMenuItem.Text = "Albums Operations";
            // 
            // lookOnYourAlbumsToolStripMenuItem
            // 
            this.lookOnYourAlbumsToolStripMenuItem.Name = "lookOnYourAlbumsToolStripMenuItem";
            this.lookOnYourAlbumsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.lookOnYourAlbumsToolStripMenuItem.Text = "Look on your albums";
            this.lookOnYourAlbumsToolStripMenuItem.Click += new System.EventHandler(this.lookOnYourAlbumsToolStripMenuItem_Click);
            // 
            // lookOnFriendsAlbumsToolStripMenuItem
            // 
            this.lookOnFriendsAlbumsToolStripMenuItem.Name = "lookOnFriendsAlbumsToolStripMenuItem";
            this.lookOnFriendsAlbumsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.lookOnFriendsAlbumsToolStripMenuItem.Text = "Look on friends albums";
            this.lookOnFriendsAlbumsToolStripMenuItem.Click += new System.EventHandler(this.lookOnFriendsAlbumsToolStripMenuItem_Click);
            // 
            // groupsOperationsToolStripMenuItem
            // 
            this.groupsOperationsToolStripMenuItem.Name = "groupsOperationsToolStripMenuItem";
            this.groupsOperationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.groupsOperationsToolStripMenuItem.Text = "My Groups";
            this.groupsOperationsToolStripMenuItem.Click += new System.EventHandler(this.groupsOperationsToolStripMenuItem_Click);
            // 
            // userActionsToolStripMenuItem
            // 
            this.userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            this.userActionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.userActionsToolStripMenuItem.Text = "User Actions";
            this.userActionsToolStripMenuItem.Click += new System.EventHandler(this.userActionsToolStripMenuItem_Click);
            // 
            // checkFriendStatusToolStripMenuItem
            // 
            this.checkFriendStatusToolStripMenuItem.Name = "checkFriendStatusToolStripMenuItem";
            this.checkFriendStatusToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.checkFriendStatusToolStripMenuItem.Text = "Check Friend Status";
            this.checkFriendStatusToolStripMenuItem.Click += new System.EventHandler(this.checkFriendStatusToolStripMenuItem_Click);
            // 
            // uniqeFeaturesToolStripMenuItem
            // 
            this.uniqeFeaturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soulMateToolStripMenuItem,
            this.collageToolStripMenuItem});
            this.uniqeFeaturesToolStripMenuItem.Name = "uniqeFeaturesToolStripMenuItem";
            this.uniqeFeaturesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.uniqeFeaturesToolStripMenuItem.Text = "Uniqe Features";
            // 
            // soulMateToolStripMenuItem
            // 
            this.soulMateToolStripMenuItem.Name = "soulMateToolStripMenuItem";
            this.soulMateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.soulMateToolStripMenuItem.Text = "Find Your Soul Mate";
            this.soulMateToolStripMenuItem.Click += new System.EventHandler(this.soulMateToolStripMenuItem_Click);
            // 
            // collageToolStripMenuItem
            // 
            this.collageToolStripMenuItem.Name = "collageToolStripMenuItem";
            this.collageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.collageToolStripMenuItem.Text = "Create Collage";
            this.collageToolStripMenuItem.Click += new System.EventHandler(this.collageToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUser.Location = new System.Drawing.Point(9, 35);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(177, 17);
            this.labelCurrentUser.TabIndex = 1;
            this.labelCurrentUser.Text = "Current logged-in user:";
            // 
            // labelCurrentUsername
            // 
            this.labelCurrentUsername.AutoSize = true;
            this.labelCurrentUsername.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelCurrentUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUsername.Location = new System.Drawing.Point(10, 57);
            this.labelCurrentUsername.Name = "labelCurrentUsername";
            this.labelCurrentUsername.Size = new System.Drawing.Size(137, 17);
            this.labelCurrentUsername.TabIndex = 2;
            this.labelCurrentUsername.Text = "CurrentUserName";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBoxProfile.Location = new System.Drawing.Point(8, 77);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.BackColor = System.Drawing.Color.RoyalBlue;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(22, 213);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberMe.TabIndex = 5;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = false;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 615);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelCurrentUsername);
            this.Controls.Add(this.labelCurrentUser);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem albumsActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumsOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsOperationsToolStripMenuItem;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Label labelCurrentUsername;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ToolStripMenuItem uniqeFeaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchYourFeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeNewPostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookOnYourAlbumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookOnFriendsAlbumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friendListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soulMateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openedTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem likedPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.ToolStripMenuItem userActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkFriendStatusToolStripMenuItem;
    }
}