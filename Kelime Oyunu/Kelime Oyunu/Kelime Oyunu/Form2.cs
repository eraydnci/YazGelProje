using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Oyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            
            if (oyuncuAd.Text == "")
            {

                label1.Text = "OYUNCU ADI BOŞ GEÇİLEMEZ";

            }
            else
            {
                f1.oyuncuAdi = oyuncuAd.Text;
                Form1.ActiveForm.Visible = false;
                f1.Show();
            }
        }
    }
}
