using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonaccciSiraBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boyut = Convert.ToInt32(textBox1.Text);
            if (boyut > 2)
            {
                int[] fibon = new int[boyut];
                fibon[0] = 0;
                fibon[1] = 1;
                for (int i = 2; i < fibon.Length; i++)
                {
                    fibon[i] = fibon[i - 1] + fibon[i - 2];
                }
                MessageBox.Show("Serideki " + boyut.ToString() + " eleman = " + fibon[boyut - 1].ToString());
            }
            else
            {
                MessageBox.Show("UYARI!! 2'den Büyük bir tamsayı giriniz!!");
            }

        }
    }
}
