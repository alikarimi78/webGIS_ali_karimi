using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azimuth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X1 = double.Parse(textBox1.Text);
            double X2 = double.Parse(textBox2.Text);
            double Y1 = double.Parse(textBox3.Text);
            double Y2 = double.Parse(textBox4.Text);
            double D_X = X2 - X1;
            double D_Y = Y2 - Y1;
            double T = Math.Atan2(D_X, D_Y);
            T = (T * 180 / Math.PI);
          
            if (D_X < 0) 
            {
                T = 360 + T;
            }
            label5.Text = Convert.ToString(T);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
