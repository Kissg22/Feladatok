using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumRaadas
{
    public partial class Form1 : Form
    {
        private DateTime ma;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ma = DateTime.Now;
            lblAktualis.Text = ma.ToString("g");
        }
        private void btnErtekel_Click_1(object sender, EventArgs e)
        {
            DateTime datum = dtTmPckrDatum.Value;
            DateTime ido = dtTmPckrIdo.Value;
            DateTime talalkozo = datum.Date + ido.TimeOfDay;

            // Csak próbaképpen:
            // lblTalalkozo.Text = datum + "--" + ido;
            lblTalalkozo.Text = datum.ToShortDateString() + " " + ido.ToShortTimeString();


            if (talalkozo < ma)
            {
                lblErtekeles.Text = "Ezt lekésted";
            }
            else
            {
                TimeSpan hatraLevo = talalkozo - ma;
                lblErtekeles.Text = "Még " + hatraLevo.Days + " nap " +
                                    hatraLevo.Hours + " óra " +
                                    hatraLevo.Minutes + " perc " +
                                    hatraLevo.Seconds + " másodperc.";
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();
            }
            lblErtekeles.Text = "";
            lblTalalkozo.Text = "";
            dtTmPckrDatum.Value = DateTime.Now;
            dtTmPckrIdo.Value = DateTime.Now;
           

        }
    }
}
