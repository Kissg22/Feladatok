using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiakkezeloBResz
{
    public partial class Form1 : Form
    {
        private List<Diak> diakok = new List<Diak>();
        private List<int> evek = new List<int>(); // List to store unique birth years
        private List<CheckBox> chkBoxok = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
        }

        public class Diak
        {
            public string Nev { get; set; }
            public string Kod { get; set; }
            public int SzuletesiEv { get; set; }

            public Diak(string nev, string kod, int szuletesiEv)
            {
                Nev = nev;
                Kod = kod;
                SzuletesiEv = szuletesiEv;
            }

            public override string ToString()
            {
                return $"{Nev} ({Kod}, {SzuletesiEv})";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    AdatBeolvasas(fajlNev);
                    FelrakEvek(); // Display birth year buttons
                   // GombBeallitas(true); // Enable buttons after successful data load
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        }

        private void AdatBeolvasas(string fajlNev)
        {
            string[] sorok = File.ReadAllLines(fajlNev);
            foreach (string sor in sorok)
            {
                Feldolgoz(sor);
            }
        }

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));

            // Add to listbox
            listBox1.Items.Add(diak.ToString());

            // Add birth year to evek list if not already present
            int szuletesiEv = diak.SzuletesiEv;
            if (!evek.Contains(szuletesiEv))
            {
                evek.Add(szuletesiEv);
            }

            // Add to diakok list for further processing if needed
            diakok.Add(diak);
        }

        private void FelrakEvek()
        {
            Button btn;
            evek.Sort(); // Az évek növekvő sorrendbe rendezése

            int kezdoX = 10; // Kezdő X pozíció
            int kezdoY = 10; // Kezdő Y pozíció
            int btnXKoz = 100; // Gombok közti távolság

            for (int i = 0; i < evek.Count; i++)
            {
                btn = new Button();
                btn.Location = new Point(kezdoX + i * btnXKoz, kezdoY);
                btn.Text = evek[i].ToString();
                btn.Tag = evek[i]; // Az év értékét hozzáadjuk a gomb Tag tulajdonságához

                // Eseménykezelő hozzárendelése a gombhoz
                btn.Click += new System.EventHandler(BtnEv_Click);

                // Gomb hozzáadása a panelhez
                pnlEvek.Controls.Add(btn);
            }
        }

        private void BtnEv_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int selectedYear = (int)clickedButton.Tag;

                lstKivalasztottak.Items.Clear(); // Clear previous selection

                // Filter students born in the selected year
                foreach (Diak diak in diakok)
                {
                    if (diak.SzuletesiEv == selectedYear)
                    {
                        lstKivalasztottak.Items.Add(diak); // Diák objektum hozzáadása a listához
                    }
                }
            }
        }

        private void lstKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKivalasztottak.SelectedItem != null)
            {
                // Kiválasztott diák objektum lekérése
                Diak selectedDiak = lstKivalasztottak.SelectedItem as Diak;
                if (selectedDiak != null)
                {
                    // A lblKiiras Label-be beállítjuk a kiválasztott diák adatait
                    lblkiiras.Text = $"{selectedDiak.Nev} ({selectedDiak.Kod}), Születési éve: {selectedDiak.SzuletesiEv}";
                }
            }
        }

        private void lblkiiras_Click(object sender, EventArgs e)
        {

        }
    }
}