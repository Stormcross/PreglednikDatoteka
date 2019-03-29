using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DatotekeUDirektoriju01
{
    public static class Disks
    {
        // Klasa za dobivanje informacija disk
        public static List<string> pocetnaDisk()
        {
            DriveInfo[] sviDiskovi = DriveInfo.GetDrives(); //dobijemo informacije o diskovima
            List<string> imeDisk = new List<string>();
            foreach (DriveInfo item in sviDiskovi)
            {
                imeDisk.Add(item.Name);
            }
            imeDisk.Add("Exit");
            return imeDisk;
        }
    }
}
