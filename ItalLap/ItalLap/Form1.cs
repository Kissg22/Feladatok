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

namespace ItalLap
{
    public partial class Form1 : Form
    {
        private List<Ital> italok = new List<Ital>();
        private List<Image> kepek = new List<Image>();
        private int kepekSzama = 3;
        public class Ital
        {
            public string ItalNev { get; set; }
            public int EgysegAr { get; set; }
            public int Mennyiseg { get; private set; }
            public int OsszMennyiseg { get; private set; }
            public int Bevetel { get; private set; }


            public Ital(string italNev, int egysegAr)
            {
                this.ItalNev = italNev;
                this.EgysegAr = egysegAr;
                this.Mennyiseg = 0; // Kezdetben a mennyiség 0
            }

            public void Rendel(int db)
            {
                Mennyiseg += db;
            }

            public int Fizetendo()
            {
                return Mennyiseg * EgysegAr;
            }

            public void Fizet()
            {
                OsszMennyiseg += Mennyiseg;
                Bevetel += Mennyiseg * EgysegAr;
                Mennyiseg = 0;
            }

            public string Arlistaba()
            {
                return ItalNev + " (" + EgysegAr + " Ft)";
            }

            public string Konyvelesbe()
            {
                return ItalNev + ";" + OsszMennyiseg + ";" + Bevetel;
            }

            public override string ToString()
            {
                return Mennyiseg.ToString().PadLeft(5) + " " + ItalNev.PadRight(60) + Fizetendo().ToString().PadLeft(90) + " Ft";
            }

        }

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "arlap.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "konyveles.txt";
            mentesMenu.Enabled = false;
            italLapMenu.Enabled = false;

            megnyitasMenu.ShortcutKeys = Keys.Control | Keys.M;

            mentesMenu.ShortcutKeys = Keys.Control | Keys.S;    

            kilepesMenu.ShortcutKeys = Keys.Alt | Keys.F4;       

        }


        private void MentesMenu_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;
                    File.WriteAllLines(filePath, italok.Select(i => $"{i.ItalNev},{i.EgysegAr}"));
                }
            }
        }

        private void italLapMenu_Click(object sender, EventArgs e)
        {
            Form2 italForm = new Form2();
            italForm.ArlapotIr(italok);
            italForm.ShowDialog();
        }

        private void galeriaMenu_Click(object sender, EventArgs e)
        {
            Form3 galeriaForm = new Form3();
            galeriaForm.Atad(kepek);
            galeriaForm.Show();
        }

        private void sugoMenu_Click(object sender, EventArgs e)
        {
            Form5 sugo = new Form5();
            sugo.ShowDialog();
        }

        private void nevjegyMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Készült: prog2 gyakorlaton","Információ");
        }

        private void megnyitasMenu_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader olvasoCsatorna = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    olvasoCsatorna = new StreamReader(fajlNev);
                    AdatBevitel(olvasoCsatorna);
                    italLapMenu.Enabled = true;
                    mentesMenu.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hibaüzenet a fejlesztő számára");
                }
                finally
                {
                    if (olvasoCsatorna != null)
                    {
                        olvasoCsatorna.Close();
                    }
                }
            }

        }

        private void mentesMenu_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter iroCsatorna = null;
                try
                {
                    string fajlNev = saveFileDialog1.FileName;
                    iroCsatorna = new StreamWriter(fajlNev);
                    FajlbaIr(iroCsatorna);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a fájl írásakor: " + ex.Message, "Hiba");
                }
                finally
                {
                    if (iroCsatorna != null)
                    {
                        iroCsatorna.Close();
                    }
                }
            }
        }
        private void FajlbaIr(StreamWriter iroCsatorna)
        {
            foreach (Ital item in italok)
            {
                iroCsatorna.WriteLine(item.Konyvelesbe());
            }
        }

        private void kilepesMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                KepBetoltes();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a képek betöltésekor", "Hiba");
            }
        }

        private void KepBetoltes()
        {
            Image kep;
            for (int i = 1; i <= kepekSzama; i++)
            {
                kep = Image.FromFile("kep" + i + ".png");
                kepek.Add(kep);
            }
        }

        private void AdatBevitel(StreamReader olvasoCsatorna)
        {
            string sor = olvasoCsatorna.ReadLine();
            while (sor != null)
            {
                string[] adatok = sor.Split(';');
                // Example: "Kupica kisüsti szilva pálinka;200"
                italok.Add(new Ital(adatok[0], int.Parse(adatok[1])));
                sor = olvasoCsatorna.ReadLine();
            }
        }

    }
}

