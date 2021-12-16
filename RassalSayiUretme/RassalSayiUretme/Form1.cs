using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RassalSayiUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rassal = new Random();
            textBox1.Text = rassal.Next().ToString();
            textBox2.Text = rassal.Next(50).ToString();
            textBox3.Text = rassal.Next(14, 25).ToString();
            byte[] dizi = new byte[3];
            rassal.NextBytes(dizi);
            foreach(byte eleman in dizi)
            {
                listBox1.Items.Add(eleman);
            }
        }
    }
}
