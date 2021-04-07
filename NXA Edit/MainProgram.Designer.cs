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
      this.usbModel = new System.Windows.Forms.Label();
      this.usbSerial = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.driveList = new System.Windows.Forms.ListBox();
      this.updateDrives = new System.Windows.Forms.Timer(this.components);
      this.profiledata = new System.Windows.Forms.GroupBox();
      this.label7 = new System.Windows.Forms.Label();
      this.dontchangeserial = new System.Windows.Forms.CheckBox();
      this.label6 = new System.Windows.Forms.Label();
      this.usbSerialLabel = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.avatarNumberSelect = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.avatarPictureBox = new System.Windows.Forms.PictureBox();
      this.usbNameEdit = new System.Windows.Forms.TextBox();
      this.usbNameLabel = new System.Windows.Forms.Label();
      this.saveButton = new System.Windows.Forms.Button();
      this.loadNXAButton = new System.Windows.Forms.Button();
      this.drvLetter = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.profiledata.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.avatarNumberSelect)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // loadNX2Button
      // 
      this.loadNX2Button.Location = new System.Drawing.Point(18, 546);
      this.loadNX2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.loadNX2Button.Name = "loadNX2Button";
      this.loadNX2Button.Size = new System.Drawing.Size(189, 35);
      this.loadNX2Button.TabIndex = 0;
      this.loadNX2Button.Text = "Load NX2 Profile";
      this.loadNX2Button.UseVisualStyleBackColor = true;
      this.loadNX2Button.Click += new System.EventHandler(this.loadNX2Button_Click);
      // 
      // debugMessages
      // 
      this.debugMessages.Location = new System.Drawing.Point(18, 591);
      this.debugMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.debugMessages.Multiline = true;
      this.debugMessages.Name = "debugMessages";
      this.debugMessages.Size = new System.Drawing.Size(670, 92);
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
      this.groupBox1.Location = new System.Drawing.Point(18, 18);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Size = new System.Drawing.Size(672, 252);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "USB Drive";
      // 
      // usbModel
      // 
      this.usbModel.AutoSize = true;
      this.usbModel.Location = new System.Drawing.Point(76, 180);
      this.usbModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.usbModel.Name = "usbModel";
      this.usbModel.Size = new System.Drawing.Size(54, 20);
      this.usbModel.TabIndex = 5;
      this.usbModel.Text = "NONE";
      // 
      // usbSerial
      // 
      this.usbSerial.AutoSize = true;
      this.usbSerial.Location = new System.Drawing.Point(76, 215);
      this.usbSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.usbSerial.Name = "usbSerial";
      this.usbSerial.Size = new System.Drawing.Size(54, 20);
      this.usbSerial.TabIndex = 4;
      this.usbSerial.Text = "NONE";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 215);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Serial:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 180);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Model:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 25);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(411, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Please put the USB Drive you wish to use with the profile.";
      // 
      // driveList
      // 
      this.driveList.FormattingEnabled = true;
      this.driveList.ItemHeight = 20;
      this.driveList.Location = new System.Drawing.Point(14, 49);
      this.driveList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.driveList.Name = "driveList";
      this.driveList.Size = new System.Drawing.Size(648, 124);
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
      this.profiledata.Controls.Add(this.label7);
      this.profiledata.Controls.Add(this.dontchangeserial);
      this.profiledata.Controls.Add(this.label6);
      this.profiledata.Controls.Add(this.usbSerialLabel);
      this.profiledata.Controls.Add(this.label5);
      this.profiledata.Controls.Add(this.avatarNumberSelect);
      this.profiledata.Controls.Add(this.label4);
      this.profiledata.Controls.Add(this.avatarPictureBox);
      this.profiledata.Controls.Add(this.usbNameEdit);
      this.profiledata.Controls.Add(this.usbNameLabel);
      this.profiledata.Location = new System.Drawing.Point(18, 280);
      this.profiledata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.profiledata.Name = "profiledata";
      this.profiledata.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.profiledata.Size = new System.Drawing.Size(672, 257);
      this.profiledata.TabIndex = 3;
      this.profiledata.TabStop = false;
      this.profiledata.Text = "Profile Data";
      this.profiledata.Visible = false;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(165, 126);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(499, 20);
      this.label7.TabIndex = 10;
      this.label7.Text = "Select the option below if you dont want to change the Serial Number.";
      // 
      // dontchangeserial
      // 
      this.dontchangeserial.AutoSize = true;
      this.dontchangeserial.Checked = true;
      this.dontchangeserial.CheckState = System.Windows.Forms.CheckState.Checked;
      this.dontchangeserial.Location = new System.Drawing.Point(170, 151);
      this.dontchangeserial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.dontchangeserial.Name = "dontchangeserial";
      this.dontchangeserial.Size = new System.Drawing.Size(209, 24);
      this.dontchangeserial.TabIndex = 9;
      this.dontchangeserial.Text = "Do not change my serial.";
      this.dontchangeserial.UseVisualStyleBackColor = true;
      this.dontchangeserial.CheckedChanged += new System.EventHandler(this.dontchangeserial_CheckedChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(165, 106);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(409, 20);
      this.label6.TabIndex = 8;
      this.label6.Text = "Select one of the usb devices on list to change the serial.";
      // 
      // usbSerialLabel
      // 
      this.usbSerialLabel.AutoSize = true;
      this.usbSerialLabel.Location = new System.Drawing.Point(226, 65);
      this.usbSerialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.usbSerialLabel.Name = "usbSerialLabel";
      this.usbSerialLabel.Size = new System.Drawing.Size(68, 20);
      this.usbSerialLabel.TabIndex = 7;
      this.usbSerialLabel.Text = "SERIAL";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(57, 35);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 20);
      this.label5.TabIndex = 6;
      this.label5.Text = "Avatar";
      // 
      // avatarNumberSelect
      // 
      this.avatarNumberSelect.Location = new System.Drawing.Point(18, 217);
      this.avatarNumberSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.avatarNumberSelect.Maximum = new decimal(new int[] {
            216,
            0,
            0,
            0});
      this.avatarNumberSelect.Name = "avatarNumberSelect";
      this.avatarNumberSelect.Size = new System.Drawing.Size(138, 26);
      this.avatarNumberSelect.TabIndex = 5;
      this.avatarNumberSelect.ValueChanged += new System.EventHandler(this.avatarNumberSelect_ValueChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(165, 65);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 20);
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
      this.avatarPictureBox.Location = new System.Drawing.Point(18, 65);
      this.avatarPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.avatarPictureBox.Name = "avatarPictureBox";
      this.avatarPictureBox.Size = new System.Drawing.Size(138, 142);
      this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.avatarPictureBox.TabIndex = 2;
      this.avatarPictureBox.TabStop = false;
      // 
      // usbNameEdit
      // 
      this.usbNameEdit.Location = new System.Drawing.Point(231, 25);
      this.usbNameEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.usbNameEdit.MaxLength = 8;
      this.usbNameEdit.Name = "usbNameEdit";
      this.usbNameEdit.Size = new System.Drawing.Size(148, 26);
      this.usbNameEdit.TabIndex = 1;
      // 
      // usbNameLabel
      // 
      this.usbNameLabel.AutoSize = true;
      this.usbNameLabel.Location = new System.Drawing.Point(165, 29);
      this.usbNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.usbNameLabel.Name = "usbNameLabel";
      this.usbNameLabel.Size = new System.Drawing.Size(55, 20);
      this.usbNameLabel.TabIndex = 0;
      this.usbNameLabel.Text = "Name:";
      // 
      // saveButton
      // 
      this.saveButton.Enabled = false;
      this.saveButton.Location = new System.Drawing.Point(501, 546);
      this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(189, 35);
      this.saveButton.TabIndex = 4;
      this.saveButton.Text = "Save NX2/NXA Profile";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // loadNXAButton
      // 
      this.loadNXAButton.Location = new System.Drawing.Point(255, 546);
      this.loadNXAButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.loadNXAButton.Name = "loadNXAButton";
      this.loadNXAButton.Size = new System.Drawing.Size(189, 35);
      this.loadNXAButton.TabIndex = 5;
      this.loadNXAButton.Text = "Load NXA Profile";
      this.loadNXAButton.UseVisualStyleBackColor = true;
      this.loadNXAButton.Click += new System.EventHandler(this.loadNXAButton_Click);
      // 
      // drvLetter
      // 
      this.drvLetter.AutoSize = true;
      this.drvLetter.Location = new System.Drawing.Point(573, 215);
      this.drvLetter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.drvLetter.Name = "drvLetter";
      this.drvLetter.Size = new System.Drawing.Size(54, 20);
      this.drvLetter.TabIndex = 7;
      this.drvLetter.Text = "NONE";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(479, 215);
      this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(95, 20);
      this.label9.TabIndex = 6;
      this.label9.Text = "Drive Letter:";
      // 
      // MainProgram
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(708, 703);
      this.Controls.Add(this.loadNXAButton);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.profiledata);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.debugMessages);
      this.Controls.Add(this.loadNX2Button);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "MainProgram";
      this.Text = "NX2/NXA Editor";
      this.Load += new System.EventHandler(this.MainProgram_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.profiledata.ResumeLayout(false);
      this.profiledata.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.avatarNumberSelect)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox dontchangeserial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label usbSerialLabel;
        private System.Windows.Forms.Button loadNXAButton;
    private System.Windows.Forms.Label drvLetter;
    private System.Windows.Forms.Label label9;
  }
}

