namespace TSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saSet.Enabled = false;
            saSet.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //create matrix in gridview
        {
            try
            {
                int n = Int32.Parse(textBox1.Text);
                dataGridView1.RowCount = n;
                dataGridView1.ColumnCount = n;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].Width = 50;
                    dataGridView1.Columns[i].Name = (i + 1).ToString();
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
            catch
            {
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = 1;
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            for (int i = 0; i < e.Row.Cells.Count; i++)
                e.Row.Cells[i].Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] D = new double[Int32.Parse(textBox1.Text), Int32.Parse(textBox1.Text)];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    D[i, j] = Double.Parse(dataGridView1[j, i].Value.ToString());
            if (ant.Checked)
            {
                int maxIter = Int32.Parse(iter.Text);
                int ants = Int32.Parse(this.ants.Text);
                int eants = Int32.Parse(this.eants.Text);
                double alpha = Double.Parse(this.alpha.Text);
                double beta = Double.Parse(this.beta.Text);
                double Q = Double.Parse(phe.Text);
                double p = Double.Parse(pevap.Text);
                Ant_Alghorithm alghorithm = new Ant_Alghorithm(D, alpha, beta, eants, Q, ants, p);
                alghorithm.algorithm(maxIter, path, length);
            }
            else
            {
                int maxIter = Int32.Parse(saMaxIter.Text);
                double initT = Double.Parse(this.initT.Text);
                double alpha = Double.Parse(alp.Text);
                Simulated_Annealing.alghorithm(D, initT, maxIter, alpha, path, length);
            }
        }

        private void ant_CheckedChanged(object sender, EventArgs e)
        {
            saSet.Enabled = false;
            saSet.Hide();
            antsSet.Enabled = true;
            antsSet.Show();
        }

        private void sa_CheckedChanged(object sender, EventArgs e)
        {
            antsSet.Enabled = false;
            antsSet.Hide();
            saSet.Enabled = true;
            saSet.Show();
        }
    }
}