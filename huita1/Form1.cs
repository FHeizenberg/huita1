namespace huita1
{
    public partial class Form1 : Form
    {
        static int n = 6;
        private double[,] array = new double[n, n];
        private double[] Wi = new double[n];

        public Form1()
        {
            InitializeComponent();
            
            dataGridView1.Rows.Add("Внешний вид", 1, "0,25", "0,2", "0,2", "0,14", "0,14");
            dataGridView1.Rows.Add("Расход топлива", "", 1, "2", "0,33", "0,25", "0,2");
            dataGridView1.Rows.Add("Динамика", "", "", 1, "0,33", "0,33", "0,2");
            dataGridView1.Rows.Add("Комфорт", "", "", "", 1, "2", "0,5");
            dataGridView1.Rows.Add("Стоимость", "", "", "", "", 1, "0,2");
            dataGridView1.Rows.Add("Надежность", "", "", "", "", "", 1);
            dataGridView1.Rows.Add("Cуммы", "", "", "", "", "", "");
            dataGridView1.Rows.Add("Cуммы", "", "", "", "", "", "");

        }
        //int i=0;
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] result = new double[6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    result[i]+= Convert.ToDouble(dataGridView1.Rows[j].Cells[i + 1].Value);
  
                }

                dataGridView1.Rows[n].Cells[i+1].Value = result[i];
                

            }
            for (int i = 0; i < 6; i++)
            {

                Wi[i] = Math.Round((array [i, n - 1] / result[n-1]), 2);
                dataGridView1.Rows[n+1].Cells[i + 1].Value = Wi[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0 + i; j < 6; j++)
                {

                    array[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j + 1].Value);
                }

            }

            for (int i = 1; i < 6; i++)
            {
                for (int j = 0 ; j < i; j++)
                {
                   var value = 1.0 / array[j, i];
                    dataGridView1.Rows[i].Cells[j + 1].Value = Math.Round(value, 1);
                    
                }

            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0 + i; j < 6; j++)
                {

                    array[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j + 1].Value);
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 hui = new Form2
            {
                mass1 = Wi,
            };
            hui.Show(this);
        }
    }
}