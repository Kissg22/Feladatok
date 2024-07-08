using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace UszoVersenyMenuVezerelt
{
    public partial class Form1 : Form
    {
        private List<Versenyzo> versenyzok = new List<Versenyzo>();
        private VersenyForm versenyForm;
        private EredmenyForm eredmenyForm = new EredmenyForm();

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "versenyzok.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "kiir.txt";

            versenyForm = new VersenyForm();

            versenytoolStripMenuItem2.Enabled = false;
            mentesToolStripMenuItem.Enabled = false;
            eredmenytoolStripMenuItem3.Enabled = false;
        }

        public void Fogad(List<Versenyzo> versenyzok)
        {
            this.versenyzok = versenyzok;
        }

        private void megnyitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AdatBevitel(openFileDialog1.FileName);
                    versenytoolStripMenuItem2.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hibaüzenet a fejlesztő számára");
                }
            }
        }

        private void AdatBevitel(string fajlNev)
        {
            versenyzok.Clear();
            var sorok = File.ReadAllLines(fajlNev);
            foreach (var sor in sorok)
            {
                if (!string.IsNullOrWhiteSpace(sor))
                {
                    var adatok = sor.Split(';');
                    if (adatok.Length == 3)
                    {
                        versenyzok.Add(new Versenyzo(adatok[0], adatok[1], adatok[2]));
                    }
                }
            }
        }

        private void versenytoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (versenyForm != null)
            {
                versenyForm.Fogad(versenyzok);

                this.Hide();
                versenyForm.ShowDialog();
                this.Show();
                eredmenytoolStripMenuItem3.Enabled = true;
                versenytoolStripMenuItem2.Enabled = false;
                mentesToolStripMenuItem.Enabled = true;

                int tav = versenyForm.Tav;
                string uszasNem = versenyForm.UszasNem;
                eredmenyForm.EredmenyHirdetes(uszasNem, tav, versenyzok);
            }
            else
            {
                MessageBox.Show("A versenyForm objektum null értéket kapott.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eredmenytoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            eredmenyForm.ShowDialog();
            this.Show();
        }

        private void nevjegytoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string keszito = "Kiss Gábor";
            NevjegyForm about = new NevjegyForm(keszito);
            about.ShowDialog();
        }

        private void mentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter iroCsatorna = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (var versenyzo in versenyzok)
                    {
                        iroCsatorna.WriteLine($"{versenyzo.Rajtszam};{versenyzo.Nev};{versenyzo.Orszag};{versenyzo.IdoEredmeny}");
                    }
                }
            }
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class Versenyzo
        {
            private static int sorSzam;

            public Versenyzo(string nev, string orszag, string zaszloNev)
            {
                Nev = nev;
                Orszag = orszag;
                ZaszloNev = zaszloNev;
                sorSzam++;
                Rajtszam = sorSzam.ToString("D2"); // Kétjegyű rajtszám
            }

            public void Versenyez(TimeSpan idoEredmeny)
            {
                IdoEredmeny = idoEredmeny;
            }

            public override string ToString()
            {
                return Nev;
            }

            public string Nev { get; set; }
            public string Orszag { get; set; }
            public string ZaszloNev { get; set; }
            public string Rajtszam { get; private set; }
            public TimeSpan IdoEredmeny { get; private set; }
        }
    }
}
