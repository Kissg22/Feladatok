using System;
using System.Xml;

namespace Allat
{
    class Allat
    {
  
        private string nev;
        private int szuletesiEv;
        private int szepsegPont;
        private int viselkedesPont;
        private int pontSzam;
        private static int aktualisEv;
        private static int korHatar;

        // konstruktor
        public Allat(string nev, int szuletesiEv)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
        }

        // metódusok
        public int Kor()
        {
            return aktualisEv - szuletesiEv;
        }

        public void Pontozzak(int szepsegPont, int viselkedesPont)
        {
            this.szepsegPont = szepsegPont;
            this.viselkedesPont = viselkedesPont;
            if (Kor() <= korHatar)
            {
                pontSzam = viselkedesPont * Kor() + szepsegPont * (korHatar - Kor());
            }
            else
            {
                pontSzam = 0;
            }
        }

        public override string ToString()
        {
            return $"{nev} pontszáma: {pontSzam} pont";
        }

        // Tulajdonságok
        // Kívülről nem változtatható értékek
        public string Nev
        {
            get { return nev; }
        }


        public int SzuletesiEv
        {
            get { return szuletesiEv; }
        }


        public int SzepsegPont
        {
            get { return szepsegPont; }
        }

        public int ViselkedesPont
        {
            get { return viselkedesPont; }
        }

        public int PontSzam
        {
            get { return pontSzam; }
        }

        // Kívülről változtatható értékek
        public static int AktualisEv
        {
            get { return aktualisEv; }
            set { aktualisEv = value; }
        }

        public static int KorHatar
        {
            get { return korHatar; }
            set { korHatar = value; }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            // Az allat nevű változó deklarálása
            Allat allat;

            int aktEv = 2015, korhatar = 10;

            string nev;
            int szulEv;
            int szepseg, viselkedes;

            // Az aktuális év és a korhatár megadása
            Allat.AktualisEv = aktEv;
            Allat.KorHatar = korhatar;

            //csak egyetlen példány kipróbálása:
            nev = "Vakarcs";
            szulEv = 2010;
            szepseg = 5;
            viselkedes = 3;

            //az allat példány létrehozása
            allat = new Allat(nev, szulEv);

            //a pontozási metódus meghívása
            allat.Pontozzak(szepseg, viselkedes);

            Console.WriteLine(allat);
            Console.WriteLine();





            AllatVerseny();
        }

        private static void AllatVerseny()
        {
            // Az allat nevű változó deklarálása
            Allat allat;


            string nev;
            int szulEv;
            int szepseg, viselkedes;
            int veletlenPontHatar = 10;

            // Egy Random példány létrehozása
            Random rand = new Random();

            // Számoláshoz szükséges kezdőértékek beállítása

            int osszesVersenyzo = 0;
            int osszesPont = 0;
            int legtobbPont = 0;

            Console.WriteLine("Kezdődik a verseny");
            char tovabb = 'i';


            while (tovabb == 'i')
            {
                Console.Write("Az állat neve: ");
                nev = Console.ReadLine();

                Console.Write("Születési éve: ");
                while (!int.TryParse(Console.ReadLine(), out szulEv) || szulEv <= 0 || szulEv > Allat.AktualisEv)
                {
                    Console.Write("Hibás adat, kérem újra: ");
                }

                // Véletlen pontértékek
                szepseg = rand.Next(veletlenPontHatar + 1);
                viselkedes = rand.Next(veletlenPontHatar + 1);

                // Az állat példány létrehozása
                allat = new Allat(nev, szulEv);

                // a pontozási metódus meghívása
                allat.Pontozzak(szepseg, viselkedes);

                Console.WriteLine(allat);

                // számítások

                osszesVersenyzo++;
                osszesPont += allat.PontSzam;

                if (legtobbPont < allat.PontSzam)
                {
                    legtobbPont = allat.PontSzam;
                }

                Console.WriteLine("Van még állat? (i/n)");

                //alakítsa át ellenőrzött beolvasásra
                tovabb = char.Parse(Console.ReadLine());
            }
            //eredmény kiírása
            Console.WriteLine($"Összesen {osszesVersenyzo} versenyző volt");
            Console.WriteLine($"Átlaguk: {1.0 * osszesPont / osszesVersenyzo}");
            Console.WriteLine($"Összpontszámuk: {osszesPont} pont");
            Console.WriteLine($"Legnagyobb pontszám: {legtobbPont}");
            Console.ReadKey();
        }
    }
}