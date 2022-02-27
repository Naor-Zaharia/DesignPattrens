namespace WindowsFacebook
{
    public partial class FriendsAlbumsForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.comboBoxFriends = new System.Windows.Forms.ComboBox();
            this.labelSoulMateName = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.galleryPanelFriendsAlbum = new WindowsFacebook.GalleryPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(757, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(19, 21);
            this.buttonClose.TabIndex = 36;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // comboBoxFriends
            // 
            this.comboBoxFriends.FormattingEnabled = true;
            this.comboBoxFriends.Location = new System.Drawing.Point(142, 13);
            this.comboBoxFriends.Name = "comboBoxFriends";
            this.comboBoxFriends.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFriends.TabIndex = 37;
            // 
            // labelSoulMateName
            // 
            this.labelSoulMateName.AutoSize = true;
            this.labelSoulMateName.BackColor = System.Drawing.Color.Transparent;
            this.labelSoulMateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoulMateName.Location = new System.Drawing.Point(22, 16);
            this.labelSoulMateName.Name = "labelSoulMateName";
            this.labelSoulMateName.Size = new System.Drawing.Size(114, 17);
            this.labelSoulMateName.TabIndex = 38;
            this.labelSoulMateName.Text = "Choose friend:";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Location = new System.Drawing.Point(185, 67);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(205, 355);
            this.listBoxAlbums.TabIndex = 39;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(269, 8);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(77, 29);
            this.buttonSubmit.TabIndex = 43;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(5, 67);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(176, 158);
            this.pictureBoxAlbum.TabIndex = 44;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // galleryPanelFriendsAlbum
            // 
            this.galleryPanelFriendsAlbum.BackColor = System.Drawing.Color.RoyalBlue;
            this.galleryPanelFriendsAlbum.Location = new System.Drawing.Point(395, 93);
            this.galleryPanelFriendsAlbum.Name = "galleryPanelFriendsAlbum";
            this.galleryPanelFriendsAlbum.Size = new System.Drawing.Size(400, 300);
            this.galleryPanelFriendsAlbum.TabIndex = 45;
            // 
            // FriendsAlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.galleryPanelFriendsAlbum);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.labelSoulMateName);
            this.Controls.Add(this.comboBoxFriends);
            this.Controls.Add(this.buttonClose);
            this.Name = "FriendsAlbumsForm";
            this.Text = "FriendsAlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxFriends;
        private System.Windows.Forms.Label labelSoulMateName;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private GalleryPanel galleryPanelFriendsAlbum;
    }
}