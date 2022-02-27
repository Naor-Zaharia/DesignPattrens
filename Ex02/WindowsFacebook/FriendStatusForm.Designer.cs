﻿namespace WindowsFacebook
{
    public partial class FriendStatusForm
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelSoulMateName = new System.Windows.Forms.Label();
            this.comboBoxFriends = new System.Windows.Forms.ComboBox();
            this.labelFriendStatusTitle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
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
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(328, 126);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(77, 29);
            this.buttonSubmit.TabIndex = 46;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelSoulMateName
            // 
            this.labelSoulMateName.AutoSize = true;
            this.labelSoulMateName.BackColor = System.Drawing.Color.Transparent;
            this.labelSoulMateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoulMateName.Location = new System.Drawing.Point(81, 134);
            this.labelSoulMateName.Name = "labelSoulMateName";
            this.labelSoulMateName.Size = new System.Drawing.Size(114, 17);
            this.labelSoulMateName.TabIndex = 45;
            this.labelSoulMateName.Text = "Choose friend:";
            // 
            // comboBoxFriends
            // 
            this.comboBoxFriends.FormattingEnabled = true;
            this.comboBoxFriends.Location = new System.Drawing.Point(201, 131);
            this.comboBoxFriends.Name = "comboBoxFriends";
            this.comboBoxFriends.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFriends.TabIndex = 44;
            // 
            // labelFriendStatusTitle
            // 
            this.labelFriendStatusTitle.AutoSize = true;
            this.labelFriendStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelFriendStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendStatusTitle.Location = new System.Drawing.Point(111, 228);
            this.labelFriendStatusTitle.Name = "labelFriendStatusTitle";
            this.labelFriendStatusTitle.Size = new System.Drawing.Size(125, 17);
            this.labelFriendStatusTitle.TabIndex = 47;
            this.labelFriendStatusTitle.Text = "Friend status is:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(242, 228);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            this.labelStatus.TabIndex = 47;
            // 
            // FriendStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelFriendStatusTitle);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelSoulMateName);
            this.Controls.Add(this.comboBoxFriends);
            this.Controls.Add(this.buttonClose);
            this.Name = "FriendStatusForm";
            this.Text = "FriendStatusForm";
            this.Load += new System.EventHandler(this.friendStatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelSoulMateName;
        private System.Windows.Forms.ComboBox comboBoxFriends;
        private System.Windows.Forms.Label labelFriendStatusTitle;
        private System.Windows.Forms.Label labelStatus;
    }
}