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
            //for (int i = 0; i < np.Count; i++)
            //{
            nova += np[np.Count - 1];
            np.RemoveAt(0);//obrisemo prijasni clan liste

            if (!nova.EndsWith(@"\"))
            {
                nova += @"\";
            }
            //}
            return nova;
        }
        //izlistamo sve datoteke u direktoriju
        public static List<string> DatotekeLista(string put)
        {
            DirectoryInfo datoteke = new DirectoryInfo(put); //dobijemo informacije o diskovima
            DirectoryInfo[] sveDatoteke = datoteke.GetDirectories();
            List<string> imeDatoteke = new List<string>();
            foreach (DirectoryInfo item in sveDatoteke)
            {
                imeDatoteke.Add(item.Name);
            }
            //dodamo Exit metodu za izlaz iz programa
            imeDatoteke.Add("Exit");
            return imeDatoteke;
        }
    }
}
