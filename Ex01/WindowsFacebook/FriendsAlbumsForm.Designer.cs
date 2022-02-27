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
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBoxCurrentPhoto = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPhoto)).BeginInit();
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
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(556, 310);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(77, 29);
            this.buttonPrev.TabIndex = 41;
            this.buttonPrev.Text = "Back";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(657, 310);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(77, 29);
            this.buttonNext.TabIndex = 42;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // pictureBoxCurrentPhoto
            // 
            this.pictureBoxCurrentPhoto.Location = new System.Drawing.Point(499, 107);
            this.pictureBoxCurrentPhoto.Name = "pictureBoxCurrentPhoto";
            this.pictureBoxCurrentPhoto.Size = new System.Drawing.Size(270, 197);
            this.pictureBoxCurrentPhoto.TabIndex = 40;
            this.pictureBoxCurrentPhoto.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Location = new System.Drawing.Point(187, 67);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(289, 355);
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
            // FriendsAlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBoxCurrentPhoto);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.labelSoulMateName);
            this.Controls.Add(this.comboBoxFriends);
            this.Controls.Add(this.buttonClose);
            this.Name = "FriendsAlbumsForm";
            this.Text = "FriendsAlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxFriends;
        private System.Windows.Forms.Label labelSoulMateName;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBoxCurrentPhoto;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
    }
}