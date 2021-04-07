// ---------------------------------------------------------------------------
//    NX2 / NXA Save Game Editor
//    Copyright (C) 2015  Lucas Teske
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace NXA_Edit {
  public partial class MainProgram : Form {
    private List<USBDrive> usbdrives;
    private List<string> usbdrvLetters;
    private string selectedSerial, saveSerial, saveName, selectedLetter;
    private int saveAvatar;
    private byte[] saveBytes, rankBytes, uncSave, encSave;
    private bool NXALoaded = false;
    private string nxasave = "nxasave.bin";
    private string nxarank = "nxarank.bin";
    private string nx2save = "nx2save.bin";
    private string nx2rank = "nx2rank.bin";

    public MainProgram() {
      InitializeComponent();
      this.Text = string.Format("{0} - Version: {1} - Build Number: {2}", this.Text, BuildConfig.VERSION, BuildConfig.BUILD_VERSION);
    }

    private void loadNX2Button_Click(object sender, EventArgs e) {
      if (File.Exists(nx2save) && File.Exists(nx2rank)) {
        // Load Data from Files
        saveBytes = File.ReadAllBytes(nx2save);
        uncSave = saveBytes.SubArray(0, Constants.NX2PAD_SAVE);
        encSave = saveBytes.SubArray(Constants.NX2PAD_SAVE, saveBytes.Length - Constants.NX2PAD_SAVE);
        rankBytes = File.ReadAllBytes(nx2rank);

        // Decode Data
        Tools.Decode(encSave);
        Tools.Decode(rankBytes);
        
        // Save Decoded
        File.WriteAllBytes("nx2save.dec", Tools.Combine(uncSave, encSave, new byte[0]));

        // Fill UI
        saveName = Encoding.UTF8.GetString(saveBytes.SubArray(Constants.SAVE_NAME1, 8));
        saveSerial = Encoding.UTF8.GetString(encSave.SubArray(Constants.SAVE_SERIAL, 24));
        saveAvatar = encSave.SubArray(Constants.SAVE_AVATAR, 1)[0];
        avatarNumberSelect.Value = saveAvatar;
        avatarPictureBox.Image = (Bitmap) Properties.Resources.ResourceManager.GetObject("CH_" + (saveAvatar + 1).ToString("000"));
        usbNameEdit.Text = saveName;
        usbSerialLabel.Text = saveSerial;
        saveButton.Enabled = true;
        profiledata.Visible = true;
        NXALoaded = false;
        debugMessages.Text += "\r\nLoaded NX2 save!";
      } else {
        MessageBox.Show("No save files in folder! (Missing nx2rank.bin or nx2save.bin)");
      }
    }

    private void MainProgram_Load(object sender, EventArgs e) {
      usbdrives = new List<USBDrive>();
      usbdrvLetters = new List<string>();
      UpdateList();
    }

    private void UpdateList() {
      List<USBDrive> tmp = new List<USBDrive>();
      ManagementObjectSearcher theSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB'");

      foreach (ManagementObject currentObject in theSearcher.Get()) {
        USBDrive tmpu = new USBDrive(currentObject);
        tmp.Add(tmpu);
      }

      if (tmp.Count != usbdrives.Count) {
        debugMessages.Text += "\r\nDevice list changed! Refreshing.";
        usbdrives.Clear();
        driveList.Items.Clear();
        usbdrvLetters.Clear();
        int c = 0;
        foreach (USBDrive drive in tmp) {
          usbdrives.Add(drive);

          // Searches for the drive letter
          string driveLetter = "UNK";
          foreach (ManagementObject partition in new ManagementObjectSearcher(
            "ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" + drive.DeviceID
            + "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition").Get())
          {
            foreach (ManagementObject disk in new ManagementObjectSearcher(
                    "ASSOCIATORS OF {Win32_DiskPartition.DeviceID='"
                        + partition["DeviceID"]
                        + "'} WHERE AssocClass = Win32_LogicalDiskToPartition").Get())
            {
              //Console.WriteLine("Drive letter " + disk["Name"]);
              driveLetter = disk["Name"].ToString();
            }
          }
          usbdrvLetters.Add(driveLetter);
          driveList.Items.Add(drive.Model + " (" + drive.Size + " GB)");
          if (c == 0) {
            usbModel.Text = drive.Model;
            usbSerial.Text = drive.SerialNumber;
            selectedSerial = drive.SerialNumber;
            drvLetter.Text = driveLetter;
            selectedLetter = driveLetter;
            updatePaths();
          }
          c++;
        }
      }
    }

    private void driveList_SelectedValueChanged(object sender, EventArgs e) {
      int idx = driveList.SelectedIndex;
      USBDrive tmp = usbdrives[idx];
      usbModel.Text = tmp.Model;
      usbSerial.Text = tmp.SerialNumber;
      selectedSerial = tmp.SerialNumber;
      drvLetter.Text = usbdrvLetters[idx];
      selectedLetter = usbdrvLetters[idx];
      updatePaths();
    }

    private void updatePaths()
    {
      if(selectedLetter != "UNK")
      {
        nx2rank = string.Format("{0}\\nx2rank.bin", selectedLetter);
        nx2save = string.Format("{0}\\nx2save.bin", selectedLetter);
        nxarank = string.Format("{0}\\nxarank.bin", selectedLetter);
        nxasave = string.Format("{0}\\nxasave.bin", selectedLetter);
      }
      else
      {
        nx2rank = "nx2rank.bin";
        nx2save = "nx2save.bin";
        nxarank = "nxarank.bin";
        nxasave = "nxasave.bin";
      }
    }

    private void updateDrives_Tick(object sender, EventArgs e) {
      UpdateList();
    }

    private void avatarNumberSelect_ValueChanged(object sender, EventArgs e) {
      String n = (avatarNumberSelect.Value + 1).ToString("000");
      avatarPictureBox.Image = (Bitmap) Properties.Resources.ResourceManager.GetObject("CH_" + n);
      saveAvatar = (int) avatarNumberSelect.Value;
    }

    private void saveButton_Click(object sender, EventArgs e) {
      int serialSize = usbSerialLabel.Text.Length < 24 ? usbSerialLabel.Text.Length : 24;
      int nameSize = usbNameEdit.Text.Length < 8 ? usbNameEdit.Text.Length : 8;
      // Backup the files
      Tools.Encode(encSave);
      debugMessages.Text += "\r\nCreating backup of the save .bak.";
      if (NXALoaded) {
        File.WriteAllBytes("nxasave.bin.bak", Tools.Combine(uncSave, encSave, new byte[0]));
      } else {
        File.WriteAllBytes("nx2save.bin.bak", Tools.Combine(uncSave, encSave, new byte[0]));
      }
      Tools.Decode(encSave);

      //Change Serial:
      for (int i = 0; i < serialSize; i++) {
        encSave[i + Constants.SAVE_SERIAL] = (byte)usbSerialLabel.Text[i];
      }
      for (int i = serialSize; i < 24; i++) {
        encSave[i + Constants.SAVE_SERIAL] = 0x00; // Fill remaining bytes if needed
      }

      //Change Name1:
      for (int i = 0; i < nameSize; i++) {
        uncSave[i + Constants.SAVE_NAME1] = (byte)usbNameEdit.Text[i];
      }
      for (int i = nameSize; i < 8; i++) {
        uncSave[i + Constants.SAVE_NAME1] = 0x00; // Fill remaining bytes if needed
      }

      //Change Name2:
      for (int i = 0; i < nameSize; i++) {
        encSave[i + Constants.SAVE_NAME2] = (byte)usbNameEdit.Text[i];
      }
      for (int i = nameSize; i < 8; i++) {
        encSave[i + Constants.SAVE_NAME2] = 0x00; // Fill remaining bytes if needed
      }

      encSave[Constants.SAVE_AVATAR] = (byte)(saveAvatar & 0xFF);

      // Calculate CRC
      uint crc = Tools.adler32(encSave, 4, encSave.Length - 4, 1);
      Console.WriteLine("CRC: {0}", crc);
      encSave[3] = (byte)((crc & 0x000000FF) >> 0);
      encSave[2] = (byte)((crc & 0x0000FF00) >> 8);
      encSave[1] = (byte)((crc & 0x00FF0000) >> 16);
      encSave[0] = (byte)((crc & 0xFF000000) >> 24);

      Tools.Encode(encSave);

      if (NXALoaded) {
        File.WriteAllBytes(nxasave, Tools.Combine(uncSave, encSave, new byte[0]));
      } else {
        File.WriteAllBytes(nx2save, Tools.Combine(uncSave, encSave, new byte[0]));
      }

      Tools.Decode(encSave);
      MessageBox.Show("Saved!");
    }

    private void dontchangeserial_CheckedChanged(object sender, EventArgs e) {
      if (dontchangeserial.Checked) {
        usbSerialLabel.Text = saveSerial;
      } else {
        usbSerialLabel.Text = selectedSerial;
      }
    }

    private void loadNXAButton_Click(object sender, EventArgs e) {
      if (File.Exists(nxasave) && File.Exists(nxarank)) {
        // Read All Data
        saveBytes = File.ReadAllBytes(nxasave);
        uncSave = saveBytes.SubArray(0, Constants.NXA_STATAREA);
        encSave = saveBytes.SubArray(Constants.NXA_STATAREA, saveBytes.Length - Constants.NXA_STATAREA);
        rankBytes = File.ReadAllBytes(nxarank);
        
        // Decode Data
        Tools.Decode(encSave);
        Tools.Decode(rankBytes);

        // Save Decoded Data
        File.WriteAllBytes("nxasave.dec", Tools.Combine(uncSave, encSave, new byte[0]));
        
        // Fill UI
        saveName = Encoding.UTF8.GetString(saveBytes.SubArray(Constants.SAVE_NAME1, 8));
        saveSerial = Encoding.UTF8.GetString(encSave.SubArray(Constants.SAVE_SERIAL, 24));
        saveAvatar = encSave.SubArray(Constants.SAVE_AVATAR, 1)[0];
        avatarNumberSelect.Value = saveAvatar;
        avatarPictureBox.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("CH_" + (saveAvatar + 1).ToString("000"));
        usbNameEdit.Text = saveName;
        usbSerialLabel.Text = saveSerial;
        saveButton.Enabled = true;
        profiledata.Visible = true;
        NXALoaded = true;
        debugMessages.Text += "\r\nLoaded NXA save!";
        NXA x = new NXA(saveBytes);
        debugMessages.Text += "\r\nCRC Match: " + x.checkCRC();
        debugMessages.Text += "\r\nCurrentLand: " + (x.CurrentLand);
        debugMessages.Text += "\r\nDongleID: " + (x.StateArea.dongleid);
      } else {
        MessageBox.Show("No save files in folder! (Missing nxarank.bin or nxasave.bin)");
      }
    }
  }
}
