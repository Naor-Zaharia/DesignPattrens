namespace WindowsFacebook
{
    public partial class CollageForm
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
            this.pictureBoxCurrentAlbum = new System.Windows.Forms.PictureBox();
            this.listBoxCurrentAlbum = new System.Windows.Forms.ListBox();
            this.labelCollageTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelYourCollageTitle = new System.Windows.Forms.Label();
            this.groupBoxCollageOptions = new System.Windows.Forms.GroupBox();
            this.radioButtonRandomPhotos = new System.Windows.Forms.RadioButton();
            this.radioButtonMostLikedPhotos = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentAlbum)).BeginInit();
            this.groupBoxCollageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCurrentAlbum
            // 
            this.pictureBoxCurrentAlbum.Location = new System.Drawing.Point(6, 57);
            this.pictureBoxCurrentAlbum.Name = "pictureBoxCurrentAlbum";
            this.pictureBoxCurrentAlbum.Size = new System.Drawing.Size(79, 74);
            this.pictureBoxCurrentAlbum.TabIndex = 29;
            this.pictureBoxCurrentAlbum.TabStop = false;
            // 
            // listBoxCurrentAlbum
            // 
            this.listBoxCurrentAlbum.Location = new System.Drawing.Point(100, 57);
            this.listBoxCurrentAlbum.Name = "listBoxCurrentAlbum";
            this.listBoxCurrentAlbum.Size = new System.Drawing.Size(284, 368);
            this.listBoxCurrentAlbum.TabIndex = 32;
            this.listBoxCurrentAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxMyAlbums_SelectedIndexChanged);
            // 
            // labelCollageTitle
            // 
            this.labelCollageTitle.AutoSize = true;
            this.labelCollageTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCollageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollageTitle.Location = new System.Drawing.Point(12, 28);
            this.labelCollageTitle.Name = "labelCollageTitle";
            this.labelCollageTitle.Size = new System.Drawing.Size(290, 26);
            this.labelCollageTitle.TabIndex = 27;
            this.labelCollageTitle.Text = "Choose album for collage:";
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
            this.buttonClose.TabIndex = 30;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelYourCollageTitle
            // 
            this.labelYourCollageTitle.AutoSize = true;
            this.labelYourCollageTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelYourCollageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourCollageTitle.Location = new System.Drawing.Point(470, 82);
            this.labelYourCollageTitle.Name = "labelYourCollageTitle";
            this.labelYourCollageTitle.Size = new System.Drawing.Size(233, 26);
            this.labelYourCollageTitle.TabIndex = 31;
            this.labelYourCollageTitle.Text = "Your Album Collage:";
            // 
            // groupBoxCollageOptions
            // 
            this.groupBoxCollageOptions.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxCollageOptions.Controls.Add(this.radioButtonRandomPhotos);
            this.groupBoxCollageOptions.Controls.Add(this.radioButtonMostLikedPhotos);
            this.groupBoxCollageOptions.Location = new System.Drawing.Point(496, 364);
            this.groupBoxCollageOptions.Name = "groupBoxCollageOptions";
            this.groupBoxCollageOptions.Size = new System.Drawing.Size(183, 67);
            this.groupBoxCollageOptions.TabIndex = 33;
            this.groupBoxCollageOptions.TabStop = false;
            this.groupBoxCollageOptions.Text = "Collage Options";
            // 
            // radioButtonRandomPhotos
            // 
            this.radioButtonRandomPhotos.AutoSize = true;
            this.radioButtonRandomPhotos.Location = new System.Drawing.Point(6, 40);
            this.radioButtonRandomPhotos.Name = "radioButtonRandomPhotos";
            this.radioButtonRandomPhotos.Size = new System.Drawing.Size(101, 17);
            this.radioButtonRandomPhotos.TabIndex = 1;
            this.radioButtonRandomPhotos.TabStop = true;
            this.radioButtonRandomPhotos.Text = "Random Photos";
            this.radioButtonRandomPhotos.UseVisualStyleBackColor = true;        
            // 
            // radioButtonMostLikedPhotos
            // 
            this.radioButtonMostLikedPhotos.AutoSize = true;
            this.radioButtonMostLikedPhotos.Checked = true;
            this.radioButtonMostLikedPhotos.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMostLikedPhotos.Name = "radioButtonMostLikedPhotos";
            this.radioButtonMostLikedPhotos.Size = new System.Drawing.Size(113, 17);
            this.radioButtonMostLikedPhotos.TabIndex = 0;
            this.radioButtonMostLikedPhotos.TabStop = true;
            this.radioButtonMostLikedPhotos.Text = "Most Liked Photos";
            this.radioButtonMostLikedPhotos.UseVisualStyleBackColor = true;          
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(685, 378);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(99, 47);
            this.buttonSubmit.TabIndex = 37;
            this.buttonSubmit.Text = "Generate Collage";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // CollageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBoxCollageOptions);
            this.Controls.Add(this.labelYourCollageTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxCurrentAlbum);
            this.Controls.Add(this.listBoxCurrentAlbum);
            this.Controls.Add(this.labelCollageTitle);
            this.Name = "CollageForm";
            this.Text = "CollageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentAlbum)).EndInit();
            this.groupBoxCollageOptions.ResumeLayout(false);
            this.groupBoxCollageOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCurrentAlbum;
        private System.Windows.Forms.ListBox listBoxCurrentAlbum;
        private System.Windows.Forms.Label labelCollageTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelYourCollageTitle;
        private System.Windows.Forms.GroupBox groupBoxCollageOptions;
        private System.Windows.Forms.RadioButton radioButtonRandomPhotos;
        private System.Windows.Forms.RadioButton radioButtonMostLikedPhotos;
        private System.Windows.Forms.Button buttonSubmit;
    }
}