namespace WindowsFacebook
{
    public partial class SoulMateForm
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
            this.labelYourSoulMateTitle = new System.Windows.Forms.Label();
            this.labelSoulMateName = new System.Windows.Forms.Label();
            this.pictureBoxSoulMate = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxGenderOptions = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoulMate)).BeginInit();
            this.groupBoxGenderOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelYourSoulMateTitle
            // 
            this.labelYourSoulMateTitle.AutoSize = true;
            this.labelYourSoulMateTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelYourSoulMateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourSoulMateTitle.Location = new System.Drawing.Point(43, 24);
            this.labelYourSoulMateTitle.Name = "labelYourSoulMateTitle";
            this.labelYourSoulMateTitle.Size = new System.Drawing.Size(184, 26);
            this.labelYourSoulMateTitle.TabIndex = 32;
            this.labelYourSoulMateTitle.Text = "Your Soul Mate:";
            // 
            // labelSoulMateName
            // 
            this.labelSoulMateName.AutoSize = true;
            this.labelSoulMateName.BackColor = System.Drawing.Color.Transparent;
            this.labelSoulMateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoulMateName.Location = new System.Drawing.Point(191, 75);
            this.labelSoulMateName.Name = "labelSoulMateName";
            this.labelSoulMateName.Size = new System.Drawing.Size(0, 17);
            this.labelSoulMateName.TabIndex = 33;
            // 
            // pictureBoxSoulMate
            // 
            this.pictureBoxSoulMate.Location = new System.Drawing.Point(194, 95);
            this.pictureBoxSoulMate.Name = "pictureBoxSoulMate";
            this.pictureBoxSoulMate.Size = new System.Drawing.Size(233, 213);
            this.pictureBoxSoulMate.TabIndex = 34;
            this.pictureBoxSoulMate.TabStop = false;
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
            this.buttonClose.TabIndex = 35;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(229, 387);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(152, 42);
            this.buttonSubmit.TabIndex = 36;
            this.buttonSubmit.Text = "Find my soul mate";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupBoxGenderOptions
            // 
            this.groupBoxGenderOptions.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxGenderOptions.Controls.Add(this.radioButtonFemale);
            this.groupBoxGenderOptions.Controls.Add(this.radioButtonMale);
            this.groupBoxGenderOptions.Location = new System.Drawing.Point(253, 314);
            this.groupBoxGenderOptions.Name = "groupBoxGenderOptions";
            this.groupBoxGenderOptions.Size = new System.Drawing.Size(109, 67);
            this.groupBoxGenderOptions.TabIndex = 37;
            this.groupBoxGenderOptions.TabStop = false;
            this.groupBoxGenderOptions.Text = "Gender Options";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(6, 40);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // SoulMateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxGenderOptions);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxSoulMate);
            this.Controls.Add(this.labelSoulMateName);
            this.Controls.Add(this.labelYourSoulMateTitle);
            this.Name = "SoulMateForm";
            this.Text = "SoulMateForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoulMate)).EndInit();
            this.groupBoxGenderOptions.ResumeLayout(false);
            this.groupBoxGenderOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYourSoulMateTitle;
        private System.Windows.Forms.Label labelSoulMateName;
        private System.Windows.Forms.PictureBox pictureBoxSoulMate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupBoxGenderOptions;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
    }
}