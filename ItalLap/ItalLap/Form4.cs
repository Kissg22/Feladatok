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
using static ItalLap.Form2; 

namespace ItalLap
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        internal void Kitolt(List<Form1.Ital> italok) 
        {
            richTextBoxSzamla.Clear();
            foreach (Form1.Ital item in italok) 
            {
                if (item.Mennyiseg != 0)
                {
                    richTextBoxSzamla.Text += item.ToString() + "\r\n";
                }
            }
        }
    }
}
