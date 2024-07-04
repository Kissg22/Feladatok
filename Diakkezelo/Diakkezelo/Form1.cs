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

namespace Diakkezelo
{
    public partial class Form1 : Form
    {
        private List<Diak> diakok = new List<Diak>();
        private List<CheckBox> chkBoxok = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GombBeallitas(false);
        }

        private void GombBeallitas(bool aktiv)
        {
            btnAdatbevitel.Enabled = !aktiv;
            btnKivalaszt.Enabled = aktiv;
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

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    AdatBeolvasas(fajlNev);
                    FelrakDiakok();
                    GombBeallitas(true);
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
            // Az adatfájl szerkezete:
            // Hegedűs Emma;HHMAB.PTE;1990

            string[] adatok = adat.Split(';');
            Diak diak = new Diak(adatok[0], adatok[1], int.Parse(adatok[2]));
            diakok.Add(diak);
        }

        private void FelrakDiakok()
        {
            pnlDiakok.Controls.Clear();
            chkBoxok.Clear();
            int kezdoY = 10;
            int chkyKoz = 25;
            int kezdox = 10;

            for (int i = 0; i < diakok.Count; i++)
            {
                CheckBox chkBox = new CheckBox();
                chkBox.AutoSize = true;
                chkBox.Location = new Point(kezdox, kezdoY + i * chkyKoz);
                chkBox.Text = diakok[i].ToString();
                pnlDiakok.Controls.Add(chkBox);
                chkBoxok.Add(chkBox);
            }
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            Kivalaszt();
        }

        private void Kivalaszt()
        {
            bool vanValasztott = false;
            lstKivalasztottak.Items.Clear();
            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    lstKivalasztottak.Items.Add(diakok[i]);
                    vanValasztott = true;
                }
            }

            if (!vanValasztott)
            {
                MessageBox.Show("Senkit sem választott", "Hiba");
            }
            else
            {
                MinKeres();
            }
        }

        private void MinKeres()
        {
            lstLegidosebbek.Items.Clear();
            int minEv = (lstKivalasztottak.Items[0] as Diak).SzuletesiEv;

            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.SzuletesiEv < minEv)
                {
                    minEv = diak.SzuletesiEv;
                }
            }

            foreach (Diak diak in lstKivalasztottak.Items)
            {
                if (diak.SzuletesiEv == minEv)
                {
                    lstLegidosebbek.Items.Add(diak);
                }
            }
        }

        private void lstLegidosebbek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLegidosebbek.SelectedItem != null)
            {
                
                Diak selectedDiak = lstLegidosebbek.SelectedItem as Diak;
                if (selectedDiak != null)
                {
                   
                    lblkiiras.Text = $"{selectedDiak.Nev} ({selectedDiak.Kod}), Születési éve: {selectedDiak.SzuletesiEv}";
                }
            }
        }
    }

}
