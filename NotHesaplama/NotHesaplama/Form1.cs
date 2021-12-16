using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = Convert.ToDouble(textBox1.Text);
            if ((sonuc > 100 || sonuc < 0))
            {
                MessageBox.Show("Yanlış Not Girdiniz");           
            }
            else if ((sonuc>=60))
            {
                MessageBox.Show("Geçtiniz");
            }
            else
            {
                MessageBox.Show("Kaldınız");
            }

        }
    }
}
