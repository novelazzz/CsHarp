using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Basic_Calculator 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double toplam = sayi1 + sayi2;
            textBox3.Text = toplam.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double fark = sayi1 - sayi2;
            textBox3.Text = fark.ToString();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double carpim = sayi1 * sayi2;
            textBox3.Text = carpim.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double bolum = sayi1 / sayi2;
            textBox3.Text = bolum.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }

        private void sinBut_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Sin(sayi1 * (Math.PI / 180));
            textBox3.Text = sonuc.ToString();

        }

        private void cosBut_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Cos(sayi1 * (Math.PI / 180));
            textBox3.Text = sonuc.ToString();

        }

        private void tanBut_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Tan(sayi1 * (Math.PI / 180));
            textBox3.Text = sonuc.ToString();

        }

        private void uzeriBut_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = Math.Pow(sayi1, sayi2);
            textBox3.Text = sonuc.ToString();


        }

        private void uzeri3But_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Pow(sayi1, 3);
            textBox3.Text = sonuc.ToString();

        }

        private void uzeri2But_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Pow(sayi1, 2);
            textBox3.Text = sonuc.ToString();

        }

        private void lnBut_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Log(sayi1);
            textBox3.Text = sonuc.ToString();

        }

        private void logBut_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Log10(sayi1);
            textBox3.Text = sonuc.ToString();

        }

        private void tersBut_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Pow(sayi1, -1);
            textBox3.Text = sonuc.ToString();

        }
    }
}
