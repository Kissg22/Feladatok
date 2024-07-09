using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static UszoVersenyMenuVezerelt.Form1;

namespace UszoVersenyMenuVezerelt
{
    public partial class EredmenyForm : Form
    {
        private List<Versenyzo> versenyzok;

        public EredmenyForm()
        {
            InitializeComponent();
        }

        public void EredmenyHirdetes(string uszasNem, int tav, List<Versenyzo> versenyzok)
        {
            label1.Text = $"{tav} méteres {uszasNem} eredménye:";

            this.versenyzok = new List<Versenyzo>(versenyzok);

            lstVersenyzok.Items.Clear(); 
            foreach (Versenyzo versenyzo in this.versenyzok)
            {
                lstVersenyzok.Items.Add(versenyzo);
            }
        }

        private void lstVersenyzok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Versenyzo versenyzo = (Versenyzo)lstVersenyzok.SelectedItem;
                txtRajtszam.Text = versenyzo.Rajtszam;
                txtOrszag.Text = versenyzo.Orszag;
                txtIdoEredmeny.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("mm:ss");
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás választás", "Hiba");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lstVersenyzok.Sorted = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lstVersenyzok.Sorted = false;
            lstVersenyzok.Items.Clear();

            Versenyzo temp;
            for (int i = 0; i < versenyzok.Count - 1; i++)
            {
                for (int j = i + 1; j < versenyzok.Count; j++)
                {
                    if (versenyzok[i].IdoEredmeny > versenyzok[j].IdoEredmeny)
                    {
                        temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }

            foreach (Versenyzo versenyzo in versenyzok)
            {
                lstVersenyzok.Items.Add(versenyzo);
            }
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            ZaszloForm zaszlo = new ZaszloForm();
            zaszlo.Fogad(versenyzok);
            zaszlo.ShowDialog();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Hide();
            versenyzok.Clear();
            lstVersenyzok.Items.Clear();
            txtRajtszam.Clear();
            txtOrszag.Clear();
            txtIdoEredmeny.Clear();
        }
    }
}
