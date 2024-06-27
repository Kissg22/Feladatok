 using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmupark
{

    abstract class Jarmu
    {
        // Tulajdonságok (Properties)
        public string Azonosito { get; private set; }
        public string Rendszam { get; set; }
        public int GyartasiEv { get; private set; }
        public double Fogyasztas { get; set; }
        public double FutottKm { get; private set; }
        public int AktualisKoltseg { get; private set; }
        public bool Szabad { get; private set; }

        public static int AktualisEv { get; set; }
        public static int AlapDij { get; set; }
        public static double Haszonkulcs { get; set; }

        // konstruktor (ha már ismerjük a fogyasztást)
        public Jarmu(string azonosito, string rendszam, int gyartasiEv, double fogyasztas)
        {
            this.Azonosito = azonosito;
            this.Rendszam = rendszam;
            this.GyartasiEv = gyartasiEv;
            this.Fogyasztas = fogyasztas;
            this.Szabad = true;
        }

        // konstruktor (ha még nem ismerjük a fogyasztást, pl. vadonatúj a jármű)
        public Jarmu(string azonosito, string rendszam, int gyartasiEv)
        {
            this.Azonosito = azonosito;
            this.Rendszam = rendszam;
            this.GyartasiEv = gyartasiEv;
            this.Szabad = true;
        }

        // metódusok
        /// <summary>
        /// Kiszámolja a jármű korát.
        /// </summary>
        /// <returns></returns>
        public int Kor()
        {
            return Jarmu.AktualisEv - this.GyartasiEv;
        }

        /// <summary>
        /// A metódus paraméterében lévő értékkel növeli az eddig megtett kilométerek számát,
        /// és kiszámolja az aktuális út költségét. Beállítja, hogy foglalt (nem szabad).
        /// <returns>True, ha sikeresen lezajlott a fuvar, egyébként false.</returns>
        public bool Fuvaroz(double ut, int benzinAr)
        {
            if (this.Szabad)
            {
                this.FutottKm += ut;
                this.AktualisKoltseg = (int)(benzinAr * ut * this.Fogyasztas / 100);
                this.Szabad = false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kiszámolja az alap bérletdíjat.
        /// </summary>
        /// <returns></returns>
        public virtual int BerletDij()
        {
            return (int)(Jarmu.AlapDij + this.AktualisKoltseg + this.AktualisKoltseg * Jarmu.Haszonkulcs / 100);
        }

        public void Vegzett()
        {
        Szabad = true;
        }
        public override string ToString()
        {
            return string.Format("\n {0,-10}\n\tazonosítója: {1,3}\n\trendszáma: {2,-8}\n\tkora: {3,3} év\n\tfogyasztása: {4,3:0.0} liter/100 km\n\ta km-óra állása: {5,8:0.00} km",
                this.GetType().Name.ToLower(), Azonosito, Rendszam, Kor(), Fogyasztas, FutottKm);
        }


    }

    class Busz : Jarmu
    {
        // tulajdonságok
        public int Ferohely { get; private set; }
        public static double Szorzo { get; set; }

        // konstruktorok
        public Busz(string azonosito, string rendszam, int gyartasiEv, double fogyasztas, int ferohely)
            : base(azonosito, rendszam, gyartasiEv, fogyasztas)
        {
            this.Ferohely = ferohely;
        }

        public Busz(string azonosito, string rendszam, int gyartasiEv, int ferohely)
            : base(azonosito, rendszam, gyartasiEv)
        {
            this.Ferohely = ferohely;
        }

        // metódusok
        // Kiszámolja a busz bérletdíját.
        public override int BerletDij()
        {
            return (int)(base.BerletDij() + Ferohely * Szorzo);
        }

        public override string ToString()
        {
            return base.ToString() + "\n\tférőhelyek száma: " + Ferohely;
        }
    }

    class TeherAuto : Jarmu
    {
        // tulajdonságok
        public double TeherBiras { get; private set; }
        public static double Szorzo { get; set; }

        // konstruktor
        public TeherAuto(string azonosito, string rendszam, int gyartasiEv, double fogyasztas, double teherBiras)
            : base(azonosito, rendszam, gyartasiEv, fogyasztas)
        {
            this.TeherBiras = teherBiras;
        }

        public TeherAuto(string azonosito, string rendszam, int gyartasiEv, double teherBiras)
            : base(azonosito, rendszam, gyartasiEv)
        {
            this.TeherBiras = teherBiras;
        }

        // metódusok
        // Kiszámolja a teherautó bérletdíját.
        public override int BerletDij()
        {
            return (int)(base.BerletDij() + TeherBiras * Szorzo);
        }

        public override string ToString()
        {
            return base.ToString() + "\n\tteherbírás: " + TeherBiras + " tonna";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jarmu> jarmuvek = new List<Jarmu>();

            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\C#\\Jarmupark\\jarmu_adatok.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string tipus = sr.ReadLine()?.Trim().ToLower();

                        if (tipus == "busz")
                        {
                            string rendszam = sr.ReadLine()?.Trim();
                            int gyartasiEv = int.Parse(sr.ReadLine()?.Trim() ?? throw new InvalidOperationException(), CultureInfo.InvariantCulture);
                            double fogyasztas = double.Parse(sr.ReadLine()?.Trim() ?? throw new InvalidOperationException(), CultureInfo.InvariantCulture);
                            int ferohely = int.Parse(sr.ReadLine()?.Trim() ?? throw new InvalidOperationException(), CultureInfo.InvariantCulture);

                            Busz busz = new Busz("busz", rendszam, gyartasiEv, fogyasztas, ferohely);
                            busz.Fuvaroz(100, 350); // Példaként 100 km-es út, 350 Ft/liter benzinárral

                            jarmuvek.Add(busz);
                        }
                        else if (tipus == "teherauto")
                        {
                            string rendszam = sr.ReadLine()?.Trim();
                            int gyartasiEv = int.Parse(sr.ReadLine()?.Trim() ?? throw new InvalidOperationException(), CultureInfo.InvariantCulture);
                            double fogyasztas = double.Parse(sr.ReadLine()?.Trim() ?? throw new InvalidOperationException(), CultureInfo.InvariantCulture);
                            double teherBiras = double.Parse(sr.ReadLine()?.Trim() ?? throw new InvalidOperationException(), CultureInfo.InvariantCulture);

                            TeherAuto teherauto = new TeherAuto("teherauto", rendszam, gyartasiEv, fogyasztas, teherBiras);
                            teherauto.Fuvaroz(200, 450); // Példaként 200 km-es út, 450 Ft/liter benzinárral

                            jarmuvek.Add(teherauto);
                        }
                        else
                        {
                            Console.WriteLine("Ismeretlen járműtípus: " + tipus);
                            // További sorokat el kell olvasni és lépni kell a következő járműre
                            sr.ReadLine(); // Gyártási év vagy fogyasztás
                            sr.ReadLine(); // Fogyasztás vagy teherbírás
                            sr.ReadLine(); // Ferőhely (ha busz)
                        }
                    }
                }

                // Beállítjuk az aktuális évet és alapdíjat
                Jarmu.AktualisEv = 2024;
                Jarmu.AlapDij = 5000;

                // Kiírjuk az összes jármű adatait
                foreach (var jarmu in jarmuvek)
                {
                    Console.WriteLine(jarmu);
                    Console.WriteLine("\tBérletdíj: " + jarmu.BerletDij() + " Ft");

                    // Vegzett metódus hívása
                    jarmu.Vegzett();

                    Console.WriteLine("\tÁllapot (szabad-e): " + (jarmu.Szabad ? "szabad" : "nem szabad"));
                    Console.WriteLine("----------------------------------------------");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("A fájl nem található.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt: " + ex.Message);
            }

            Console.ReadLine();
        }

    }


}
    
