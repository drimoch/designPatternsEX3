namespace MyFacebookUI
{
    public partial class EditEventForm
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
            this.eventNameTitle = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.endMonthCalender = new System.Windows.Forms.MonthCalendar();
            this.locationLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventNameTitle
            // 
            this.eventNameTitle.AutoSize = true;
            this.eventNameTitle.Location = new System.Drawing.Point(35, 9);
            this.eventNameTitle.Name = "eventNameTitle";
            this.eventNameTitle.Size = new System.Drawing.Size(43, 17);
            this.eventNameTitle.TabIndex = 0;
            this.eventNameTitle.Text = "name";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(35, 87);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(36, 17);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "start";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(461, 87);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(33, 17);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "End";
            // 
            // startMonthCalendar
            // 
            this.startMonthCalendar.Location = new System.Drawing.Point(38, 113);
            this.startMonthCalendar.Name = "startMonthCalendar";
            this.startMonthCalendar.TabIndex = 3;
            // 
            // endMonthCalander
            // 
            this.endMonthCalender.Location = new System.Drawing.Point(464, 113);
            this.endMonthCalender.Name = "endMonthCalander";
            this.endMonthCalender.TabIndex = 4;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.locationLabel.Location = new System.Drawing.Point(35, 372);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(83, 22);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.Text = "Location";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(35, 452);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(38, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(262, 22);
            this.nameTextBox.TabIndex = 7;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(38, 405);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(262, 22);
            this.locationTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(38, 488);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(688, 205);
            this.descriptionTextBox.TabIndex = 9;
            this.descriptionTextBox.Text = string.Empty;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(651, 705);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 10;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::MyFacebookUI.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 740);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.endMonthCalender);
            this.Controls.Add(this.startMonthCalendar);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.eventNameTitle);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEventForm";
            this.Text = "Edit Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventNameTitle;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.MonthCalendar startMonthCalendar;
        private System.Windows.Forms.MonthCalendar endMonthCalender;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button okBtn;
    }
}