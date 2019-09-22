using System;

namespace MyFacebookUI
{
    public partial class FacebookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.EventsOnDateLabel = new System.Windows.Forms.Label();
            this.EventsOnDateListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.postbtn = new System.Windows.Forms.Button();
            this.postEventTextBox = new System.Windows.Forms.RichTextBox();
            this.birthDayFriendsListBox = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.loginbtn = new System.Windows.Forms.Button();
            this.tabPageGuessWhoGame = new System.Windows.Forms.TabPage();
            this.featureHeadline = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hintButton = new System.Windows.Forms.Button();
            this.liveBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.submitBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.imageProfileBox = new System.Windows.Forms.PictureBox();
            this.tabPageChooseBlur = new System.Windows.Forms.TabPage();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.labelTrans = new System.Windows.Forms.Label();
            this.labelGamma = new System.Windows.Forms.Label();
            this.labelBlur = new System.Windows.Forms.Label();
            this.blurHeadLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxTranparent = new System.Windows.Forms.PictureBox();
            this.pictureBoxGamma = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxBlur = new System.Windows.Forms.PictureBox();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageGuessWhoGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featureHeadline)).BeginInit();
            this.liveBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfileBox)).BeginInit();
            this.tabPageChooseBlur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurHeadLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTranparent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlur)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPageGuessWhoGame);
            this.TabControl.Controls.Add(this.tabPageChooseBlur);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.RightToLeft = this.RightToLeft;
            this.TabControl.RightToLeftLayout = true;
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::MyFacebookUI.Properties.Resources.backgroundImage;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.rememberMeCheckBox);
            this.tabPage1.Controls.Add(this.logoutbtn);
            this.tabPage1.Controls.Add(this.EventsOnDateLabel);
            this.tabPage1.Controls.Add(this.EventsOnDateListBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.postbtn);
            this.tabPage1.Controls.Add(this.postEventTextBox);
            this.tabPage1.Controls.Add(this.birthDayFriendsListBox);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.loginbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Events center";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Location = new System.Drawing.Point(662, 128);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(122, 21);
            this.rememberMeCheckBox.TabIndex = 10;
            this.rememberMeCheckBox.Text = "Remember Me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logoutbtn.Image = global::MyFacebookUI.Properties.Resources.logout_icon_resize2;
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutbtn.Location = new System.Drawing.Point(662, 74);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(122, 39);
            this.logoutbtn.TabIndex = 9;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // EventsOnDateLabel
            // 
            this.EventsOnDateLabel.AutoSize = true;
            this.EventsOnDateLabel.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.EventsOnDateLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EventsOnDateLabel.Location = new System.Drawing.Point(371, 220);
            this.EventsOnDateLabel.Name = "EventsOnDateLabel";
            this.EventsOnDateLabel.Size = new System.Drawing.Size(177, 22);
            this.EventsOnDateLabel.TabIndex = 8;
            this.EventsOnDateLabel.Text = "Events Coming Up:";
            // 
            // EventsOnDateListBox
            // 
            this.EventsOnDateListBox.FormattingEnabled = true;
            this.EventsOnDateListBox.ItemHeight = 16;
            this.EventsOnDateListBox.Location = new System.Drawing.Point(374, 246);
            this.EventsOnDateListBox.Name = "EventsOnDateListBox";
            this.EventsOnDateListBox.Size = new System.Drawing.Size(262, 132);
            this.EventsOnDateListBox.TabIndex = 7;
            this.EventsOnDateListBox.SelectedIndexChanged += new System.EventHandler(this.EventsOnDateListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(8, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wish Them Happy Birthday!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(370, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Friends Birthday\'s:";
            // 
            // postbtn
            // 
            this.postbtn.BackColor = System.Drawing.Color.Transparent;
            this.postbtn.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.postbtn.Location = new System.Drawing.Point(162, 381);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(108, 32);
            this.postbtn.TabIndex = 4;
            this.postbtn.Text = "Post";
            this.postbtn.UseVisualStyleBackColor = false;
            this.postbtn.Visible = false;
            this.postbtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // postEventTextBox
            // 
            this.postEventTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.postEventTextBox.Location = new System.Drawing.Point(9, 279);
            this.postEventTextBox.Name = "postEventTextBox";
            this.postEventTextBox.Size = new System.Drawing.Size(262, 96);
            this.postEventTextBox.TabIndex = 3;
            this.postEventTextBox.Text = string.Empty;
            // 
            // birthDayFriendsListBox
            // 
            this.birthDayFriendsListBox.FormattingEnabled = true;
            this.birthDayFriendsListBox.ItemHeight = 16;
            this.birthDayFriendsListBox.Location = new System.Drawing.Point(374, 63);
            this.birthDayFriendsListBox.Name = "birthDayFriendsListBox";
            this.birthDayFriendsListBox.Size = new System.Drawing.Size(262, 132);
            this.birthDayFriendsListBox.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 30);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginbtn.Image = global::MyFacebookUI.Properties.Resources.login_icon_resize_2;
            this.loginbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginbtn.Location = new System.Drawing.Point(662, 17);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(122, 41);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // tabPageGuessWhoGame
            // 
            this.tabPageGuessWhoGame.BackgroundImage = global::MyFacebookUI.Properties.Resources.backgroundImage;
            this.tabPageGuessWhoGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageGuessWhoGame.Controls.Add(this.featureHeadline);
            this.tabPageGuessWhoGame.Controls.Add(this.label1);
            this.tabPageGuessWhoGame.Controls.Add(this.hintButton);
            this.tabPageGuessWhoGame.Controls.Add(this.liveBox);
            this.tabPageGuessWhoGame.Controls.Add(this.submitBox);
            this.tabPageGuessWhoGame.Controls.Add(this.submit);
            this.tabPageGuessWhoGame.Controls.Add(this.playAgain);
            this.tabPageGuessWhoGame.Controls.Add(this.imageProfileBox);
            this.tabPageGuessWhoGame.Location = new System.Drawing.Point(4, 25);
            this.tabPageGuessWhoGame.Name = "tabPageGuessWhoGame";
            this.tabPageGuessWhoGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGuessWhoGame.Size = new System.Drawing.Size(792, 421);
            this.tabPageGuessWhoGame.TabIndex = 1;
            this.tabPageGuessWhoGame.Text = "Guess Who? - 2";
            this.tabPageGuessWhoGame.UseVisualStyleBackColor = true;
            // 
            // featureHeadline
            // 
            this.featureHeadline.BackgroundImage = global::MyFacebookUI.Properties.Resources.GuessWhoHeadLine;
            this.featureHeadline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.featureHeadline.Location = new System.Drawing.Point(79, 6);
            this.featureHeadline.Name = "featureHeadline";
            this.featureHeadline.Size = new System.Drawing.Size(323, 50);
            this.featureHeadline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.featureHeadline.TabIndex = 17;
            this.featureHeadline.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 52);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pay Attention! \r\n A hint will cost you one live";
            // 
            // hintButton
            // 
            this.hintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hintButton.AutoSize = true;
            this.hintButton.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hintButton.Location = new System.Drawing.Point(538, 82);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(133, 36);
            this.hintButton.TabIndex = 15;
            this.hintButton.Text = "Hint!";
            this.hintButton.UseVisualStyleBackColor = true;
            this.hintButton.Click += new System.EventHandler(this.hintButton_Click);
            // 
            // liveBox
            // 
            this.liveBox.Controls.Add(this.pictureBox1);
            this.liveBox.Controls.Add(this.pictureBox7);
            this.liveBox.Controls.Add(this.pictureBox2);
            this.liveBox.Controls.Add(this.pictureBox6);
            this.liveBox.Controls.Add(this.pictureBox3);
            this.liveBox.Controls.Add(this.pictureBox5);
            this.liveBox.Controls.Add(this.pictureBox4);
            this.liveBox.Location = new System.Drawing.Point(497, 135);
            this.liveBox.Name = "liveBox";
            this.liveBox.Size = new System.Drawing.Size(252, 194);
            this.liveBox.TabIndex = 14;
            this.liveBox.TabStop = false;
            this.liveBox.Text = "Lives:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(6, 143);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(53, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(78, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(158, 81);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(158, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(78, 81);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(6, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // submitBox
            // 
            this.submitBox.Location = new System.Drawing.Point(155, 369);
            this.submitBox.Name = "submitBox";
            this.submitBox.Size = new System.Drawing.Size(144, 22);
            this.submitBox.TabIndex = 6;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.submit.Location = new System.Drawing.Point(315, 364);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(108, 27);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // playAgain
            // 
            this.playAgain.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.playAgain.Location = new System.Drawing.Point(538, 28);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(133, 36);
            this.playAgain.TabIndex = 4;
            this.playAgain.Text = "Restart!";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Click += new System.EventHandler(this.restart_Click);
            // 
            // imageProfileBox
            // 
            this.imageProfileBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imageProfileBox.Location = new System.Drawing.Point(113, 102);
            this.imageProfileBox.Name = "imageProfileBox";
            this.imageProfileBox.Size = new System.Drawing.Size(252, 221);
            this.imageProfileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageProfileBox.TabIndex = 0;
            this.imageProfileBox.TabStop = false;
            // 
            // tabPageChooseBlur
            // 
            this.tabPageChooseBlur.BackgroundImage = global::MyFacebookUI.Properties.Resources.backgroundImage;
            this.tabPageChooseBlur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageChooseBlur.Controls.Add(this.labelOrigin);
            this.tabPageChooseBlur.Controls.Add(this.pictureBox8);
            this.tabPageChooseBlur.Controls.Add(this.labelTrans);
            this.tabPageChooseBlur.Controls.Add(this.labelGamma);
            this.tabPageChooseBlur.Controls.Add(this.labelBlur);
            this.tabPageChooseBlur.Controls.Add(this.blurHeadLine);
            this.tabPageChooseBlur.Controls.Add(this.pictureBoxTranparent);
            this.tabPageChooseBlur.Controls.Add(this.pictureBoxGamma);
            this.tabPageChooseBlur.Controls.Add(this.label4);
            this.tabPageChooseBlur.Controls.Add(this.pictureBoxBlur);
            this.tabPageChooseBlur.Location = new System.Drawing.Point(4, 25);
            this.tabPageChooseBlur.Name = "tabPageChooseBlur";
            this.tabPageChooseBlur.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChooseBlur.Size = new System.Drawing.Size(792, 421);
            this.tabPageChooseBlur.TabIndex = 2;
            this.tabPageChooseBlur.Text = "Guess Who? - 1";
            this.tabPageChooseBlur.UseVisualStyleBackColor = true;
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigin.Location = new System.Drawing.Point(599, 18);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(86, 22);
            this.labelOrigin.TabIndex = 23;
            this.labelOrigin.Text = "Originial:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::MyFacebookUI.Properties.Resources.mark_zuckerberg;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(549, 56);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(198, 149);
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // labelTrans
            // 
            this.labelTrans.AutoSize = true;
            this.labelTrans.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.labelTrans.Location = new System.Drawing.Point(577, 230);
            this.labelTrans.Name = "labelTrans";
            this.labelTrans.Size = new System.Drawing.Size(129, 22);
            this.labelTrans.TabIndex = 21;
            this.labelTrans.Text = "Transparency:";
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.labelGamma.Location = new System.Drawing.Point(324, 230);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(80, 22);
            this.labelGamma.TabIndex = 20;
            this.labelGamma.Text = "Gamma:";
            // 
            // labelBlur
            // 
            this.labelBlur.AutoSize = true;
            this.labelBlur.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
            this.labelBlur.Location = new System.Drawing.Point(69, 232);
            this.labelBlur.Name = "labelBlur";
            this.labelBlur.Size = new System.Drawing.Size(51, 22);
            this.labelBlur.TabIndex = 19;
            this.labelBlur.Text = "Blur:";
            // 
            // blurHeadLine
            // 
            this.blurHeadLine.BackgroundImage = global::MyFacebookUI.Properties.Resources.GuessWhoHeadLine;
            this.blurHeadLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blurHeadLine.Location = new System.Drawing.Point(120, 9);
            this.blurHeadLine.Name = "blurHeadLine";
            this.blurHeadLine.Size = new System.Drawing.Size(323, 50);
            this.blurHeadLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blurHeadLine.TabIndex = 18;
            this.blurHeadLine.TabStop = false;
            // 
            // pictureBoxTranparent
            // 
            this.pictureBoxTranparent.BackgroundImage = global::MyFacebookUI.Properties.Resources.mark_zuckerberg_transparency;
            this.pictureBoxTranparent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTranparent.Location = new System.Drawing.Point(551, 263);
            this.pictureBoxTranparent.Name = "pictureBoxTranparent";
            this.pictureBoxTranparent.Size = new System.Drawing.Size(179, 150);
            this.pictureBoxTranparent.TabIndex = 3;
            this.pictureBoxTranparent.TabStop = false;
            this.pictureBoxTranparent.Click += new System.EventHandler(this.pictureBoxTranparent_Click);
            // 
            // pictureBoxGamma
            // 
            this.pictureBoxGamma.BackgroundImage = global::MyFacebookUI.Properties.Resources.mark_zuckerberg_gamma;
            this.pictureBoxGamma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGamma.Location = new System.Drawing.Point(269, 263);
            this.pictureBoxGamma.Name = "pictureBoxGamma";
            this.pictureBoxGamma.Size = new System.Drawing.Size(194, 150);
            this.pictureBoxGamma.TabIndex = 2;
            this.pictureBoxGamma.TabStop = false;
            this.pictureBoxGamma.Click += new System.EventHandler(this.pictureBoxGamma_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(11, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 110);
            this.label4.TabIndex = 1;
            this.label4.Text = "\r\nIn this game you have to guess your friend\r\nthat in the blurry picture\r\nEnter o" +
    "n the picture that represent the \r\nthe kind of blur you want to play with:\r\n";
            // 
            // pictureBoxBlur
            // 
            this.pictureBoxBlur.BackgroundImage = global::MyFacebookUI.Properties.Resources.mark_zuckerberg_blur;
            this.pictureBoxBlur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBlur.Location = new System.Drawing.Point(24, 263);
            this.pictureBoxBlur.Name = "pictureBoxBlur";
            this.pictureBoxBlur.Size = new System.Drawing.Size(182, 150);
            this.pictureBoxBlur.TabIndex = 0;
            this.pictureBoxBlur.TabStop = false;
            this.pictureBoxBlur.Click += new System.EventHandler(this.pictureBoxBlur_Click);
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::MyFacebookUI.Properties.Resources.facebook_toolbar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacebookForm";
            this.Text = "MyFacebook App";
            this.Load += new System.EventHandler(this.facebookForm_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageGuessWhoGame.ResumeLayout(false);
            this.tabPageGuessWhoGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featureHeadline)).EndInit();
            this.liveBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfileBox)).EndInit();
            this.tabPageChooseBlur.ResumeLayout(false);
            this.tabPageChooseBlur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurHeadLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTranparent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlur)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageGuessWhoGame;
        private System.Windows.Forms.PictureBox imageProfileBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.TextBox submitBox;
        private System.Windows.Forms.GroupBox liveBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.PictureBox featureHeadline;
        private System.Windows.Forms.Button postbtn;
        private System.Windows.Forms.RichTextBox postEventTextBox;
        private System.Windows.Forms.ListBox birthDayFriendsListBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EventsOnDateLabel;
        private System.Windows.Forms.ListBox EventsOnDateListBox;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.TabPage tabPageChooseBlur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxBlur;
        private System.Windows.Forms.Label labelBlur;
        private System.Windows.Forms.PictureBox blurHeadLine;
        private System.Windows.Forms.PictureBox pictureBoxTranparent;
        private System.Windows.Forms.PictureBox pictureBoxGamma;
        private System.Windows.Forms.Label labelTrans;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label labelOrigin;
    }

    #endregion
}