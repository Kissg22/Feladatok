using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ItalLap.Form1;

namespace ItalLap
{
    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();
            
        }

        private List<Ital> italok = new List<Ital>();
        private List<CheckBox> chkBoxok = new List<CheckBox>();
        private List<TextBox> txtBoxok = new List<TextBox>();

        private int bal = 10, fent = 10, chkXMeret = 250, chkYTav = 40, txtXmeret = 30, txtYmeret = 17, xkoz = 100;

        private void fizetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Ital item in italok)
            {
                item.Fizet();
            }
        }

        private void szamlaMenu_Click(object sender, EventArgs e)
        {
            Form4 szlaForm = new Form4();
            szlaForm.Kitolt(italok);
            szlaForm.ShowDialog();
        }

        private void btnRendel_Click(object sender, EventArgs e)
        {
            bool valasztott = false;
            bool vanHibasAdag = false;
            int mennyiseg = 0;

            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    valasztott = true;

                    try
                    {
                        mennyiseg = int.Parse(txtBoxok[i].Text);

                        if (mennyiseg <= 0 || mennyiseg > maxAdag)
                        {
                            throw new Exception();
                        }

                        italok[i].Rendel(mennyiseg);
                        txtBoxok[i].BackColor = Color.White;
                        chkBoxok[i].Checked = false;
                        txtBoxok[i].Clear();
                    }
                    catch (Exception)
                    {
                        txtBoxok[i].BackColor = Color.Salmon;
                        vanHibasAdag = true;
                    }
                }
            }

            if (!valasztott)
            {
                MessageBox.Show("Semmit sem választott!", "Figyelmeztetés");
            }
            else if (vanHibasAdag)
            {
                MessageBox.Show("A pirossal jelzett adagok hibásak", "Figyelmeztetés");
            }
        }

        private int maxAdag = 999;

        internal void ArlapotIr(List<Ital> italok)
        {
            pnlValasztek.Controls.Clear();
            chkBoxok.Clear();
            txtBoxok.Clear();
            this.italok = italok;

            CheckBox chkBox;
            TextBox txtBox;
            Label lbl;

            for (int i = 0; i < italok.Count; i++)
            {
                chkBox = new CheckBox();
                txtBox = new TextBox();
                lbl = new Label();

                // chkBox
                chkBox.Location = new Point(bal, fent + i * chkYTav);
                chkBox.Size = new Size(chkXMeret, txtYmeret);
                chkBox.Text = italok[i].Arlistaba();
                chkBox.TextAlign = ContentAlignment.MiddleLeft;

                // txtBox
                txtBox.Location = new Point(bal + chkXMeret + xkoz, fent + i * chkYTav);
                txtBox.Size = new Size(txtXmeret, txtYmeret);

                // lbl
                lbl.AutoSize = true;
                lbl.Location = new Point(bal + chkXMeret + txtXmeret + xkoz, fent + i * chkYTav);
                lbl.Text = "adag";

                // Add controls to panel
                pnlValasztek.Controls.Add(chkBox);
                pnlValasztek.Controls.Add(txtBox);
                pnlValasztek.Controls.Add(lbl);

                // Add to lists
                chkBoxok.Add(chkBox);
                txtBoxok.Add(txtBox);

                pnlValasztek.Controls.Add(chkBox);
                pnlValasztek.Controls.Add(txtBox);
                pnlValasztek.Controls.Add(lbl);
            }
        }

       


    }
}
