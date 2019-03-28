using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DatotekeUDirektoriju01
{
    class Datoteke
    {
        private static string nova = "";
        //izradimo ukupni put za datoteku
        public static string NovaPutanja(List<string> np)
        {
            for (int i = 0; i < np.Count; i++)
            {
                nova += np[i];
            }
            return nova;
        }
        //izlistamo sve datoteke u direktoriju
        public static List<string> DatotekeLista(string put)
        {
            DirectoryInfo datoteke = new DirectoryInfo(put); //dobijemo informacije o diskovima
            FileInfo[] sveDatoteke = datoteke.GetFiles(".",SearchOption.TopDirectoryOnly);
            List<string> imeDatoteke = new List<string>();
            foreach (FileInfo item in sveDatoteke)
            {
                imeDatoteke.Add(item.Name);
            }
            imeDatoteke.Add("Exit");
            return imeDatoteke;
        }
    }
}
