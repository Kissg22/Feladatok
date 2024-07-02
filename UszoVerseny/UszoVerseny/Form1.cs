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

namespace UszoVerseny
{
    public partial class Form1 : Form
    {
        private List<Versenyzo> versenyzok;


        public Form1()
        {
            InitializeComponent();
            versenyzok = new List<Versenyzo>();
        }

        class Versenyzo
        {
            public string Rajtszam { get; private set; }
            public string Nev { get; private set; }
            public DateTime SzulDatum { get; private set; }
            public string Orszag { get; private set; }
            public TimeSpan IdoEredmeny { get; private set; }

            // constructor
            public Versenyzo(string rajtszam, string nev, DateTime szulDatum, string orszag, TimeSpan idoEredmeny)
            {
                this.Rajtszam = rajtszam;
                this.Nev = nev;
                this.SzulDatum = szulDatum;
                this.Orszag = orszag;
                this.IdoEredmeny = idoEredmeny;
            }

            public override string ToString()
            {
                return Nev;
            }



        }

        private void AdatBeolvasas()
        {
            StreamReader olvasoCsatorna = new StreamReader("uszok.txt");
            string adat = olvasoCsatorna.ReadLine();
            while (adat != null)
            {
                Feldolgoz(adat);
                adat = olvasoCsatorna.ReadLine();
            }
            olvasoCsatorna.Close();
        }

        private void Feldolgoz(string adat)
        {
            string rajtszam, nev, orszag;
            DateTime szulDatum;
            TimeSpan idoEredmeny;
            Versenyzo versenyzo;

            string[] tordelt = adat.Split(';');
            rajtszam = tordelt[0];
            nev = tordelt[1];
            szulDatum = DateTime.Parse(tordelt[2]);
            orszag = tordelt[3];
            idoEredmeny = TimeSpan.Parse("0:" + tordelt[4]);

            versenyzo = new Versenyzo(rajtszam, nev, szulDatum, orszag, idoEredmeny);
            versenyzok.Add(versenyzo); 
            lstVersenyzok.Items.Add(versenyzo);
        }


        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }

        private void lstVersenyzok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVersenyzok.SelectedIndex != -1)
            {
                Versenyzo versenyzo = versenyzok[lstVersenyzok.SelectedIndex];
                txtRajtszam.Text = versenyzo.Rajtszam;
                txtOrszag.Text = versenyzo.Orszag;
                txtIdoEredmeny.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("mm:ss.ff");
                txtEletKor.Text = (DateTime.Now.Year - versenyzo.SzulDatum.Year) + " év";
            }
        }


        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            lstVersenyzok.Items.Clear();
            AdatBeolvasas();
            btnAdatBe.Enabled = false;
            btnGyoztesIdo.Enabled = true;
        }

        private void btnGyoztesIdo_Click(object sender, EventArgs e)
        {
            TimeSpan min = (lstVersenyzok.Items[0] as Versenyzo).IdoEredmeny;


            foreach (var item in lstVersenyzok.Items)
            {
                if ((item as Versenyzo).IdoEredmeny < min)
                {
                    min = (item as Versenyzo).IdoEredmeny;
                }
            }

            txtGyoztesIdo.Text = new DateTime(min.Ticks).ToString("mm:ss.ff");
            rchTxtGyoztes.Clear();


            foreach (var item in lstVersenyzok.Items)
            {
                if ((item as Versenyzo).IdoEredmeny == min)
                {
                    rchTxtGyoztes.AppendText((item as Versenyzo).Nev + "\n");
                }
            }
        }
    }
}
