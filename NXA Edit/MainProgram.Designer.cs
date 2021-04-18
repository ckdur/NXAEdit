namespace NXA_Edit
{
    partial class MainProgram
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
      this.loadNX2Button = new System.Windows.Forms.Button();
      this.debugMessages = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.drvLetter = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.usbModel = new System.Windows.Forms.Label();
      this.usbSerial = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.driveList = new System.Windows.Forms.ListBox();
      this.updateDrives = new System.Windows.Forms.Timer(this.components);
      this.profiledata = new System.Windows.Forms.GroupBox();
      this.dontchangeserial = new System.Windows.Forms.CheckBox();
      this.usbSerialLabel = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.avatarNumberSelect = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.avatarPictureBox = new System.Windows.Forms.PictureBox();
      this.usbNameEdit = new System.Windows.Forms.TextBox();
      this.usbNameLabel = new System.Windows.Forms.Label();
      this.saveButton = new System.Windows.Forms.Button();
      this.loadNXAButton = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.labelMissions = new System.Windows.Forms.Label();
      this.label22 = new System.Windows.Forms.Label();
      this.labelInt2 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.labelInt1 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.labelVO2 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.labelKCal = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.labelPlay = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.labelMileage = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.labelCurrentBreak = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.itemGrey = new System.Windows.Forms.Button();
      this.itemRed = new System.Windows.Forms.Button();
      this.itemYellow = new System.Windows.Forms.Button();
      this.itemGreen = new System.Windows.Forms.Button();
      this.itemDrkGrn = new System.Windows.Forms.Button();
      this.itemAqua = new System.Windows.Forms.Button();
      this.itemPink = new System.Windows.Forms.Button();
      this.itemPurple = new System.Windows.Forms.Button();
      this.itemBlue = new System.Windows.Forms.Button();
      this.itemOrange = new System.Windows.Forms.Button();
      this.itemBlack = new System.Windows.Forms.Button();
      this.itemLGrey = new System.Windows.Forms.Button();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.labelCurrentFunc = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.itemLuck = new System.Windows.Forms.Button();
      this.itemPLuck = new System.Windows.Forms.Button();
      this.itemLine = new System.Windows.Forms.Button();
      this.itemPLine = new System.Windows.Forms.Button();
      this.itemPLife = new System.Windows.Forms.Button();
      this.itemPShield = new System.Windows.Forms.Button();
      this.itemLife = new System.Windows.Forms.Button();
      this.itemShield = new System.Windows.Forms.Button();
      this.itemPortalPass = new System.Windows.Forms.Button();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.labelCurrentBGA = new System.Windows.Forms.Label();
      this.itemPBGAOFF = new System.Windows.Forms.Button();
      this.itemBGAOFF = new System.Windows.Forms.Button();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.labelCurrentTime = new System.Windows.Forms.Label();
      this.itemTime30 = new System.Windows.Forms.Button();
      this.itemTime20 = new System.Windows.Forms.Button();
      this.itemTime10 = new System.Windows.Forms.Button();
      this.textVoucher = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.profiledata.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.avatarNumberSelect)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.SuspendLayout();
      // 
      // loadNX2Button
      // 
      this.loadNX2Button.Location = new System.Drawing.Point(16, 410);
      this.loadNX2Button.Margin = new System.Windows.Forms.Padding(4);
      this.loadNX2Button.Name = "loadNX2Button";
      this.loadNX2Button.Size = new System.Drawing.Size(139, 26);
      this.loadNX2Button.TabIndex = 0;
      this.loadNX2Button.Text = "Load NX2 Profile";
      this.loadNX2Button.UseVisualStyleBackColor = true;
      this.loadNX2Button.Click += new System.EventHandler(this.loadNX2Button_Click);
      // 
      // debugMessages
      // 
      this.debugMessages.Location = new System.Drawing.Point(16, 443);
      this.debugMessages.Margin = new System.Windows.Forms.Padding(4);
      this.debugMessages.Multiline = true;
      this.debugMessages.Name = "debugMessages";
      this.debugMessages.Size = new System.Drawing.Size(446, 128);
      this.debugMessages.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.drvLetter);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.usbModel);
      this.groupBox1.Controls.Add(this.usbSerial);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.driveList);
      this.groupBox1.Location = new System.Drawing.Point(16, 14);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(446, 189);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "USB Drive";
      // 
      // drvLetter
      // 
      this.drvLetter.AutoSize = true;
      this.drvLetter.Location = new System.Drawing.Point(381, 161);
      this.drvLetter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.drvLetter.Name = "drvLetter";
      this.drvLetter.Size = new System.Drawing.Size(46, 15);
      this.drvLetter.TabIndex = 7;
      this.drvLetter.Text = "NONE";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(298, 161);
      this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(87, 15);
      this.label9.TabIndex = 6;
      this.label9.Text = "Drive Letter:";
      // 
      // usbModel
      // 
      this.usbModel.AutoSize = true;
      this.usbModel.Location = new System.Drawing.Point(68, 135);
      this.usbModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.usbModel.Name = "usbModel";
      this.usbModel.Size = new System.Drawing.Size(46, 15);
      this.usbModel.TabIndex = 5;
      this.usbModel.Text = "NONE";
      // 
      // usbSerial
      // 
      this.usbSerial.AutoSize = true;
      this.usbSerial.Location = new System.Drawing.Point(68, 161);
      this.usbSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.usbSerial.Name = "usbSerial";
      this.usbSerial.Size = new System.Drawing.Size(46, 15);
      this.usbSerial.TabIndex = 4;
      this.usbSerial.Text = "NONE";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 161);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 15);
      this.label3.TabIndex = 3;
      this.label3.Text = "Serial:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 135);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Model:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 19);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(383, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Please put the USB Drive you wish to use with the profile.";
      // 
      // driveList
      // 
      this.driveList.FormattingEnabled = true;
      this.driveList.ItemHeight = 15;
      this.driveList.Location = new System.Drawing.Point(12, 37);
      this.driveList.Margin = new System.Windows.Forms.Padding(4);
      this.driveList.Name = "driveList";
      this.driveList.Size = new System.Drawing.Size(426, 94);
      this.driveList.TabIndex = 0;
      this.driveList.SelectedValueChanged += new System.EventHandler(this.driveList_SelectedValueChanged);
      // 
      // updateDrives
      // 
      this.updateDrives.Enabled = true;
      this.updateDrives.Interval = 1000;
      this.updateDrives.Tick += new System.EventHandler(this.updateDrives_Tick);
      // 
      // profiledata
      // 
      this.profiledata.Controls.Add(this.dontchangeserial);
      this.profiledata.Controls.Add(this.usbSerialLabel);
      this.profiledata.Controls.Add(this.label5);
      this.profiledata.Controls.Add(this.avatarNumberSelect);
      this.profiledata.Controls.Add(this.label4);
      this.profiledata.Controls.Add(this.avatarPictureBox);
      this.profiledata.Controls.Add(this.usbNameEdit);
      this.profiledata.Controls.Add(this.usbNameLabel);
      this.profiledata.Location = new System.Drawing.Point(16, 210);
      this.profiledata.Margin = new System.Windows.Forms.Padding(4);
      this.profiledata.Name = "profiledata";
      this.profiledata.Padding = new System.Windows.Forms.Padding(4);
      this.profiledata.Size = new System.Drawing.Size(446, 193);
      this.profiledata.TabIndex = 3;
      this.profiledata.TabStop = false;
      this.profiledata.Text = "Profile Data";
      this.profiledata.Visible = false;
      // 
      // dontchangeserial
      // 
      this.dontchangeserial.AutoSize = true;
      this.dontchangeserial.Checked = true;
      this.dontchangeserial.CheckState = System.Windows.Forms.CheckState.Checked;
      this.dontchangeserial.Location = new System.Drawing.Point(151, 117);
      this.dontchangeserial.Margin = new System.Windows.Forms.Padding(4);
      this.dontchangeserial.Name = "dontchangeserial";
      this.dontchangeserial.Size = new System.Drawing.Size(188, 19);
      this.dontchangeserial.TabIndex = 9;
      this.dontchangeserial.Text = "Do not change my serial.";
      this.dontchangeserial.UseVisualStyleBackColor = true;
      this.dontchangeserial.CheckedChanged += new System.EventHandler(this.dontchangeserial_CheckedChanged);
      // 
      // usbSerialLabel
      // 
      this.usbSerialLabel.AutoSize = true;
      this.usbSerialLabel.Location = new System.Drawing.Point(201, 49);
      this.usbSerialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.usbSerialLabel.Name = "usbSerialLabel";
      this.usbSerialLabel.Size = new System.Drawing.Size(54, 15);
      this.usbSerialLabel.TabIndex = 7;
      this.usbSerialLabel.Text = "SERIAL";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(51, 26);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(47, 15);
      this.label5.TabIndex = 6;
      this.label5.Text = "Avatar";
      // 
      // avatarNumberSelect
      // 
      this.avatarNumberSelect.Location = new System.Drawing.Point(16, 163);
      this.avatarNumberSelect.Margin = new System.Windows.Forms.Padding(4);
      this.avatarNumberSelect.Maximum = new decimal(new int[] {
            216,
            0,
            0,
            0});
      this.avatarNumberSelect.Name = "avatarNumberSelect";
      this.avatarNumberSelect.Size = new System.Drawing.Size(123, 22);
      this.avatarNumberSelect.TabIndex = 5;
      this.avatarNumberSelect.ValueChanged += new System.EventHandler(this.avatarNumberSelect_ValueChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(147, 49);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 15);
      this.label4.TabIndex = 3;
      this.label4.Text = "Serial:";
      // 
      // avatarPictureBox
      // 
      this.avatarPictureBox.BackgroundImage = global::NXA_Edit.Properties.Resources.CH_001;
      this.avatarPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.avatarPictureBox.ErrorImage = global::NXA_Edit.Properties.Resources.CH_001;
      this.avatarPictureBox.Image = global::NXA_Edit.Properties.Resources.CH_001;
      this.avatarPictureBox.InitialImage = global::NXA_Edit.Properties.Resources.CH_001;
      this.avatarPictureBox.Location = new System.Drawing.Point(16, 49);
      this.avatarPictureBox.Margin = new System.Windows.Forms.Padding(4);
      this.avatarPictureBox.Name = "avatarPictureBox";
      this.avatarPictureBox.Size = new System.Drawing.Size(123, 106);
      this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.avatarPictureBox.TabIndex = 2;
      this.avatarPictureBox.TabStop = false;
      // 
      // usbNameEdit
      // 
      this.usbNameEdit.Location = new System.Drawing.Point(205, 19);
      this.usbNameEdit.Margin = new System.Windows.Forms.Padding(4);
      this.usbNameEdit.MaxLength = 8;
      this.usbNameEdit.Name = "usbNameEdit";
      this.usbNameEdit.Size = new System.Drawing.Size(132, 22);
      this.usbNameEdit.TabIndex = 1;
      // 
      // usbNameLabel
      // 
      this.usbNameLabel.AutoSize = true;
      this.usbNameLabel.Location = new System.Drawing.Point(147, 22);
      this.usbNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.usbNameLabel.Name = "usbNameLabel";
      this.usbNameLabel.Size = new System.Drawing.Size(46, 15);
      this.usbNameLabel.TabIndex = 0;
      this.usbNameLabel.Text = "Name:";
      // 
      // saveButton
      // 
      this.saveButton.Enabled = false;
      this.saveButton.Location = new System.Drawing.Point(294, 410);
      this.saveButton.Margin = new System.Windows.Forms.Padding(4);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(168, 26);
      this.saveButton.TabIndex = 4;
      this.saveButton.Text = "Save NX2/NXA Profile";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // loadNXAButton
      // 
      this.loadNXAButton.Location = new System.Drawing.Point(161, 410);
      this.loadNXAButton.Margin = new System.Windows.Forms.Padding(4);
      this.loadNXAButton.Name = "loadNXAButton";
      this.loadNXAButton.Size = new System.Drawing.Size(126, 26);
      this.loadNXAButton.TabIndex = 5;
      this.loadNXAButton.Text = "Load NXA Profile";
      this.loadNXAButton.UseVisualStyleBackColor = true;
      this.loadNXAButton.Click += new System.EventHandler(this.loadNXAButton_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.labelMissions);
      this.groupBox2.Controls.Add(this.label22);
      this.groupBox2.Controls.Add(this.labelInt2);
      this.groupBox2.Controls.Add(this.label20);
      this.groupBox2.Controls.Add(this.labelInt1);
      this.groupBox2.Controls.Add(this.label18);
      this.groupBox2.Controls.Add(this.labelVO2);
      this.groupBox2.Controls.Add(this.label16);
      this.groupBox2.Controls.Add(this.labelKCal);
      this.groupBox2.Controls.Add(this.label14);
      this.groupBox2.Controls.Add(this.labelPlay);
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Controls.Add(this.labelMileage);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Location = new System.Drawing.Point(475, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(230, 168);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Info";
      // 
      // labelMissions
      // 
      this.labelMissions.AutoSize = true;
      this.labelMissions.Location = new System.Drawing.Point(76, 137);
      this.labelMissions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelMissions.Name = "labelMissions";
      this.labelMissions.Size = new System.Drawing.Size(46, 15);
      this.labelMissions.TabIndex = 21;
      this.labelMissions.Text = "NONE";
      // 
      // label22
      // 
      this.label22.AutoSize = true;
      this.label22.Location = new System.Drawing.Point(16, 137);
      this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(64, 15);
      this.label22.TabIndex = 20;
      this.label22.Text = "Missions:";
      // 
      // labelInt2
      // 
      this.labelInt2.AutoSize = true;
      this.labelInt2.Location = new System.Drawing.Point(76, 118);
      this.labelInt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelInt2.Name = "labelInt2";
      this.labelInt2.Size = new System.Drawing.Size(46, 15);
      this.labelInt2.TabIndex = 19;
      this.labelInt2.Text = "NONE";
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Location = new System.Drawing.Point(16, 118);
      this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(35, 15);
      this.label20.TabIndex = 18;
      this.label20.Text = "Int2:";
      // 
      // labelInt1
      // 
      this.labelInt1.AutoSize = true;
      this.labelInt1.Location = new System.Drawing.Point(76, 99);
      this.labelInt1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelInt1.Name = "labelInt1";
      this.labelInt1.Size = new System.Drawing.Size(46, 15);
      this.labelInt1.TabIndex = 17;
      this.labelInt1.Text = "NONE";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(16, 99);
      this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(35, 15);
      this.label18.TabIndex = 16;
      this.label18.Text = "Int1:";
      // 
      // labelVO2
      // 
      this.labelVO2.AutoSize = true;
      this.labelVO2.Location = new System.Drawing.Point(76, 79);
      this.labelVO2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelVO2.Name = "labelVO2";
      this.labelVO2.Size = new System.Drawing.Size(46, 15);
      this.labelVO2.TabIndex = 15;
      this.labelVO2.Text = "NONE";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(16, 79);
      this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(35, 15);
      this.label16.TabIndex = 14;
      this.label16.Text = "V02:";
      // 
      // labelKCal
      // 
      this.labelKCal.AutoSize = true;
      this.labelKCal.Location = new System.Drawing.Point(76, 59);
      this.labelKCal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelKCal.Name = "labelKCal";
      this.labelKCal.Size = new System.Drawing.Size(46, 15);
      this.labelKCal.TabIndex = 13;
      this.labelKCal.Text = "NONE";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(16, 59);
      this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(39, 15);
      this.label14.TabIndex = 12;
      this.label14.Text = "KCal:";
      // 
      // labelPlay
      // 
      this.labelPlay.AutoSize = true;
      this.labelPlay.Location = new System.Drawing.Point(76, 40);
      this.labelPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelPlay.Name = "labelPlay";
      this.labelPlay.Size = new System.Drawing.Size(46, 15);
      this.labelPlay.TabIndex = 11;
      this.labelPlay.Text = "NONE";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(16, 40);
      this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(36, 15);
      this.label12.TabIndex = 10;
      this.label12.Text = "Play:";
      // 
      // labelMileage
      // 
      this.labelMileage.AutoSize = true;
      this.labelMileage.Location = new System.Drawing.Point(76, 21);
      this.labelMileage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelMileage.Name = "labelMileage";
      this.labelMileage.Size = new System.Drawing.Size(46, 15);
      this.labelMileage.TabIndex = 9;
      this.labelMileage.Text = "NONE";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(16, 21);
      this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(57, 15);
      this.label10.TabIndex = 8;
      this.label10.Text = "Mileage:";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.itemOrange);
      this.groupBox3.Controls.Add(this.itemPink);
      this.groupBox3.Controls.Add(this.itemPurple);
      this.groupBox3.Controls.Add(this.itemBlack);
      this.groupBox3.Controls.Add(this.itemBlue);
      this.groupBox3.Controls.Add(this.itemAqua);
      this.groupBox3.Controls.Add(this.itemLGrey);
      this.groupBox3.Controls.Add(this.itemDrkGrn);
      this.groupBox3.Controls.Add(this.itemGreen);
      this.groupBox3.Controls.Add(this.itemYellow);
      this.groupBox3.Controls.Add(this.itemRed);
      this.groupBox3.Controls.Add(this.itemGrey);
      this.groupBox3.Controls.Add(this.labelCurrentBreak);
      this.groupBox3.Controls.Add(this.label11);
      this.groupBox3.Location = new System.Drawing.Point(476, 183);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(228, 153);
      this.groupBox3.TabIndex = 7;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Break Item Slot";
      // 
      // labelCurrentBreak
      // 
      this.labelCurrentBreak.AutoSize = true;
      this.labelCurrentBreak.Location = new System.Drawing.Point(75, 18);
      this.labelCurrentBreak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelCurrentBreak.Name = "labelCurrentBreak";
      this.labelCurrentBreak.Size = new System.Drawing.Size(46, 15);
      this.labelCurrentBreak.TabIndex = 23;
      this.labelCurrentBreak.Text = "NONE";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(15, 18);
      this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(59, 15);
      this.label11.TabIndex = 22;
      this.label11.Text = "Current:";
      // 
      // itemGrey
      // 
      this.itemGrey.Location = new System.Drawing.Point(7, 39);
      this.itemGrey.Margin = new System.Windows.Forms.Padding(4);
      this.itemGrey.Name = "itemGrey";
      this.itemGrey.Size = new System.Drawing.Size(65, 26);
      this.itemGrey.TabIndex = 8;
      this.itemGrey.Text = "Grey";
      this.itemGrey.UseVisualStyleBackColor = true;
      this.itemGrey.Click += new System.EventHandler(this.itemGrey_Click);
      // 
      // itemRed
      // 
      this.itemRed.Location = new System.Drawing.Point(79, 39);
      this.itemRed.Margin = new System.Windows.Forms.Padding(4);
      this.itemRed.Name = "itemRed";
      this.itemRed.Size = new System.Drawing.Size(65, 26);
      this.itemRed.TabIndex = 24;
      this.itemRed.Text = "Red";
      this.itemRed.UseVisualStyleBackColor = true;
      this.itemRed.Click += new System.EventHandler(this.itemRed_Click);
      // 
      // itemYellow
      // 
      this.itemYellow.Location = new System.Drawing.Point(151, 39);
      this.itemYellow.Margin = new System.Windows.Forms.Padding(4);
      this.itemYellow.Name = "itemYellow";
      this.itemYellow.Size = new System.Drawing.Size(65, 26);
      this.itemYellow.TabIndex = 25;
      this.itemYellow.Text = "Yellow";
      this.itemYellow.UseVisualStyleBackColor = true;
      this.itemYellow.Click += new System.EventHandler(this.itemYellow_Click);
      // 
      // itemGreen
      // 
      this.itemGreen.Location = new System.Drawing.Point(7, 65);
      this.itemGreen.Margin = new System.Windows.Forms.Padding(4);
      this.itemGreen.Name = "itemGreen";
      this.itemGreen.Size = new System.Drawing.Size(65, 26);
      this.itemGreen.TabIndex = 26;
      this.itemGreen.Text = "Green";
      this.itemGreen.UseVisualStyleBackColor = true;
      this.itemGreen.Click += new System.EventHandler(this.itemGreen_Click);
      // 
      // itemDrkGrn
      // 
      this.itemDrkGrn.Location = new System.Drawing.Point(79, 65);
      this.itemDrkGrn.Margin = new System.Windows.Forms.Padding(4);
      this.itemDrkGrn.Name = "itemDrkGrn";
      this.itemDrkGrn.Size = new System.Drawing.Size(65, 26);
      this.itemDrkGrn.TabIndex = 27;
      this.itemDrkGrn.Text = "DrkGrn";
      this.itemDrkGrn.UseVisualStyleBackColor = true;
      this.itemDrkGrn.Click += new System.EventHandler(this.itemDrkGrn_Click);
      // 
      // itemAqua
      // 
      this.itemAqua.Location = new System.Drawing.Point(151, 65);
      this.itemAqua.Margin = new System.Windows.Forms.Padding(4);
      this.itemAqua.Name = "itemAqua";
      this.itemAqua.Size = new System.Drawing.Size(65, 26);
      this.itemAqua.TabIndex = 28;
      this.itemAqua.Text = "Aqua";
      this.itemAqua.UseVisualStyleBackColor = true;
      this.itemAqua.Click += new System.EventHandler(this.itemAqua_Click);
      // 
      // itemPink
      // 
      this.itemPink.Location = new System.Drawing.Point(151, 91);
      this.itemPink.Margin = new System.Windows.Forms.Padding(4);
      this.itemPink.Name = "itemPink";
      this.itemPink.Size = new System.Drawing.Size(65, 26);
      this.itemPink.TabIndex = 31;
      this.itemPink.Text = "Pink";
      this.itemPink.UseVisualStyleBackColor = true;
      this.itemPink.Click += new System.EventHandler(this.itemPink_Click);
      // 
      // itemPurple
      // 
      this.itemPurple.Location = new System.Drawing.Point(79, 91);
      this.itemPurple.Margin = new System.Windows.Forms.Padding(4);
      this.itemPurple.Name = "itemPurple";
      this.itemPurple.Size = new System.Drawing.Size(65, 26);
      this.itemPurple.TabIndex = 30;
      this.itemPurple.Text = "Purple";
      this.itemPurple.UseVisualStyleBackColor = true;
      this.itemPurple.Click += new System.EventHandler(this.itemPurple_Click);
      // 
      // itemBlue
      // 
      this.itemBlue.Location = new System.Drawing.Point(7, 91);
      this.itemBlue.Margin = new System.Windows.Forms.Padding(4);
      this.itemBlue.Name = "itemBlue";
      this.itemBlue.Size = new System.Drawing.Size(65, 26);
      this.itemBlue.TabIndex = 29;
      this.itemBlue.Text = "Blue";
      this.itemBlue.UseVisualStyleBackColor = true;
      this.itemBlue.Click += new System.EventHandler(this.itemBlue_Click);
      // 
      // itemOrange
      // 
      this.itemOrange.Location = new System.Drawing.Point(151, 117);
      this.itemOrange.Margin = new System.Windows.Forms.Padding(4);
      this.itemOrange.Name = "itemOrange";
      this.itemOrange.Size = new System.Drawing.Size(65, 26);
      this.itemOrange.TabIndex = 34;
      this.itemOrange.Text = "Orange";
      this.itemOrange.UseVisualStyleBackColor = true;
      this.itemOrange.Click += new System.EventHandler(this.itemOrange_Click);
      // 
      // itemBlack
      // 
      this.itemBlack.Location = new System.Drawing.Point(79, 117);
      this.itemBlack.Margin = new System.Windows.Forms.Padding(4);
      this.itemBlack.Name = "itemBlack";
      this.itemBlack.Size = new System.Drawing.Size(65, 26);
      this.itemBlack.TabIndex = 33;
      this.itemBlack.Text = "Black";
      this.itemBlack.UseVisualStyleBackColor = true;
      this.itemBlack.Click += new System.EventHandler(this.itemBlack_Click);
      // 
      // itemLGrey
      // 
      this.itemLGrey.Location = new System.Drawing.Point(7, 117);
      this.itemLGrey.Margin = new System.Windows.Forms.Padding(4);
      this.itemLGrey.Name = "itemLGrey";
      this.itemLGrey.Size = new System.Drawing.Size(65, 26);
      this.itemLGrey.TabIndex = 32;
      this.itemLGrey.Text = "L.Grey";
      this.itemLGrey.UseVisualStyleBackColor = true;
      this.itemLGrey.Click += new System.EventHandler(this.itemLGrey_Click);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.itemPortalPass);
      this.groupBox4.Controls.Add(this.itemLuck);
      this.groupBox4.Controls.Add(this.itemPLuck);
      this.groupBox4.Controls.Add(this.itemLine);
      this.groupBox4.Controls.Add(this.itemPLine);
      this.groupBox4.Controls.Add(this.itemPLife);
      this.groupBox4.Controls.Add(this.itemPShield);
      this.groupBox4.Controls.Add(this.itemLife);
      this.groupBox4.Controls.Add(this.itemShield);
      this.groupBox4.Controls.Add(this.labelCurrentFunc);
      this.groupBox4.Controls.Add(this.label7);
      this.groupBox4.Location = new System.Drawing.Point(476, 341);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(151, 181);
      this.groupBox4.TabIndex = 8;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Func Slot";
      // 
      // labelCurrentFunc
      // 
      this.labelCurrentFunc.AutoSize = true;
      this.labelCurrentFunc.Location = new System.Drawing.Point(63, 23);
      this.labelCurrentFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelCurrentFunc.Name = "labelCurrentFunc";
      this.labelCurrentFunc.Size = new System.Drawing.Size(46, 15);
      this.labelCurrentFunc.TabIndex = 36;
      this.labelCurrentFunc.Text = "NONE";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(5, 23);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(59, 15);
      this.label7.TabIndex = 35;
      this.label7.Text = "Current:";
      // 
      // itemLuck
      // 
      this.itemLuck.Location = new System.Drawing.Point(79, 94);
      this.itemLuck.Margin = new System.Windows.Forms.Padding(4);
      this.itemLuck.Name = "itemLuck";
      this.itemLuck.Size = new System.Drawing.Size(65, 26);
      this.itemLuck.TabIndex = 42;
      this.itemLuck.Text = "Luck";
      this.itemLuck.UseVisualStyleBackColor = true;
      this.itemLuck.Click += new System.EventHandler(this.itemLuck_Click);
      // 
      // itemPLuck
      // 
      this.itemPLuck.Location = new System.Drawing.Point(79, 120);
      this.itemPLuck.Margin = new System.Windows.Forms.Padding(4);
      this.itemPLuck.Name = "itemPLuck";
      this.itemPLuck.Size = new System.Drawing.Size(65, 26);
      this.itemPLuck.TabIndex = 44;
      this.itemPLuck.Text = "P.Luck";
      this.itemPLuck.UseVisualStyleBackColor = true;
      this.itemPLuck.Click += new System.EventHandler(this.itemPLuck_Click);
      // 
      // itemLine
      // 
      this.itemLine.Location = new System.Drawing.Point(7, 94);
      this.itemLine.Margin = new System.Windows.Forms.Padding(4);
      this.itemLine.Name = "itemLine";
      this.itemLine.Size = new System.Drawing.Size(65, 26);
      this.itemLine.TabIndex = 41;
      this.itemLine.Text = "Line";
      this.itemLine.UseVisualStyleBackColor = true;
      this.itemLine.Click += new System.EventHandler(this.itemLine_Click);
      // 
      // itemPLine
      // 
      this.itemPLine.Location = new System.Drawing.Point(7, 120);
      this.itemPLine.Margin = new System.Windows.Forms.Padding(4);
      this.itemPLine.Name = "itemPLine";
      this.itemPLine.Size = new System.Drawing.Size(65, 26);
      this.itemPLine.TabIndex = 43;
      this.itemPLine.Text = "P.Line";
      this.itemPLine.UseVisualStyleBackColor = true;
      this.itemPLine.Click += new System.EventHandler(this.itemPLine_Click);
      // 
      // itemPLife
      // 
      this.itemPLife.Location = new System.Drawing.Point(79, 68);
      this.itemPLife.Margin = new System.Windows.Forms.Padding(4);
      this.itemPLife.Name = "itemPLife";
      this.itemPLife.Size = new System.Drawing.Size(65, 26);
      this.itemPLife.TabIndex = 40;
      this.itemPLife.Text = "P.Life";
      this.itemPLife.UseVisualStyleBackColor = true;
      this.itemPLife.Click += new System.EventHandler(this.itemPLife_Click);
      // 
      // itemPShield
      // 
      this.itemPShield.Location = new System.Drawing.Point(7, 68);
      this.itemPShield.Margin = new System.Windows.Forms.Padding(4);
      this.itemPShield.Name = "itemPShield";
      this.itemPShield.Size = new System.Drawing.Size(65, 26);
      this.itemPShield.TabIndex = 39;
      this.itemPShield.Text = "P.Shield";
      this.itemPShield.UseVisualStyleBackColor = true;
      this.itemPShield.Click += new System.EventHandler(this.itemPShield_Click);
      // 
      // itemLife
      // 
      this.itemLife.Location = new System.Drawing.Point(79, 42);
      this.itemLife.Margin = new System.Windows.Forms.Padding(4);
      this.itemLife.Name = "itemLife";
      this.itemLife.Size = new System.Drawing.Size(65, 26);
      this.itemLife.TabIndex = 38;
      this.itemLife.Text = "Life";
      this.itemLife.UseVisualStyleBackColor = true;
      this.itemLife.Click += new System.EventHandler(this.itemLife_Click);
      // 
      // itemShield
      // 
      this.itemShield.Location = new System.Drawing.Point(7, 42);
      this.itemShield.Margin = new System.Windows.Forms.Padding(4);
      this.itemShield.Name = "itemShield";
      this.itemShield.Size = new System.Drawing.Size(65, 26);
      this.itemShield.TabIndex = 37;
      this.itemShield.Text = "Shield";
      this.itemShield.UseVisualStyleBackColor = true;
      this.itemShield.Click += new System.EventHandler(this.itemShield_Click);
      // 
      // itemPortalPass
      // 
      this.itemPortalPass.Location = new System.Drawing.Point(8, 148);
      this.itemPortalPass.Margin = new System.Windows.Forms.Padding(4);
      this.itemPortalPass.Name = "itemPortalPass";
      this.itemPortalPass.Size = new System.Drawing.Size(136, 26);
      this.itemPortalPass.TabIndex = 45;
      this.itemPortalPass.Text = "Portal Pass";
      this.itemPortalPass.UseVisualStyleBackColor = true;
      this.itemPortalPass.Click += new System.EventHandler(this.itemPortalPass_Click);
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.itemPBGAOFF);
      this.groupBox5.Controls.Add(this.labelCurrentBGA);
      this.groupBox5.Controls.Add(this.itemBGAOFF);
      this.groupBox5.Location = new System.Drawing.Point(633, 341);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(71, 95);
      this.groupBox5.TabIndex = 9;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "BGA";
      // 
      // labelCurrentBGA
      // 
      this.labelCurrentBGA.AutoSize = true;
      this.labelCurrentBGA.Location = new System.Drawing.Point(7, 18);
      this.labelCurrentBGA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelCurrentBGA.Name = "labelCurrentBGA";
      this.labelCurrentBGA.Size = new System.Drawing.Size(46, 15);
      this.labelCurrentBGA.TabIndex = 46;
      this.labelCurrentBGA.Text = "NONE";
      // 
      // itemPBGAOFF
      // 
      this.itemPBGAOFF.Location = new System.Drawing.Point(3, 61);
      this.itemPBGAOFF.Margin = new System.Windows.Forms.Padding(4);
      this.itemPBGAOFF.Name = "itemPBGAOFF";
      this.itemPBGAOFF.Size = new System.Drawing.Size(65, 26);
      this.itemPBGAOFF.TabIndex = 47;
      this.itemPBGAOFF.Text = "P.OFF";
      this.itemPBGAOFF.UseVisualStyleBackColor = true;
      this.itemPBGAOFF.Click += new System.EventHandler(this.itemPBGAOFF_Click);
      // 
      // itemBGAOFF
      // 
      this.itemBGAOFF.Location = new System.Drawing.Point(3, 35);
      this.itemBGAOFF.Margin = new System.Windows.Forms.Padding(4);
      this.itemBGAOFF.Name = "itemBGAOFF";
      this.itemBGAOFF.Size = new System.Drawing.Size(65, 26);
      this.itemBGAOFF.TabIndex = 46;
      this.itemBGAOFF.Text = "OFF";
      this.itemBGAOFF.UseVisualStyleBackColor = true;
      this.itemBGAOFF.Click += new System.EventHandler(this.itemBGAOFF_Click);
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.itemTime30);
      this.groupBox6.Controls.Add(this.labelCurrentTime);
      this.groupBox6.Controls.Add(this.itemTime10);
      this.groupBox6.Controls.Add(this.itemTime20);
      this.groupBox6.Location = new System.Drawing.Point(634, 443);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(69, 128);
      this.groupBox6.TabIndex = 10;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Time";
      // 
      // labelCurrentTime
      // 
      this.labelCurrentTime.AutoSize = true;
      this.labelCurrentTime.Location = new System.Drawing.Point(7, 18);
      this.labelCurrentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelCurrentTime.Name = "labelCurrentTime";
      this.labelCurrentTime.Size = new System.Drawing.Size(46, 15);
      this.labelCurrentTime.TabIndex = 48;
      this.labelCurrentTime.Text = "NONE";
      // 
      // itemTime30
      // 
      this.itemTime30.Location = new System.Drawing.Point(2, 89);
      this.itemTime30.Margin = new System.Windows.Forms.Padding(4);
      this.itemTime30.Name = "itemTime30";
      this.itemTime30.Size = new System.Drawing.Size(65, 26);
      this.itemTime30.TabIndex = 48;
      this.itemTime30.Text = "+30";
      this.itemTime30.UseVisualStyleBackColor = true;
      this.itemTime30.Click += new System.EventHandler(this.itemTime30_Click);
      // 
      // itemTime20
      // 
      this.itemTime20.Location = new System.Drawing.Point(2, 63);
      this.itemTime20.Margin = new System.Windows.Forms.Padding(4);
      this.itemTime20.Name = "itemTime20";
      this.itemTime20.Size = new System.Drawing.Size(65, 26);
      this.itemTime20.TabIndex = 47;
      this.itemTime20.Text = "+20";
      this.itemTime20.UseVisualStyleBackColor = true;
      this.itemTime20.Click += new System.EventHandler(this.itemTime20_Click);
      // 
      // itemTime10
      // 
      this.itemTime10.Location = new System.Drawing.Point(2, 37);
      this.itemTime10.Margin = new System.Windows.Forms.Padding(4);
      this.itemTime10.Name = "itemTime10";
      this.itemTime10.Size = new System.Drawing.Size(65, 26);
      this.itemTime10.TabIndex = 46;
      this.itemTime10.Text = "+10";
      this.itemTime10.UseVisualStyleBackColor = true;
      this.itemTime10.Click += new System.EventHandler(this.itemTime10_Click);
      // 
      // textVoucher
      // 
      this.textVoucher.Location = new System.Drawing.Point(483, 549);
      this.textVoucher.Margin = new System.Windows.Forms.Padding(4);
      this.textVoucher.MaxLength = 8;
      this.textVoucher.Name = "textVoucher";
      this.textVoucher.Size = new System.Drawing.Size(132, 22);
      this.textVoucher.TabIndex = 10;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(489, 530);
      this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(64, 15);
      this.label17.TabIndex = 46;
      this.label17.Text = "Voucher:";
      // 
      // MainProgram
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(722, 584);
      this.Controls.Add(this.label17);
      this.Controls.Add(this.textVoucher);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.loadNXAButton);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.profiledata);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.debugMessages);
      this.Controls.Add(this.loadNX2Button);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "MainProgram";
      this.Text = "NX2/NXA Editor & NXA Item Shop";
      this.Load += new System.EventHandler(this.MainProgram_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.profiledata.ResumeLayout(false);
      this.profiledata.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.avatarNumberSelect)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadNX2Button;
        private System.Windows.Forms.TextBox debugMessages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox driveList;
        private System.Windows.Forms.Timer updateDrives;
        private System.Windows.Forms.Label usbModel;
        private System.Windows.Forms.Label usbSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox profiledata;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox usbNameEdit;
        private System.Windows.Forms.Label usbNameLabel;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown avatarNumberSelect;
        private System.Windows.Forms.CheckBox dontchangeserial;
        private System.Windows.Forms.Label usbSerialLabel;
        private System.Windows.Forms.Button loadNXAButton;
    private System.Windows.Forms.Label drvLetter;
    private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label labelMissions;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Label labelInt2;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label labelInt1;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label labelVO2;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label labelKCal;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label labelPlay;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label labelMileage;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button itemOrange;
    private System.Windows.Forms.Button itemPink;
    private System.Windows.Forms.Button itemPurple;
    private System.Windows.Forms.Button itemBlack;
    private System.Windows.Forms.Button itemBlue;
    private System.Windows.Forms.Button itemAqua;
    private System.Windows.Forms.Button itemLGrey;
    private System.Windows.Forms.Button itemDrkGrn;
    private System.Windows.Forms.Button itemGreen;
    private System.Windows.Forms.Button itemYellow;
    private System.Windows.Forms.Button itemRed;
    private System.Windows.Forms.Button itemGrey;
    private System.Windows.Forms.Label labelCurrentBreak;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button itemPortalPass;
    private System.Windows.Forms.Button itemLuck;
    private System.Windows.Forms.Button itemPLuck;
    private System.Windows.Forms.Button itemLine;
    private System.Windows.Forms.Button itemPLine;
    private System.Windows.Forms.Button itemPLife;
    private System.Windows.Forms.Button itemPShield;
    private System.Windows.Forms.Button itemLife;
    private System.Windows.Forms.Button itemShield;
    private System.Windows.Forms.Label labelCurrentFunc;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Button itemPBGAOFF;
    private System.Windows.Forms.Label labelCurrentBGA;
    private System.Windows.Forms.Button itemBGAOFF;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.Button itemTime30;
    private System.Windows.Forms.Label labelCurrentTime;
    private System.Windows.Forms.Button itemTime10;
    private System.Windows.Forms.Button itemTime20;
    private System.Windows.Forms.TextBox textVoucher;
    private System.Windows.Forms.Label label17;
  }
}

