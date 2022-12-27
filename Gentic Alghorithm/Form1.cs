namespace Gentic_Alghorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            beeSet.Enabled = false;
            beeSet.Hide();
        }

        private void selection_SelectedIndexChanged(object sender, EventArgs e) //to disable stuff that not needed for this selction and enable that needed
        {
            switch (selection.SelectedIndex)
            {
                case 1:
                    //l.Enabled = false;
                    t.Enabled = false;
                    break;
                case 0:
                    //l.Enabled = false;
                    t.Enabled = true;
                    break;
                //case 2:
                //    l.Enabled = true;
                //    t.Enabled = false;
                //    break;
            }
        }

        private void CO_SelectedIndexChanged(object sender, EventArgs e) //to disable stuff that not needed for this crossingover and enable that needed
        {
            if (real.Checked) //if chosen real representation
                switch (CO.SelectedIndex)
                {
                    case 0:
                        lambda.Enabled = false;
                        alpha.Enabled = false;
                        P0.Enabled = false;
                        break;
                    case 1:
                        lambda.Enabled = true;
                        alpha.Enabled = false;
                        P0.Enabled = false;
                        break;
                    case 2:
                        lambda.Enabled = false;
                        alpha.Enabled = true;
                        P0.Enabled = false;
                        break;
                }
            else
                switch (CO.SelectedIndex)
                {
                    case 0:
                        lambda.Enabled = false;
                        alpha.Enabled = false;
                        P0.Enabled = false;
                        break;
                    case 1:
                        lambda.Enabled = false;
                        alpha.Enabled = false;
                        P0.Enabled = false;
                        break;
                    case 2:
                        lambda.Enabled = false;
                        alpha.Enabled = false;
                        P0.Enabled = true;
                        break;
                }
        }

        private void button1_Click(object sender, EventArgs e) //id-ing parameters and calling function with alghorithm
        {
            string expression = this.expression.Text;
            int n = Int32.Parse(this.n.Text);
            int populationCapacity = Int32.Parse(this.populationCapacity.Text);
            double T = Double.Parse(this.gap.Text);
            char selection = 'r';
            switch (this.selection.SelectedIndex)
            {
                case 1:
                    selection = 'r';
                    break;
                case 0:
                    selection = 'T';
                    break;
                case 2:
                    selection = 't';
                    break;
            }
            //double l = Double.Parse(this.l.Text);
            int t = Int32.Parse(this.t.Text);
            char CO = '2';
            if (real.Checked)
                switch (this.CO.SelectedIndex)
                {
                    case 0:
                        CO = '2';
                        break;
                    case 1:
                        CO = 'a';
                        break;
                    case 2:
                        CO = 'b';
                        break;
                }
            else
                switch (this.CO.SelectedIndex)
                {
                    case 0:
                        CO = '1';
                        break;
                    case 1:
                        CO = 't';
                        break;
                    case 2:
                        CO = 'u';
                        break;
                }
            double lambda = Double.Parse(this.lambda.Text);
            double alpha = Double.Parse(this.alpha.Text);
            double P = Double.Parse(this.P.Text);
            double Pm = Double.Parse(this.Pm.Text);
            double eps = Double.Parse(this.eps.Text);
            double precision = Double.Parse(this.precision.Text);
            double P0 = Double.Parse(this.P0.Text);
            bool bitsOrNo;
            if (real.Checked)
            {
                bitsOrNo = false;
                precision = 0.0;
            }
            else
                bitsOrNo = true;
            double[] leftBorder = new double[intervals.Rows.Count];
            for (int i = 0; i < intervals.Rows.Count; i++)
                leftBorder[i] = Double.Parse(intervals[1, i].Value.ToString());
            double[] rightBorder = new double[intervals.Rows.Count];
            for (int i = 0; i < intervals.Rows.Count; i++)
                rightBorder[i] = Double.Parse(intervals[2, i].Value.ToString());
            GA ga = new GA(expression, bitsOrNo, P0, populationCapacity, /*l,*/ t, T, P, lambda, alpha, selection, CO, Pm, eps, leftBorder, rightBorder, func, precision);
            ga.Alghorithm(n, this.y, listView1);
        }

        private void real_CheckedChanged(object sender, EventArgs e)
        {
            CO.Items.Clear();
            object[] objects = { "2-точечный кроссинговер", "јрифметический кроссинговер", "BLX-a кроссинговер" };
            CO.Items.AddRange(objects);
            CO.Text = "2-точечный кроссинговер";
            P0.Enabled = false;
            lambda.Enabled = false;
            alpha.Enabled = false;
            precision.Enabled = false;
            eps.Enabled = true;
        }

        private void bits_CheckedChanged(object sender, EventArgs e)
        {
            CO.Items.Clear();
            object[] objects = { "1-точечный кроссинговер", "2-точечный кроссинговер", "ќднородный кроссинговер" };
            CO.Items.AddRange(objects);
            CO.Text = "2-точечный кроссинговер";
            P0.Enabled = false;
            lambda.Enabled = false;
            alpha.Enabled = false;
            precision.Enabled = true;
            eps.Enabled = false;
        }

        private void findArgs_Click(object sender, EventArgs e)
        {
            string expression = this.expression.Text;
            int max = 0;
            for (int i = 0; i < expression.Length; i++) //find out how many arguments in function
                if (expression[i] == 'x')
                    if (Int32.Parse(expression[i + 1].ToString()) > max)
                        max = Int32.Parse(expression[i + 1].ToString());
            intervals.RowCount = max;
            for (int i = 0; i < max; i++)
                intervals[0, i].Value = "x" + (i + 1).ToString();
        }

        private void ga_CheckedChanged(object sender, EventArgs e)
        {
            beeSet.Enabled = false;
            beeSet.Hide();
            algSettings.Enabled = true;
            algSettings.Show();
        }

        private void ba_CheckedChanged(object sender, EventArgs e)
        {
            algSettings.Enabled = false;
            algSettings.Hide();
            beeSet.Enabled = true;
            beeSet.Show();
        }

        private void beeb_Click(object sender, EventArgs e)
        {
            int maxIter = Int32.Parse(this.maxIter.Text);
            string expression = bexp.Text;
            int scouts = Int32.Parse(this.scouts.Text);
            int elite = Int32.Parse(this.elite.Text);
            int promising = Int32.Parse(this.promising.Text);
            int eliteBees = Int32.Parse(belite.Text);
            int promisingBees = Int32.Parse(bpromising.Text);
            double[] leftBorder = new double[bintervals.Rows.Count];
            for (int i = 0; i < bintervals.Rows.Count; i++)
                leftBorder[i] = Double.Parse(bintervals[1, i].Value.ToString());
            double[] rightBorder = new double[bintervals.Rows.Count];
            for (int i = 0; i < bintervals.Rows.Count; i++)
                rightBorder[i] = Double.Parse(bintervals[2, i].Value.ToString());
            double[] eliteR = new double[rs.Rows.Count];
            for (int i = 0; i < rs.Rows.Count; i++)
                eliteR[i] = Double.Parse(rs[1, i].Value.ToString());
            double[] promisingR = new double[rs.Rows.Count];
            for (int i = 0; i < rs.Rows.Count; i++)
                promisingR[i] = Double.Parse(rs[2, i].Value.ToString());
            Bee_Alghorithm alghorithm = new Bee_Alghorithm(maxIter, expression, leftBorder, rightBorder, scouts, elite, promising, eliteBees, promisingBees, eliteR, promisingR, func);
            alghorithm.Alghorithm(y, listView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string expression = bexp.Text;
            int max = 0;
            for (int i = 0; i < expression.Length; i++) //find out how many arguments in function
                if (expression[i] == 'x')
                    if (Int32.Parse(expression[i + 1].ToString()) > max)
                        max = Int32.Parse(expression[i + 1].ToString());
            bintervals.RowCount = max;
            rs.RowCount = max;
            for (int i = 0; i < max; i++)
            {
                bintervals[0, i].Value = "x" + (i + 1).ToString();
                rs[0, i].Value = "x" + (i + 1).ToString();
            }
        }
    }
}