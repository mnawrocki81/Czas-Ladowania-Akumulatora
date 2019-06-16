using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akumulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double T;
        private double c;
        private double i;

       

        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToDouble(tbPrądładowania.Text);
            c = Convert.ToDouble(tbPojemność.Text);
            T = 1.4 *c / i;

            double Tmin = T * 60;
            int h = (int)(Tmin / 60);
            int min = (int)(Tmin % 60);

            textBox3.Text = h.ToString() + " h  " + min.ToString() + " min.";
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            tbPojemność.Focus();


        }

        private void Czas_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbPrądładowania.Text = "";
            tbPojemność.Text = "";
            textBox3.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
