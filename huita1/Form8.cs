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

        public Form8(double[] wi, double[] vheshVi, double[] benzhVi, double[] dinamicVi, double[] comfortVi,
            double[] priceVi, double[] nadezhVi) : this()
        {
            Wi = wi;
            VheshVi = vheshVi;
            BenzhVi = benzhVi;
            DinamicVi = dinamicVi;
            ComfortVi = comfortVi;
            PriceVi = priceVi;
            NadezhVi = nadezhVi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n1; i++)
            {
                resmass[i] = Wi[0] * VheshVi[i] + Wi[1] * BenzhVi[i] + Wi[2] * DinamicVi[i] + Wi[3] * ComfortVi[i] +
                             Wi[4] * PriceVi[i] + Wi[5] * NadezhVi[i];
            }

            MessageBox.Show(resmass.Sum().ToString());

            textBox1.Text = resmass[0].ToString();
            textBox2.Text = resmass[1].ToString();
            textBox3.Text = resmass[2].ToString();
            textBox4.Text = resmass[3].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}