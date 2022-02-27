namespace WindowsFacebook
{
    public partial class UserActionsForm
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
            this.comboBoxActions = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dataGridViewActions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
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
            // comboBoxActions
            // 
            this.comboBoxActions.FormattingEnabled = true;
            this.comboBoxActions.Items.AddRange(new object[] {
            "music",
            "television",
            "movies",
            "books",
            "books.reads",
            "books.wants_to_read",
            "books.rates",
            "books.quotes",
            "fitness.runs",
            "fitness.walks",
            "fitness.bikes",
            "music.listens",
            "music.playlists",
            "news.reads",
            "news.publishes",
            "video.watches",
            "video.rates",
            "videos.wants_to_watch"});
            this.comboBoxActions.Location = new System.Drawing.Point(27, 11);
            this.comboBoxActions.Name = "comboBoxActions";
            this.comboBoxActions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActions.TabIndex = 37;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(154, 7);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(115, 30);
            this.buttonSubmit.TabIndex = 38;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dataGridViewActions
            // 
            this.dataGridViewActions.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActions.Location = new System.Drawing.Point(27, 43);
            this.dataGridViewActions.Name = "dataGridViewActions";
            this.dataGridViewActions.Size = new System.Drawing.Size(749, 395);
            this.dataGridViewActions.TabIndex = 39;
            // 
            // UserActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewActions);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxActions);
            this.Controls.Add(this.buttonClose);
            this.Name = "UserActionsForm";
            this.Text = "UserActionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxActions;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DataGridView dataGridViewActions;
    }
}