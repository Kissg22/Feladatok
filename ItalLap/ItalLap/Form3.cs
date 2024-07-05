using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItalLap
{


    public partial class Form3 : Form
    {
        private List<Image> kepek = new List<Image>();
        private int aktualisIndex;
        public Form3()
        {
            InitializeComponent();
        }
        internal void Atad(List<Image> kepek)
        {
            this.kepek = kepek;
            pictureBox1.Image = kepek[0]; // Kezdetben az első képet jelenítjük meg
            aktualisIndex = 0; // Kezdetben az első kép van kiválasztva
        }
        private void btnBal_Click(object sender, EventArgs e)
        {
            aktualisIndex--;
            if (aktualisIndex < 0)
                aktualisIndex = kepek.Count - 1;
            pictureBox1.Image = kepek[aktualisIndex];


        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            aktualisIndex++;
            if (aktualisIndex >= kepek.Count)
                aktualisIndex = 0;
            pictureBox1.Image = kepek[aktualisIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
