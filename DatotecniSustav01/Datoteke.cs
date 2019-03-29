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
            DirectoryInfo[] sveDatoteke = datoteke.GetDirectories(); //dobijemo info o datotekama
            List<string> imeDatoteke = new List<string>(); //lista za spremanje imena datoteka
            foreach (DirectoryInfo item in sveDatoteke)
            {
                imeDatoteke.Add(item.Name); //dodavanje imena u listu
            }
            //dodamo Exit metodu za izlaz iz programa
            imeDatoteke.Add("Exit");
            return imeDatoteke; //vracamo imena datoteka koja se nalaze u folderu
        }
    }
}
