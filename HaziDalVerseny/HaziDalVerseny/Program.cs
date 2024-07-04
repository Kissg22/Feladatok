﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HaziDalVerseny
{
    class Versenyzo
    {
        private int rajtSzam;
        private string nev;
        private string szak;
        private int pontSzam;

        public Versenyzo(int rajtSzam, string nev, string szak)
        {
            this.rajtSzam = rajtSzam;
            this.nev = nev;
            this.szak = szak;
        }

        public void PontotKap(int pont)
        {
            pontSzam += pont;
        }

        public override string ToString()
        {
            return $"{rajtSzam,-5} {nev,-20} {szak,-20} {pontSzam,-2} pont";
        }

        public int RajtSzam
        {
            get { return rajtSzam; }
        }

        public string Nev
        {
            get { return nev; }
        }

        public string Szak
        {
            get { return szak; }
        }

        public int PontSzam
        {
            get { return pontSzam; }
        }
    }




    class Vezerloosztaly
    {
        private List<Versenyzo> versenyzok = new List<Versenyzo>();
        private int zsuriletszam = 5;
        private int pontHatar = 10;

        public void Start()
        {
            AdatBevitel();
            Kiiratas("\nRésztvevők:\n");
            Verseny();
            Kiiratas("\nEredmények:\n");
            Eredmenyek();
            Keresesek();
        }

        private void AdatBevitel()
        {
            string nev, szak;
            int sorszam = 1;
            StreamReader olvasoCsatorna = new StreamReader("versenyzok.txt");
            while (!olvasoCsatorna.EndOfStream)
            {

                nev = olvasoCsatorna.ReadLine();
                szak = olvasoCsatorna.ReadLine();
                Versenyzo versenyzo = new Versenyzo(sorszam, nev, szak);
                versenyzok.Add(versenyzo);
                sorszam++;
            }
            olvasoCsatorna.Close();
        }

        private void Kiiratas(string cim)
        {
            Console.WriteLine(cim);
            foreach (Versenyzo enekes in versenyzok)
            {
                Console.WriteLine(enekes);
            }
        }

        private void Verseny()
        {
            Random rand = new Random();
            int pont;
            foreach (Versenyzo versenyzo in versenyzok)
            {
               
                for (int i = 1; i <= zsuriletszam; i++)
                {
                    pont = rand.Next(pontHatar);
                    versenyzo.PontotKap(pont);
                }
            }
        }

        private void Eredmenyek()
        {
            Nyertes();
            Sorrend();
        }

        private void Nyertes()
        {
            
            int max = versenyzok[0].PontSzam;
           
            foreach (Versenyzo enekes in versenyzok)
            {
                if (enekes.PontSzam > max)
                {
                    max = enekes.PontSzam;
                }
            }
         
            Console.WriteLine("\nA legjobb(ak):\n");
            foreach (Versenyzo enekes in versenyzok)
            {
                if (enekes.PontSzam == max)
                {
                    Console.WriteLine(enekes);
                }
            }
        }

        private void Sorrend()
        {
          
            versenyzok.Sort((x, y) => y.PontSzam.CompareTo(x.PontSzam));
            Kiiratas("\nEredménytábla:\n");
        }

        private void Keresesek()
        {
            Console.WriteLine("\nAdott szakhoz tartozó énekesek keresése\n");
            Console.Write("\nKeres valakit? (i/n) ");
            char valasz;
            while (!char.TryParse(Console.ReadLine(), out valasz) || (valasz != 'i' && valasz != 'n'))
            {
                Console.Write("Egy karaktert írjon (i/n). ");
            }

            while (valasz == 'i')
            {
                Console.Write("Szak: ");
                string szak = Console.ReadLine();
                bool vanIlyen = false;
                foreach (Versenyzo enekes in versenyzok)
                {
                    if (enekes.Szak == szak)
                    {
                        Console.WriteLine(enekes);
                        vanIlyen = true;
                    }
                }

                if (!vanIlyen)
                {
                    Console.WriteLine("Erről a szakról senki sem indult.");
                }

                Console.Write("\nKeres még valakit? (i/n) ");
                while (!char.TryParse(Console.ReadLine(), out valasz) || (valasz != 'i' && valasz != 'n'))
                {
                    Console.Write("Egy karaktert írjon (i/n). ");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            new Vezerloosztaly().Start();

            Console.ReadKey();
        }
    }
}
   
