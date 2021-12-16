using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerClickUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int enbuyuk = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            textBox1.Text = sayac.ToString();         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac > enbuyuk)
            {
                enbuyuk = sayac;
                Form1.ActiveForm.Text = "Su ana kadar en cok " + enbuyuk.ToString();
            }
            sayac = 0;
            textBox1.Text = sayac.ToString();
            timer1.Stop();
            button1.Enabled = true;
            timer1.Start();
        }
        private void timer1_Tick(object sender,EventArgs e)
        {
            button1.Enabled = false;
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            timer1.Start();
        }
    }
}
