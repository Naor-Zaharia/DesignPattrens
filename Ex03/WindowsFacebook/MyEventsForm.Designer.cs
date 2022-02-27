namespace WindowsFacebook
{
    public partial class MyEventsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label interestedCountLabel;
            System.Windows.Forms.Label linkToFacebookLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label maybeCountLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label noReplyCountLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label nameLabel1;
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelEventsTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.interestedCountTextBox = new System.Windows.Forms.TextBox();
            this.linkToFacebookLabel1 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.maybeCountTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.noReplyCountTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAlphabetic = new System.Windows.Forms.RadioButton();
            this.radioButtonCounter = new System.Windows.Forms.RadioButton();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            imageNormalLabel = new System.Windows.Forms.Label();
            interestedCountLabel = new System.Windows.Forms.Label();
            linkToFacebookLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            maybeCountLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            noReplyCountLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(18, 62);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(15, 197);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Location = new System.Drawing.Point(18, 85);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(75, 13);
            imageNormalLabel.TabIndex = 4;
            imageNormalLabel.Text = "Image Normal:";
            // 
            // interestedCountLabel
            // 
            interestedCountLabel.AutoSize = true;
            interestedCountLabel.Location = new System.Drawing.Point(15, 221);
            interestedCountLabel.Name = "interestedCountLabel";
            interestedCountLabel.Size = new System.Drawing.Size(88, 13);
            interestedCountLabel.TabIndex = 6;
            interestedCountLabel.Text = "Interested Count:";
            // 
            // linkToFacebookLabel
            // 
            linkToFacebookLabel.AutoSize = true;
            linkToFacebookLabel.Location = new System.Drawing.Point(12, 329);
            linkToFacebookLabel.Name = "linkToFacebookLabel";
            linkToFacebookLabel.Size = new System.Drawing.Size(97, 13);
            linkToFacebookLabel.TabIndex = 8;
            linkToFacebookLabel.Text = "Link To Facebook:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(15, 144);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 10;
            locationLabel.Text = "Location:";
            // 
            // maybeCountLabel
            // 
            maybeCountLabel.AutoSize = true;
            maybeCountLabel.Location = new System.Drawing.Point(15, 247);
            maybeCountLabel.Name = "maybeCountLabel";
            maybeCountLabel.Size = new System.Drawing.Size(73, 13);
            maybeCountLabel.TabIndex = 12;
            maybeCountLabel.Text = "Maybe Count:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 36);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // noReplyCountLabel
            // 
            noReplyCountLabel.AutoSize = true;
            noReplyCountLabel.Location = new System.Drawing.Point(15, 273);
            noReplyCountLabel.Name = "noReplyCountLabel";
            noReplyCountLabel.Size = new System.Drawing.Size(85, 13);
            noReplyCountLabel.TabIndex = 16;
            noReplyCountLabel.Text = "No Reply Count:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(15, 171);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 18;
            startTimeLabel.Text = "Start Time:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(12, 303);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(72, 13);
            nameLabel1.TabIndex = 20;
            nameLabel1.Text = "Owner Name:";
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
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.Location = new System.Drawing.Point(128, 44);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(289, 355);
            this.listBoxEvents.TabIndex = 3;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // labelEventsTitle
            // 
            this.labelEventsTitle.AutoSize = true;
            this.labelEventsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelEventsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsTitle.Location = new System.Drawing.Point(30, 44);
            this.labelEventsTitle.Name = "labelEventsTitle";
            this.labelEventsTitle.Size = new System.Drawing.Size(87, 17);
            this.labelEventsTitle.TabIndex = 4;
            this.labelEventsTitle.Text = "My Events:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(nameLabel1);
            this.groupBox1.Controls.Add(this.nameTextBox1);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(endTimeLabel);
            this.groupBox1.Controls.Add(this.endTimeDateTimePicker);
            this.groupBox1.Controls.Add(imageNormalLabel);
            this.groupBox1.Controls.Add(this.imageNormalPictureBox);
            this.groupBox1.Controls.Add(interestedCountLabel);
            this.groupBox1.Controls.Add(this.interestedCountTextBox);
            this.groupBox1.Controls.Add(linkToFacebookLabel);
            this.groupBox1.Controls.Add(this.linkToFacebookLabel1);
            this.groupBox1.Controls.Add(locationLabel);
            this.groupBox1.Controls.Add(this.locationTextBox);
            this.groupBox1.Controls.Add(maybeCountLabel);
            this.groupBox1.Controls.Add(this.maybeCountTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(noReplyCountLabel);
            this.groupBox1.Controls.Add(this.noReplyCountTextBox);
            this.groupBox1.Controls.Add(startTimeLabel);
            this.groupBox1.Controls.Add(this.startTimeDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(428, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 372);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Owner.Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(118, 296);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox1.TabIndex = 21;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(121, 59);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(118, 193);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(121, 85);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(60, 50);
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // interestedCountTextBox
            // 
            this.interestedCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "InterestedCount", true));
            this.interestedCountTextBox.Location = new System.Drawing.Point(118, 218);
            this.interestedCountTextBox.Name = "interestedCountTextBox";
            this.interestedCountTextBox.Size = new System.Drawing.Size(200, 20);
            this.interestedCountTextBox.TabIndex = 7;
            // 
            // linkToFacebookLabel1
            // 
            this.linkToFacebookLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLabel1.Location = new System.Drawing.Point(115, 329);
            this.linkToFacebookLabel1.Name = "linkToFacebookLabel1";
            this.linkToFacebookLabel1.Size = new System.Drawing.Size(200, 23);
            this.linkToFacebookLabel1.TabIndex = 9;
            this.linkToFacebookLabel1.Text = "label1";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(118, 141);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationTextBox.TabIndex = 11;
            // 
            // maybeCountTextBox
            // 
            this.maybeCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "MaybeCount", true));
            this.maybeCountTextBox.Location = new System.Drawing.Point(118, 244);
            this.maybeCountTextBox.Name = "maybeCountTextBox";
            this.maybeCountTextBox.Size = new System.Drawing.Size(200, 20);
            this.maybeCountTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(121, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // noReplyCountTextBox
            // 
            this.noReplyCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "NoReplyCount", true));
            this.noReplyCountTextBox.Location = new System.Drawing.Point(118, 270);
            this.noReplyCountTextBox.Name = "noReplyCountTextBox";
            this.noReplyCountTextBox.Size = new System.Drawing.Size(200, 20);
            this.noReplyCountTextBox.TabIndex = 17;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(118, 167);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startTimeDateTimePicker.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Controls.Add(this.radioButtonDate);
            this.groupBox2.Controls.Add(this.radioButtonCounter);
            this.groupBox2.Controls.Add(this.radioButtonAlphabetic);
            this.groupBox2.Location = new System.Drawing.Point(128, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 42);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort By";
            // 
            // radioButtonAlphabetic
            // 
            this.radioButtonAlphabetic.AutoSize = true;
            this.radioButtonAlphabetic.Checked = true;
            this.radioButtonAlphabetic.Location = new System.Drawing.Point(6, 16);
            this.radioButtonAlphabetic.Name = "radioButtonAlphabetic";
            this.radioButtonAlphabetic.Size = new System.Drawing.Size(75, 17);
            this.radioButtonAlphabetic.TabIndex = 0;
            this.radioButtonAlphabetic.TabStop = true;
            this.radioButtonAlphabetic.Text = "Alphabetic";
            this.radioButtonAlphabetic.UseVisualStyleBackColor = true;
            this.radioButtonAlphabetic.CheckedChanged += new System.EventHandler(this.radioButtonAlphabetic_CheckedChanged);
            // 
            // radioButtonCounter
            // 
            this.radioButtonCounter.AutoSize = true;
            this.radioButtonCounter.Location = new System.Drawing.Point(82, 16);
            this.radioButtonCounter.Name = "radioButtonCounter";
            this.radioButtonCounter.Size = new System.Drawing.Size(110, 17);
            this.radioButtonCounter.TabIndex = 1;
            this.radioButtonCounter.Text = "Attending Counter";
            this.radioButtonCounter.UseVisualStyleBackColor = true;
            this.radioButtonCounter.CheckedChanged += new System.EventHandler(this.radioButtonCounter_CheckedChanged);
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(195, 16);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDate.TabIndex = 2;
            this.radioButtonDate.Text = "Start Date";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.CheckedChanged += new System.EventHandler(this.radioButtonDate_CheckedChanged);
            // 
            // MyEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFacebook.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelEventsTitle);
            this.Controls.Add(this.buttonClose);
            this.Location = new System.Drawing.Point(200, 50);
            this.Name = "MyEventsForm";
            this.Text = "WatchYourEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelEventsTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox interestedCountTextBox;
        private System.Windows.Forms.Label linkToFacebookLabel1;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox maybeCountTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox noReplyCountTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.RadioButton radioButtonCounter;
        private System.Windows.Forms.RadioButton radioButtonAlphabetic;
    }
}