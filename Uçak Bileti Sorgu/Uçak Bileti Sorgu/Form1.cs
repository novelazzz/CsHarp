using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Bileti_Sorgu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " " + "Tarih: " + dateTimePicker1.Text + " " + "Saat: " + maskedTextBox1.Text + " " + "Ad Soyad: " + textBox1.Text + " " + "TC: " + maskedTextBox2.Text + " " + "Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kayıt Edildi");


        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }
    }
}
