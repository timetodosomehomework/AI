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
            double leftBorder = Double.Parse(this.leftBorder.Text);
            double rightBorder = Double.Parse(this.rightBorder.Text);
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

            GA ga = new GA(expression, bitsOrNo, P0, populationCapacity, /*l,*/ t, T, P, lambda, alpha, selection, CO, Pm, eps, leftBorder, rightBorder, precision);
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
        }
    }
}