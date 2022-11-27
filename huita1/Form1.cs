namespace huita1
{
    public partial class Form1 : Form
    {
        static int n = 6;
        static int n1 = 4
            ;
        private double[,] array = new double[n, n];
        private double[] Wi = new double[n];
        double[] resultWeight = new double[n];


        public double[] VheshVi = new double[n1];

        public double[] BenzhVi = new double[n1];

        public double[] DinamicVi = new double[n1];

        public double[] ComfortVi = new double[n1];

        public double[] PriceVi = new double[n1];

        public double[] NadezhVi = new double[n1];

        public Form1()
        {
            Program.f1 = this; // теперь f1 будет ссылкой на форму Form1

            InitializeComponent();

            dataGridView1.Rows.Add("Внешний вид", 1, "0,25", "0,2", "0,2", "0,14", "0,14");
            dataGridView1.Rows.Add("Расход топлива", "", 1, "2", "0,33", "0,25", "0,2");
            dataGridView1.Rows.Add("Динамика", "", "", 1, "0,33", "0,33", "0,2");
            dataGridView1.Rows.Add("Комфорт", "", "", "", 1, "2", "0,5");
            dataGridView1.Rows.Add("Стоимость", "", "", "", "", 1, "0,2");
            dataGridView1.Rows.Add("Надежность", "", "", "", "", "", 1);
            dataGridView1.Rows.Add("Cуммы", "", "", "", "", "", "");
            dataGridView1.Rows.Add("Весовые коэффициенты", "", "", "", "", "", "");

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CalcButt_Click(object sender, EventArgs e)
        {
            string message = "Все данные записаны, заполните сравнение альтернатив";

            double[] result = new double[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    result[i] += Convert.ToDouble(dataGridView1.Rows[j].Cells[i + 1].Value);

                }

                dataGridView1.Rows[n].Cells[i + 1].Value = result[i];


            }
            for (int i = 0; i < n; i++)
            {

                Wi[i] = Math.Round((array[i, n - 1] / result[n - 1]), 2);
                dataGridView1.Rows[n + 1].Cells[i + 1].Value = Wi[i];
            }
            MessageBox.Show(message);
        }

        private void TableCompl_Click(object sender, EventArgs e)
        {
            string message = "Таблица дополнена";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0 + i; j < n; j++)
                {

                    array[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j + 1].Value);
                }

            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var value = 1.0 / array[j, i];
                    dataGridView1.Rows[i].Cells[j + 1].Value = Math.Round(value, 1);

                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0 + i; j < n; j++)
                {

                    array[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j + 1].Value);
                }

            }
            MessageBox.Show(message);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked != true) || (checkBox2.Checked != true) || (checkBox3.Checked != true) || (checkBox4.Checked != true) || (checkBox5.Checked != true) || (checkBox6.Checked != true))
            {
                string message = "Заполнены не все критерии!!!";
                MessageBox.Show(message);
            }
            else
            {
                Form8 results_form = new Form8
                {
                    Wi = Wi,
                    VheshVi = VheshVi,
                    BenzhVi=BenzhVi,
                    DinamicVi=DinamicVi,
                    ComfortVi=ComfortVi,
                    PriceVi=PriceVi,
                    NadezhVi=NadezhVi
                };
                results_form.Show(this);
            }
        }

        private void VneshVid_Click(object sender, EventArgs e)
        {
            Form2 vnesh_vid_form = new Form2
            {
                mass1 = Wi,
            };
            vnesh_vid_form.Show(this);
          

        }

        private void RashodBenza_Click(object sender, EventArgs e)
        {
            Form3 Rasxod_form = new Form3 { };
            Rasxod_form.Show(this);
        }

        private void Dinamica_Click(object sender, EventArgs e)
        {
            Form4 Dinamica_form = new Form4 { };
            Dinamica_form.Show(this);
        }

        private void Comfort_Click(object sender, EventArgs e)
        {
            {
                Form5 Comfort_form = new Form5 { };
                Comfort_form.Show(this);
            }
        }

        private void Price_Click(object sender, EventArgs e)
        {
            {
                Form6 Price_form = new Form6 { };
                Price_form.Show(this);
            }
        }

        private void Nadezh_Clicl(object sender, EventArgs e)
        {
            {
                Form7 Nadezh_form = new Form7 { };
                Nadezh_form.Show(this);

            }


        }

        
    }
}