using DatotekeUDirektoriju01;
using System;
using System.Collections.Generic;
using System.IO;


namespace DatotecniSustav01
{
    class Program
    {
        //globalne varijable
        private static string put = "";
        private static int index = 0;
        private static List<string> cijelaPutanja = new List<string>();

        static void Main(string[] args)
        {
            Console.CursorVisible = false; //maknemo blinkajucu liniju

            while (cijelaPutanja.Count==0)
            {
                //Početna stranica
                Console.WriteLine("******** Pocetak menu *********");
                put = NacrtajMeni(Disks.pocetnaDisk(), put);
                cijelaPutanja.Add(put);
            }
            while (cijelaPutanja.Count!=0)
            {

                //pokrenemo drugi window
                index = 0;
                Console.Clear();
                Console.WriteLine("******** Datoteke *********");

                put = NacrtajMeni(Datoteke.DatotekeLista(put), put);

            }



            //ovdje ide orginalni kod


        } //Main


        //Metoda za crtanje liste
        private static string NacrtajMeni(List<string> lista, string put)
        {
            //Slaganje promjene boje na označenom itemu
            for (int i = 0; i < lista.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(lista[i]);
                }
                else
                {
                    Console.WriteLine(lista[i]);
                }
                Console.ResetColor();
            }

            //Funkcije koje ce se desavati pritiskom tipke na tipkovnici
            ConsoleKeyInfo pritisnutaTipka = Console.ReadKey(); //ocitavanje tipke

            if (pritisnutaTipka.Key == ConsoleKey.DownArrow)
            {
                if (index == lista.Count - 1)
                {
                    //index = 0; //vracamo se na pocetak liste
                }
                else
                {
                    index++;
                }
            }
            else if (pritisnutaTipka.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = lista.Count - 1; //vracamo se na dno liste
                }
                else
                {
                    index--;
                }
            }
            else if (pritisnutaTipka.Key == ConsoleKey.Enter)
            {
                Console.WriteLine(lista[index]);
                if (lista[index] == "Exit")
                {
                    Environment.Exit(0);
                }
                //Console.Clear();

                return put = lista[index];
            }
            else
            {
                //Console.Clear();
                return "";
            }
            Console.Clear();
            return "";
        } //Nacrtaj meni
    }
}


/*
           //Put za direktorij
           string putDir = @"C:\";

           //Specifikacija direktorija koji želimo manipulirati
           DirectoryInfo dirInfo = new DirectoryInfo(putDir);

           var datoteke = dirInfo.GetFiles();

           long velicina = 0;

           Console.WriteLine("+------------------+-------------+---------+------------------------------------------+");
           Console.WriteLine("| Veličina       B |          KB |      MB | Nazivi datoteka                          |");
           Console.WriteLine("+------------------+-------------+---------+------------------------------------------+");
           foreach (FileInfo d in datoteke)
           {
               velicina += d.Length;
               Console.WriteLine("|{0, 15} B | {1, 8} KB | {2, 4} MB | {3,40} |", 
                   d.Length, 
                   d.Length / 1024, 
                   d.Length / (1024 * 1024),
                   d.FullName);
           }
           Console.WriteLine("+------------------+-------------+---------+------------------------------------------+");
           Console.WriteLine("|{0, 15} B | {1, 8} KB | {2, 4} MB |                                          |",
               velicina,
               velicina / 1024,
               velicina / (1024 * 1024));
           Console.WriteLine("+------------------+-------------+---------+------------------------------------------+");

           Console.SetCursorPosition(1, 3);
           Console.Write(">");
           int brojRedova = datoteke.Length + 6;

           int cekanjeTreperenje = 500;
           Console.CursorVisible = false;
           int pokazivacY = 3;
           while (true)
           {
               System.Threading.Thread.Sleep(cekanjeTreperenje);
               Console.SetCursorPosition(1, pokazivacY);
               Console.Write(" ");
               System.Threading.Thread.Sleep(cekanjeTreperenje);
               Console.SetCursorPosition(1, pokazivacY);
               Console.Write(">");

               if (Console.KeyAvailable)
               {
                   ConsoleKeyInfo pritisnutaTipka = Console.ReadKey(true);
                   if (pritisnutaTipka.Key == ConsoleKey.DownArrow)
                   {
                       pokazivacY++;
                   }
               }
           }

           // Console.SetCursorPosition(0, brojRedova);
*/
