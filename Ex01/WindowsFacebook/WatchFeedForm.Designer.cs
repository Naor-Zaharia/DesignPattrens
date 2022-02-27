namespace WindowsFacebook
{
    public partial class WatchFeedForm
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
            this.listBoxMyFeed = new System.Windows.Forms.ListBox();
            this.pictureBoxFeed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).BeginInit();
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
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxMyFeed
            // 
            this.listBoxMyFeed.FormattingEnabled = true;
            this.listBoxMyFeed.Location = new System.Drawing.Point(66, 49);
            this.listBoxMyFeed.Name = "listBoxMyFeed";
            this.listBoxMyFeed.Size = new System.Drawing.Size(434, 368);
            this.listBoxMyFeed.TabIndex = 2;
            this.listBoxMyFeed.SelectedIndexChanged += new System.EventHandler(this.listBoxMyFeed_SelectedIndexChanged);
            // 
            // pictureBoxFeed
            // 
            this.pictureBoxFeed.Location = new System.Drawing.Point(544, 139);
            this.pictureBoxFeed.Name = "pictureBoxFeed";
            this.pictureBoxFeed.Size = new System.Drawing.Size(175, 158);
            this.pictureBoxFeed.TabIndex = 3;
            this.pictureBoxFeed.TabStop = false;
            // 
            // WatchFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxFeed);
            this.Controls.Add(this.listBoxMyFeed);
            this.Controls.Add(this.buttonClose);
            this.Location = new System.Drawing.Point(200, 50);
            this.Name = "WatchFeedForm";
            this.Text = "WatchFeedForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxMyFeed;
        private System.Windows.Forms.PictureBox pictureBoxFeed;
    }
}