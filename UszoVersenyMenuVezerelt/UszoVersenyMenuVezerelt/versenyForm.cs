using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static UszoVersenyMenuVezerelt.Form1;

namespace UszoVersenyMenuVezerelt
{
    public partial class VersenyForm : Form
    {
        private List<Versenyzo> versenyzok;
        private int sorSzam;
        private bool versenyInditva = false; 

        public VersenyForm()
        {
            InitializeComponent();


            InitializeUszasNemek();


            dateTimePicker1.Value = new DateTime(2000, 1, 1, 0, 0, 0);

            btnVerseny.Enabled = true; 
            btnKovetkezo.Enabled = false; 

            sorSzam = 0;
        }
        private void InitializeUszasNemek()
        {
            comboBox1.SelectedIndex = 0;
        }

        public void Fogad(List<Versenyzo> versenyzok)
        {
            this.versenyzok = versenyzok;
            VersenyzoBeallitas();
        }

        private void VersenyzoBeallitas()
        {
            if (sorSzam < versenyzok.Count)
            {
                txtVersenyzo.Text = versenyzok[sorSzam].ToString();
                dateTimePicker1.Value = new DateTime(2000, 1, 1, 0, 0, 0); // DateTimePicker alaphelyzetbe állítása
            }
            else
            {
                MessageBox.Show("Nincs több versenyző!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnVerseny_Click(object sender, EventArgs e)
        {

        }

        private void btnKovetkezo_Click(object sender, EventArgs e)
        {
            // Következő gomb megnyomásakor
            TimeSpan idoEredmeny = dateTimePicker1.Value - new DateTime(2000, 1, 1, 0, 0, 0);
            versenyzok[sorSzam].Versenyez(idoEredmeny);
            sorSzam++;
            VersenyzoBeallitas();

        }

        // Publikus getterek
        public List<Versenyzo> Versenyzok { get { return versenyzok; } }
        public int Tav { get { return (int)numericUpDown1.Value; } }
        public string UszasNem { get { return comboBox1.Text; } }

        private void btnVerseny_Click_1(object sender, EventArgs e)
        {
           
            if (!versenyInditva)
            {
                comboBox1.Enabled = false; 
                numericUpDown1.Enabled = false;

                btnVerseny.Enabled = false;
                btnKovetkezo.Enabled = true; 

                versenyInditva = true;
            }
        }
    }
}
