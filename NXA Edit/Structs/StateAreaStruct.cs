// ---------------------------------------------------------------------------
//    NX2 / NXA Save Game Editor
//    Copyright (C) 2015  Lucas Teske
//    Copyright (C) 2021  Ckristian Duran
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
using System.Runtime.InteropServices;

namespace NXA_Edit.Structs {
  [StructLayout(LayoutKind.Sequential, Size = 90544), Serializable]
  public struct StateAreaStruct {
    public uint crc;
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] usbserial;
    public short year;
    public byte month;
    public byte day;
    public byte hour;
    public byte min;
    public short seconds;               // Value / 1000
    public int avatarid;
    public int rank;
    public int countryid;
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] playerid;             //  player name
    public int mileage;                 //  Mileage
    public int playcount;
    public int kcal;
    public int vo2;
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] worldmaxmappos;
    public float reward;                //  (value * 100) / 65 = Reward %
    public float worldmax;              //  (value * 100) / 634 = Worldmax %

    // TODO: From here, these are assumptions, as they do not match the contents.
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] offset1;              //  Used for offset #1
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1008)]
    public byte[] wmUnlockTable;        //  Size ~908 (assumed)
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 84)]
    public byte[] offset2;              //  Used for offset #2
    public byte wmEvent;
    public byte wmSwitch1; // (0x1 is on 0x00 is off)
    public byte wmSwitch2; // (0x1 is on 0x00 is off)
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4125)]
    public byte[] offset3;              //  Used for offset #3
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4096)]
    public byte[] wmChallengeTable;           //  Size 4096 bytes (but 4096 according to doc)
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] offset4;              //  Used for offset #4
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] wmBarricadeClear;           //  Size 12 bytes (0x1 for yes and 0x00 for no)
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] offset5;              //  Used for offset #5
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] wmEventeClear;              //  Size 128 bytes (0x1 for yes and 0x00 for no)
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] wmWarpTable;                //  Size 8 bytes (0x10 for unlock and 0x00 for lock)
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] offset6;              //  Used for offset #6
    // TODO: End of assumptions

    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] currentland;
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] currentmission;
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1280)]
    public WorldMaxScoreTableStruct[] worldmaxscoretable; // This is actually 20480 bytes. Struct is 16, count is 1280. Matches the spec.
    public int dongleid;
    public int unlocksignal;            // <=3 Tells game to unlock new song
    public int steps;
    public float playtime;              //  minutes
    public float totalcomplete;         //  %
    public float arcadecomplete;        //  %
    public float brainshowercomplete;   //  %
    public float specialcomplete;       //  %

    // TODO: From here, these are assumptions, as they do not match the contents.
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4096)]
    public byte[] getSongIndex;         // Used by GetSongIndex - Assuming Maps Scores to Song IDs
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 576)]
    public byte[] songlocks;            //  0x40 Unlock the song
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36)]
    public byte[] wmKeys;               // WorldMax Keys and various other events for completion
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] offset7;              //  Used for offset #7
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] wmID;                 // A Worldmax ID (Perhaps one to mark progress in Space)
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24)]
    public byte[] wmEvent2;             // More WorldMax Event Switches
    public int itemBreak;               // Break Item Slot
    public int itemFunc;                // Func Item Slot
    public int itemBGA;                 // BGA Item Slot
    public int itemTime;                // Time Item Slot

    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1975)]
    public byte[] offset8;              //  Used for offset #8
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2560)]
    public WorldMaxScoreTableStruct[] highscoretable; // This is actually 40960 bytes. Struct is 16, count is 2560. Matches the spec.
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12320)]
    public byte[] offset9;              //  Used for offset #9
    // TODO: End of assumptions
  }
}
