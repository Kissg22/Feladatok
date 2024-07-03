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

namespace PizzeriaKG
{


    public partial class Form1 : Form
    {
        private bool lathato;

        private List<Pizza> pizzak = new List<Pizza>();
        private List<CheckBox> jeloloNegyzet = new List<CheckBox>();
        private List<RadioButton> rdBtnKicsiArak = new List<RadioButton>();
        private List<RadioButton> rdBtnNagyArak = new List<RadioButton>();
        private List<TextBox> txtDarabok = new List<TextBox>();

        // Az első jelölőnégyzet távolsága a központi panel baloldalától és tetejétől
        private int bal = 20;
        private int fent = 10;

        // Két-két jelölőnégyzet bal felső sarkának egymástól való (függőleges) távolsága
        private int kozy = 40;

        // Az egyes vezérlőelemek magassága
        private int meretY = 20;

        // A rádiógombokat tartalmazó panel vízszintes mérete
        private int panelx = 200;

        // A jelölőnégyzet dobozának vízszintes mérete
        private int meretChk = 120;

        // A rádiógombok dobozának vízszintes mérete
        private int meretAr = 50;

        // A Ft felirat vízszintes mérete
        private int meretFt = 40;

        // A darabszám bevitelére szolgáló szövegdoboz vízszintes mérete
        private int meretDb = 50;

        // A Ft, ill. darab szöveg távolsága az előtte lévő doboztól
        private int koz = 3;



        public Form1()
        {
            InitializeComponent();
            // Beállítjuk az induló mappa helyét - ezt kínálja fel, amikor megnyílik a dialógus ablak
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            // Beállítjuk, hogy milyen fájlnevet ajánljon fel indulásként
            // Ezt a tulajdonságot a Properties ablakban is beállíthatjuk
            openFileDialog1.FileName = "";

            // Beállítjuk a vezérlőelemek láthatóságát
            lathato = false;
            LathatosagBeallitas(lathato);
        }



        public class Pizza
        {
            public string Nev { get; private set; }
            public int ArKicsi { get; set; }
            public int ArNagy { get; set; }

            public Pizza(string nev, int arKicsi, int arNagy)
            {
                Nev = nev;
                ArKicsi = arKicsi;
                ArNagy = arNagy;
            }
            public override string ToString()
            {
                return this.Nev;
            }
        }        /// <summary>
                 /// Beállítja az összes vezérlőelem láthatóságát.
                 /// Az adatbevitel gomb láthatósága épp ellenkezője a többinek.
                 /// </summary>
                 /// <param name="lathatoE">A vezérlőelemek láthatósága</param>
        private void LathatosagBeallitas(bool lathatoE)
        {
            foreach (Control item in this.Controls)
            {
                item.Visible = lathatoE;
            }
            btnadatBe.Visible = !lathatoE;
        }

        private void btnadatBe_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;

                // StreamReader használata using blokkban
                using (StreamReader olvasoCsatorna = new StreamReader("pizza.txt"))
                {
                    try
                    {
                        // AdatBeolvasas metódus meghívása
                        AdatBeolvasas(olvasoCsatorna);

                        // ValasztekFeltoltes metódus meghívása
                        ValasztekFeltoltes();

                        // A láthatóság átállítása
                        lathato = true;
                        LathatosagBeallitas(lathato);

                        // Gomb láthatóságának beállítása
                        btnadatBe.Visible = false;
                        this.BackgroundImage = null;
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
        }

        private void ValasztekFeltoltes()
        {
            CheckBox checkBox;
            Label label;
            RadioButton radioButton;
            Panel panel;
            TextBox textBox;

            for (int i = 0; i < pizzak.Count; i++)
            {
                // CheckBox felrakása
                checkBox = new CheckBox();
                checkBox.TextAlign = ContentAlignment.MiddleLeft;
                checkBox.Text = pizzak[i].Nev;
                checkBox.Location = new Point(bal, fent + i * kozy);
                checkBox.Size = new Size(meretChk, meretY);

                // a most beállított jelölőnégyzetet hozzáadjuk a jelölőnégyzetek listájához
                jeloloNegyzet.Add(checkBox);

                // a most beállított jelölőnégyzetet rárakjuk a központi panelre
                pnlkozponti.Controls.Add(checkBox);

                // Panel felrakása
                panel = new Panel();
                panel.Size = new Size(panelx, meretY);
                panel.Location = new Point(bal + meretChk, fent + i * kozy);

                // A panelt rárakjuk a központi panelre
                pnlkozponti.Controls.Add(panel);

                // Radiobtn kicsi ár felrakása
                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleRight;
                radioButton.Text = pizzak[i].ArKicsi.ToString();
                radioButton.Location = new Point(0, 0);
                rdBtnKicsiArak.Add(radioButton);

                // A rádiógombot rárakjuk az őket tartalmazó panelre
                panel.Controls.Add(radioButton);

                // Radiobtn nagy ár felrakása
                radioButton = new RadioButton();
                radioButton.Size = new Size(meretAr, meretY);
                radioButton.TextAlign = ContentAlignment.MiddleRight;
                radioButton.Text = pizzak[i].ArNagy.ToString();
                radioButton.Location = new Point(meretAr + koz, 0);
                rdBtnNagyArak.Add(radioButton);

                // A rádiógombot rárakjuk az őket tartalmazó panelre
                panel.Controls.Add(radioButton);

                // Fix Ft felirat
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = " Ft";
                label.Location = new Point(2 * meretAr + koz, 0);
                label.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);

                // textBox darabszám
                textBox = new TextBox();
                textBox.Location = new Point(2 * meretAr + koz + meretFt + koz, 0);
                textBox.Size = new Size(meretDb, meretY);
                txtDarabok.Add(textBox);
                panel.Controls.Add(textBox);

                // Fix darab felirat
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = " db";
                label.Location = new Point(2 * meretAr + koz + meretFt + koz + meretDb + koz, 0);
                label.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);
            }
        }


