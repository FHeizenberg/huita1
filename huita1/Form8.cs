using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace huita1
{
    public partial class Form8 : Form
    {

        static int n = 6;
        static int n1 = 4;

        public double[] Wi = new double[n];

        public double[] VheshVi = new double[n1];

        public double[] BenzhVi = new double[n1];

        public double[] DinamicVi = new double[n1];

        public double[] ComfortVi = new double[n1];

        public double[] PriceVi = new double[n1];

        public double[] NadezhVi = new double[n1];

        public double[] resmass = new double[n1];

        public Form8()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n1; i++)
            {
                double res = 0;
                for (int j = 0; j < n1; j++)
                {
                    res = (Wi[j] * VheshVi[i]) + (Wi[j] * BenzhVi[i]) + (Wi[j] * DinamicVi[i]) + (Wi[j] * ComfortVi[i]) + (Wi[j] * PriceVi[i]) + (Wi[j] * NadezhVi[i]);
                }
                resmass[i] = res;
            }
            textBox1.Text = resmass[0].ToString();
            textBox2.Text = resmass[1].ToString();
            textBox3.Text = resmass[2].ToString();
            textBox4.Text = resmass[3].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
