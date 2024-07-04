using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllatVersenyFolytatas
{
     class Allat
    {

        // mezők és tulajdonságok helyett automatikus tulajdonságok
        public string Nev { get; private set; }
        public int SzuletesiEv { get; private set; }
        public int RajtSzam { get; private set; }
        public int SzepsegPont { get; private set; }
        public int ViselkedesPont { get; private set; }

        // az egyik utódban újra akarjuk számolni, ezért protected
        public int PontSzam { get; protected set; }

        public static int AktualisEv { get; set; }
        public static int KorHatar { get; set; }

        // konstruktor - nincs mező, ezért a tulajdonságok kapnak értéket
        public Allat(int rajtSzam, string nev, int szuletesiEv)
        {
            this.RajtSzam = rajtSzam;
            this.Nev = nev;
            this.SzuletesiEv = szuletesiEv;
        }

        // metódusok
        public int Kor()
        {
            return AktualisEv - SzuletesiEv;
        }

        // örökölhetővé kell tenni, ezért átírjuk virtual-ra
        public virtual void Pontozzak(int szepsegPont, int viselkedesPont)
        {
            this.SzepsegPont = szepsegPont;
            this.ViselkedesPont = viselkedesPont;

            if (Kor() < KorHatar)
            {
                PontSzam = viselkedesPont * Kor() + szepsegPont * (KorHatar - Kor());
            }
            else
            {
                PontSzam = 0;
            }
        }

        public override string ToString()
        {
            return $"{RajtSzam}. {Nev} nevű {this.GetType().Name.ToLower()} - Pontszám: {PontSzam}";
        }
    }

     class Kutya : Allat
    {
        public int GazdaViszonyPont { get; private set; }
        public bool KapottViszonyPontot { get; private set; }

        public Kutya(int rajtSzam, string nev, int szulEv)
            : base(rajtSzam, nev, szulEv)
        {
        }

        public void ViszonyPontozas(int gazdaViszonyPont)
        {
            this.GazdaViszonyPont = gazdaViszonyPont;
            KapottViszonyPontot = true;
        }

        public override void Pontozzak(int szepsegPont, int viselkedesPont)
        {
            base.Pontozzak(szepsegPont, viselkedesPont);
            if (KapottViszonyPontot)
            {
                this.PontSzam += GazdaViszonyPont;
            }
        }
    }

     class Macska : Allat
    {
        public bool VanMacskaSzallitoDoboz { get; set; }

        public Macska(int rajtSzam, string nev, int szulEv, bool vanMacskaSzallitoDoboz)
            : base(rajtSzam, nev, szulEv)
        {
            this.VanMacskaSzallitoDoboz = vanMacskaSzallitoDoboz;
        }

        public override void Pontozzak(int szepsegPont, int viselkedesPont)
        {
            if (VanMacskaSzallitoDoboz)
            {
                base.Pontozzak(szepsegPont, viselkedesPont);
            }
        }
    }

    public class Vezerles
    {
        // ez nem kell a próbához
        private List<Allat> allatok = new List<Allat>();

        public void Start()
        {
            Allat.AktualisEv = 2015;
            Allat.KorHatar = 10;
            // először csak ennyi
            Proba();
            // önállóan oldja meg a többit
            Regisztracio();
            Kiiratas("\nA regisztrált versenyzők\n");
            Verseny();
            Kiiratas("\nA verseny eredménye\n");
        }

        private void Proba()
        {
            Allat allat1, allat2;
            string nev1 = "Pamacs", nev2 = "Bolhazsák";
            int szulEv1 = 2010, szulEv2 = 2011; // helyes értékadás
            bool vanDoboz = true;
            int rajtSzam = 1;
            int szepsegPont = 5, viselkedesPont = 4, viszonyPont = 6;

            allat1 = new Kutya(rajtSzam, nev1, szulEv1);
            rajtSzam++;
            allat2 = new Macska(rajtSzam, nev2, szulEv2, vanDoboz);

            Console.WriteLine("A regisztrált állatok:");
            Console.WriteLine(allat1);
            Console.WriteLine(allat2);

            // verseny:

            allat2.Pontozzak(szepsegPont, viselkedesPont);
            if (allat1 is Kutya kutya)
            {
                kutya.ViszonyPontozas(viszonyPont);
            }
            allat1.Pontozzak(szepsegPont, viselkedesPont);


            Console.WriteLine("\nA verseny eredménye:");
            Console.WriteLine(allat1);
            Console.WriteLine(allat2);
        }

        private void Regisztracio()
        {
            StreamReader olvasoCsatorna = new StreamReader("allatok.txt");
            string fajta, nev;
            int rajtSzam = 1, szulEv;
            bool vanDoboz;

            // Addig olvasunk, amíg el nem értük a fájl végét.
            while (!olvasoCsatorna.EndOfStream)
            {
                fajta = olvasoCsatorna.ReadLine();
                nev = olvasoCsatorna.ReadLine();
                szulEv = int.Parse(olvasoCsatorna.ReadLine());

                // Létrehozzuk a példányokat és hozzáadjuk az allatok listához.
                if (fajta == "kutya")
                {
                    allatok.Add(new Kutya(rajtSzam, nev, szulEv));
                }
                else
                {
                    vanDoboz = bool.Parse(olvasoCsatorna.ReadLine());
                    allatok.Add(new Macska(rajtSzam, nev, szulEv, vanDoboz));
                }

                rajtSzam++;
            }

            olvasoCsatorna.Close();
        }
        private void Kiiratas(string uzenet)
        {
            Console.WriteLine(uzenet);
            foreach (var allat in allatok)
            {
                Console.WriteLine(allat.ToString());
            }
        }

        private void Verseny()
        {
            Random rand = new Random();
            int hatar = 11;

            foreach (Allat item in allatok)
            {
                if (item is Kutya kutya)
                {
                    kutya.ViszonyPontozas(rand.Next(hatar));
                }

                item.Pontozzak(rand.Next(hatar), rand.Next(hatar));
            }
        }


    }


    class Program
    {

        static void Main(string[] args)
        {
            new Vezerles().Start();
            Console.ReadKey();
        }

       
    }
}
