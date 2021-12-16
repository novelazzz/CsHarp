using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                sayi = Math.Abs(sayi);
                int sonuc = 1;
                if (sayi != 0)
                {
                    for (int i = 2; i <= sayi; i++)
                    {
                        sonuc *= i;
                    }
                }
                label6.Text = sonuc.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                int kareToplam = 0;
                sayi = Math.Abs(sayi);
                for (int i = 1; i <= sayi; i++)
                {
                    kareToplam += i * i;
                }
                label6.Text = kareToplam.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                int Toplam = 0;
                sayi = Math.Abs(sayi);
                for (int i = 1; i <= sayi; i++)
                {
                    Toplam += i;
                }
                label6.Text = Toplam.ToString();

            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("lütfen seçim yapıniz");
            }
            else if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1,"Bu alan boş bırakılamaz")
            }

        }
    }
}
