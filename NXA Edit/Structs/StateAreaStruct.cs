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
    public int Int0;
    public int mileage;                 //  Mileage
    public int playcount;
    public int kcal;
    public int vo2;
    public int Int1;
    public int Int2;
    public int missions;

    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 252)]
    public byte[] offset1;              //  Used for offset #1
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1000)]
    public byte[] wmUnlockTable;        //  Size 1008 (assumed). Elements have information of the switches also. Put them next
    public byte wmEvent0;
    public byte wmEvent1;
    public byte wmSwitch1; // (0x1 is on 0x00 is off)
    public byte wmSwitch2; // (0x1 is on 0x00 is off)
    public byte wmEvent2;
    public byte wmEvent3;
    public byte wmEvent4;
    public byte wmEvent5;
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4112)]
    public byte[] offset2;              //  Used for offset #2 (A table of just zeros)
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

    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4096)]
    public byte[] getSongIndex;         // Used by GetSongIndex - Assuming Maps Scores to Song IDs
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512)]
    public byte[] songlocks;            //  0x40 Unlock the song
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] wmEvents1;            // WorldMax Events (00 or 01)
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] wmEvents2;            // Song ID to show unlocking
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24)]
    public byte[] wmEventMultiple;      // WorldMax Events (00 or 01)
    public int itemBreak;               // Break Item Slot
    public int itemFunc;                // Func Item Slot
    public int itemBGA;                 // BGA Item Slot
    public int itemTime;                // Time Item Slot
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] wmBarricadeEvent;     // Barricade Unlock event (0x10 or 0x00)
    public int unkID;                   // Unknown ID (assigned to F1, 9C, DA, 4B)

    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2036)]
    public byte[] offset8;              //  Used for offset #8
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2560)]
    public WorldMaxScoreTableStruct[] highscoretable; // This is actually 40960 bytes. Struct is 16, count is 2560. Matches the spec.
    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3072)]
    public int[] songCount;             //  Number of times song played (possibly)
    public int zeroed1;
    public int unkCnt1;
    public int unkCnt2;
    public int unkCnt3;
    public int unkCnt4;
    public int unkCnt5;
    public int zeroed2;
    public int zeroed3;
    public int zeroed4;
    // TODO: End of assumptions
  }
}
