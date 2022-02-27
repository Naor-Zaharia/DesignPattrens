namespace WindowsFacebook
{
    public partial class MyAlbumsForm
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
            this.labelMyAlbumsTitle = new System.Windows.Forms.Label();
            this.listBoxMyAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbumsCover = new System.Windows.Forms.PictureBox();
            this.galleryPanelMyAlbums = new WindowsFacebook.GalleryPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCover)).BeginInit();
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
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelMyAlbumsTitle
            // 
            this.labelMyAlbumsTitle.AutoSize = true;
            this.labelMyAlbumsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelMyAlbumsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyAlbumsTitle.Location = new System.Drawing.Point(31, 37);
            this.labelMyAlbumsTitle.Name = "labelMyAlbumsTitle";
            this.labelMyAlbumsTitle.Size = new System.Drawing.Size(137, 26);
            this.labelMyAlbumsTitle.TabIndex = 24;
            this.labelMyAlbumsTitle.Text = "My Albums:";
            // 
            // listBoxMyAlbums
            // 
            this.listBoxMyAlbums.Location = new System.Drawing.Point(193, 57);
            this.listBoxMyAlbums.Name = "listBoxMyAlbums";
            this.listBoxMyAlbums.Size = new System.Drawing.Size(199, 355);
            this.listBoxMyAlbums.TabIndex = 25;
            this.listBoxMyAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxMyAlbums_SelectedIndexChanged);
            // 
            // pictureBoxAlbumsCover
            // 
            this.pictureBoxAlbumsCover.Location = new System.Drawing.Point(12, 66);
            this.pictureBoxAlbumsCover.Name = "pictureBoxAlbumsCover";
            this.pictureBoxAlbumsCover.Size = new System.Drawing.Size(176, 158);
            this.pictureBoxAlbumsCover.TabIndex = 26;
            this.pictureBoxAlbumsCover.TabStop = false;
            // 
            // galleryPanelMyAlbums
            // 
            this.galleryPanelMyAlbums.BackColor = System.Drawing.Color.RoyalBlue;
            this.galleryPanelMyAlbums.Location = new System.Drawing.Point(395, 84);
            this.galleryPanelMyAlbums.Name = "galleryPanelMyAlbums";
            this.galleryPanelMyAlbums.Size = new System.Drawing.Size(400, 300);
            this.galleryPanelMyAlbums.TabIndex = 27;
            // 
            // MyAlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.galleryPanelMyAlbums);
            this.Controls.Add(this.pictureBoxAlbumsCover);
            this.Controls.Add(this.listBoxMyAlbums);
            this.Controls.Add(this.labelMyAlbumsTitle);
            this.Controls.Add(this.buttonClose);
            this.Name = "MyAlbumsForm";
            this.Text = "MyAlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMyAlbumsTitle;
        private System.Windows.Forms.ListBox listBoxMyAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbumsCover;
        private GalleryPanel galleryPanelMyAlbums;
    }
}