        private void btnSzamol_Click(object sender, EventArgs e)
        {
            bool vankijeloles = false;
            int db, osszeg = 0, ar = 0;

            for (int i = 0; i < jeloloNegyzet.Count; i++)
            {
                if (jeloloNegyzet[i].Checked)
                {
                    vankijeloles = true;
                    try
                    {
                        // ha az első fajtát választottuk
                        if (rdBtnKicsiArak[i].Checked)
                            ar = pizzak[i].ArKicsi;
                        // ha a második fajtát választottuk
                        else if (rdBtnNagyArak[i].Checked)
                            ar = pizzak[i].ArNagy;
                        // ha egyáltalán nem választottunk
                        else
                            throw new MissingFieldException();

                        // ide már csak akkor jut, ha tényleg választottunk, ezért
                        // kiolvashatja a db értékét. Ha hibás formátumot adunk meg
                        // (üres vagy nem egész szám), akkor FormatException kivételt dob.
                        db = int.Parse(txtDarabok[i].Text);

                        // azt is vizsgálni kell, hogy nem írtunk-e negatív értéket.
                        if (db <= 0) throw new Exception();

                        txtDarabok[i].BackColor = Color.White;
                        osszeg += ar * db;
                    }
                    catch (MissingFieldException)
                    {
                        MessageBox.Show("Nem választott méretet", "Hiba");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hibásan adta meg a darabszámot", "Hiba");
                        txtDarabok[i].BackColor = Color.Coral;
                        txtDarabok[i].Clear();
                    }
                }
            }

            if (!vankijeloles)
            {
                MessageBox.Show("Nincs kijelölve semmi", "Figyelmeztetés");
            }
            else
            {
                txtFizetendo.Text = osszeg + " Ft";
            }
        }

        private void AdatBeolvasas(StreamReader olvasoCsatorna)
        {
            pizzak.Clear(); // Clear the list before adding new items

            string sor;
            while ((sor = olvasoCsatorna.ReadLine()) != null)
            {
                string[] adatok = sor.Split(';'); // Assuming data is separated by ';'
                if (adatok.Length >= 3)
                {
                    string nev = adatok[0];
                    int arKicsi, arNagy;
                    if (int.TryParse(adatok[1], out arKicsi) && int.TryParse(adatok[2], out arNagy))
                    {
                        Pizza pizza = new Pizza(nev, arKicsi, arNagy);
                        pizzak.Add(pizza);
                    }
                }
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            txtFizetendo.Text = "";

            // Clear CheckBoxes, TextBoxes, and RadioButtons within pnlkozponti panel
            foreach (Control item in pnlkozponti.Controls)
            {
                // Clear CheckBoxes
                if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                // Clear TextBoxes
                else if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                // Check if the control has child controls (necessary for nested controls like RadioButtons in Panels/GroupBoxes)
                else if (item is Panel || item is GroupBox)
                {
                    foreach (Control child in item.Controls)
                    {
                        // Clear RadioButtons within Panels/GroupBoxes
                        if (child is RadioButton)
                        {
                            ((RadioButton)child).Checked = false;
                        }
                        // Clear TextBoxes within Panels/GroupBoxes
                        else if (child is TextBox)
                        {
                            ((TextBox)child).Clear();
                        }
                    }
                }
            }
        }

    }

}
