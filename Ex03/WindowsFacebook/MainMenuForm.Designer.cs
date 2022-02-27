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
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.labelCurrentUsername = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxFeed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMyFriends = new System.Windows.Forms.ListBox();
            this.listBoxMyFeed = new System.Windows.Forms.ListBox();
            this.buttonRefreshFriendsList = new System.Windows.Forms.Button();
            this.buttonRefreshFeeds = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxTheme = new System.Windows.Forms.GroupBox();
            this.radioButtonThemeYellow = new System.Windows.Forms.RadioButton();
            this.radioButtonThemeRed = new System.Windows.Forms.RadioButton();
            this.radioButtonThemeBlue = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).BeginInit();
            this.groupBoxTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.BackColor = System.Drawing.Color.PowderBlue;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUser.Location = new System.Drawing.Point(207, 22);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(177, 17);
            this.labelCurrentUser.TabIndex = 1;
            this.labelCurrentUser.Text = "Current logged-in user:";
            // 
            // labelCurrentUsername
            // 
            this.labelCurrentUsername.AutoSize = true;
            this.labelCurrentUsername.BackColor = System.Drawing.Color.PowderBlue;
            this.labelCurrentUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUsername.Location = new System.Drawing.Point(208, 44);
            this.labelCurrentUsername.Name = "labelCurrentUsername";
            this.labelCurrentUsername.Size = new System.Drawing.Size(137, 17);
            this.labelCurrentUsername.TabIndex = 2;
            this.labelCurrentUsername.Text = "CurrentUserName";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBoxProfile.Location = new System.Drawing.Point(206, 64);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.BackColor = System.Drawing.Color.PowderBlue;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(220, 200);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberMe.TabIndex = 5;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = false;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // pictureBoxFeed
            // 
            this.pictureBoxFeed.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBoxFeed.Location = new System.Drawing.Point(1207, 503);
            this.pictureBoxFeed.Name = "pictureBoxFeed";
            this.pictureBoxFeed.Size = new System.Drawing.Size(183, 129);
            this.pictureBoxFeed.TabIndex = 9;
            this.pictureBoxFeed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Friends List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1268, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Feeds";
            // 
            // listBoxMyFriends
            // 
            this.listBoxMyFriends.BackColor = System.Drawing.Color.PowderBlue;
            this.listBoxMyFriends.FormattingEnabled = true;
            this.listBoxMyFriends.Location = new System.Drawing.Point(205, 255);
            this.listBoxMyFriends.Name = "listBoxMyFriends";
            this.listBoxMyFriends.Size = new System.Drawing.Size(125, 329);
            this.listBoxMyFriends.TabIndex = 17;
            // 
            // listBoxMyFeed
            // 
            this.listBoxMyFeed.BackColor = System.Drawing.Color.PowderBlue;
            this.listBoxMyFeed.FormattingEnabled = true;
            this.listBoxMyFeed.Location = new System.Drawing.Point(1166, 44);
            this.listBoxMyFeed.Name = "listBoxMyFeed";
            this.listBoxMyFeed.Size = new System.Drawing.Size(254, 420);
            this.listBoxMyFeed.TabIndex = 18;
            this.listBoxMyFeed.SelectedIndexChanged += new System.EventHandler(this.listBoxMyFeed_SelectedIndexChanged);
            // 
            // buttonRefreshFriendsList
            // 
            this.buttonRefreshFriendsList.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRefreshFriendsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshFriendsList.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshFriendsList.Location = new System.Drawing.Point(210, 600);
            this.buttonRefreshFriendsList.Name = "buttonRefreshFriendsList";
            this.buttonRefreshFriendsList.Size = new System.Drawing.Size(112, 41);
            this.buttonRefreshFriendsList.TabIndex = 37;
            this.buttonRefreshFriendsList.Text = "Refresh Friends List";
            this.buttonRefreshFriendsList.UseVisualStyleBackColor = false;
            this.buttonRefreshFriendsList.Click += new System.EventHandler(this.buttonRefreshFriendsList_Click);
            // 
            // buttonRefreshFeeds
            // 
            this.buttonRefreshFeeds.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRefreshFeeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshFeeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshFeeds.Location = new System.Drawing.Point(1188, 476);
            this.buttonRefreshFeeds.Name = "buttonRefreshFeeds";
            this.buttonRefreshFeeds.Size = new System.Drawing.Size(216, 23);
            this.buttonRefreshFeeds.TabIndex = 38;
            this.buttonRefreshFeeds.Text = "Refresh Feed";
            this.buttonRefreshFeeds.UseVisualStyleBackColor = false;
            this.buttonRefreshFeeds.Click += new System.EventHandler(this.buttonRefreshFeeds_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Write Post";
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.Location = new System.Drawing.Point(980, 580);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(90, 26);
            this.buttonPost.TabIndex = 41;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.BackColor = System.Drawing.Color.PowderBlue;
            this.textBoxPost.Location = new System.Drawing.Point(477, 557);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(497, 69);
            this.textBoxPost.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(20, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 46;
            this.label4.Text = "Main Menu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(18, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Uniqe Features";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(8, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Albums Operations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(11, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Profile Operations";
            // 
            // groupBoxTheme
            // 
            this.groupBoxTheme.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBoxTheme.Controls.Add(this.radioButtonThemeYellow);
            this.groupBoxTheme.Controls.Add(this.radioButtonThemeRed);
            this.groupBoxTheme.Controls.Add(this.radioButtonThemeBlue);
            this.groupBoxTheme.Location = new System.Drawing.Point(15, 559);
            this.groupBoxTheme.Name = "groupBoxTheme";
            this.groupBoxTheme.Size = new System.Drawing.Size(169, 82);
            this.groupBoxTheme.TabIndex = 49;
            this.groupBoxTheme.TabStop = false;
            this.groupBoxTheme.Text = "Theme";
            // 
            // radioButtonThemeYellow
            // 
            this.radioButtonThemeYellow.AutoSize = true;
            this.radioButtonThemeYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButtonThemeYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonThemeYellow.ForeColor = System.Drawing.Color.Black;
            this.radioButtonThemeYellow.Location = new System.Drawing.Point(15, 56);
            this.radioButtonThemeYellow.Name = "radioButtonThemeYellow";
            this.radioButtonThemeYellow.Size = new System.Drawing.Size(62, 17);
            this.radioButtonThemeYellow.TabIndex = 2;
            this.radioButtonThemeYellow.Text = "Yellow";
            this.radioButtonThemeYellow.UseVisualStyleBackColor = false;
            this.radioButtonThemeYellow.CheckedChanged += new System.EventHandler(this.radioButtonThemeYellow_CheckedChanged);
            // 
            // radioButtonThemeRed
            // 
            this.radioButtonThemeRed.AutoSize = true;
            this.radioButtonThemeRed.BackColor = System.Drawing.Color.Red;
            this.radioButtonThemeRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonThemeRed.ForeColor = System.Drawing.Color.Black;
            this.radioButtonThemeRed.Location = new System.Drawing.Point(15, 38);
            this.radioButtonThemeRed.Name = "radioButtonThemeRed";
            this.radioButtonThemeRed.Size = new System.Drawing.Size(48, 17);
            this.radioButtonThemeRed.TabIndex = 1;
            this.radioButtonThemeRed.Text = "Red";
            this.radioButtonThemeRed.UseVisualStyleBackColor = false;
            this.radioButtonThemeRed.CheckedChanged += new System.EventHandler(this.radioButtonThemeRed_CheckedChanged);
            // 
            // radioButtonThemeBlue
            // 
            this.radioButtonThemeBlue.AutoSize = true;
            this.radioButtonThemeBlue.BackColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonThemeBlue.Checked = true;
            this.radioButtonThemeBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonThemeBlue.ForeColor = System.Drawing.Color.Black;
            this.radioButtonThemeBlue.Location = new System.Drawing.Point(15, 19);
            this.radioButtonThemeBlue.Name = "radioButtonThemeBlue";
            this.radioButtonThemeBlue.Size = new System.Drawing.Size(50, 17);
            this.radioButtonThemeBlue.TabIndex = 0;
            this.radioButtonThemeBlue.TabStop = true;
            this.radioButtonThemeBlue.Text = "Blue";
            this.radioButtonThemeBlue.UseVisualStyleBackColor = false;
            this.radioButtonThemeBlue.CheckedChanged += new System.EventHandler(this.radioButtonThemeBlue_CheckedChanged);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1434, 661);
            this.Controls.Add(this.groupBoxTheme);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRefreshFeeds);
            this.Controls.Add(this.buttonRefreshFriendsList);
            this.Controls.Add(this.listBoxMyFeed);
            this.Controls.Add(this.listBoxMyFriends);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFeed);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelCurrentUsername);
            this.Controls.Add(this.labelCurrentUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainMenuForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).EndInit();
            this.groupBoxTheme.ResumeLayout(false);
            this.groupBoxTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Label labelCurrentUsername;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBoxFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMyFriends;
        private System.Windows.Forms.ListBox listBoxMyFeed;
        private System.Windows.Forms.Button buttonRefreshFriendsList;
        private System.Windows.Forms.Button buttonRefreshFeeds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;    
        private System.Windows.Forms.GroupBox groupBoxTheme;
        private System.Windows.Forms.RadioButton radioButtonThemeYellow;
        private System.Windows.Forms.RadioButton radioButtonThemeRed;
        private System.Windows.Forms.RadioButton radioButtonThemeBlue;
    }
}