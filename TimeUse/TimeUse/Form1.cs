using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye;

        private void button1_Click(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(textBox1.Text);
            if (saniye < 0)
                saniye = -1 * saniye;
            else if (saniye == 0)
                this.Close();
            this.Text = "Uygulama " + saniye.ToString() + " saniye sonra kapanacaktır";
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye < 4)
            {
                label1.Text = saniye.ToString();
            }
            if (saniye == 0)
            {
                this.Close();
            }
            else
            {
                this.Text = "Uygulama " + saniye.ToString() + " saniye sonra kapanacaktır";
            }

        }
    }
}
