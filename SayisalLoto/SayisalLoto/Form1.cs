using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] loto = new int[6];
            Random rassal = new Random();
            loto[0] = rassal.Next(1,50);
            listBox1.Items.Add(loto[0]);
            for(int i = 1; i< loto.Length; i++)
            {
                loto[i] = rassal.Next(1, 50);
                for (int j = 0; j < i; j++)
                {
                    if (loto[i] == loto[j])
                    {
                        loto[i] = rassal.Next(1, 50);
                        j = -1;
                    }
                }
                listBox1.Items.Add(loto[i]);
            }

        }
    }
}
