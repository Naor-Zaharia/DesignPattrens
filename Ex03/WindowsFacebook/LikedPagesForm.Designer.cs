namespace WindowsFacebook
{
    public partial class LikedPagesForm
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
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.labelLikedPages = new System.Windows.Forms.Label();
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
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxPages
            // 
            this.listBoxPages.Location = new System.Drawing.Point(139, 57);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(281, 290);
            this.listBoxPages.TabIndex = 23;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.BackColor = System.Drawing.Color.Transparent;
            this.labelLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikedPages.Location = new System.Drawing.Point(36, 57);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(102, 17);
            this.labelLikedPages.TabIndex = 22;
            this.labelLikedPages.Text = "Liked Pages:";
            // 
            // LikedPagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.buttonClose);
            this.Name = "LikedPagesForm";
            this.Text = "LikedPagesForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Label labelLikedPages;
    }
}