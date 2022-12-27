using Neural_Networks;
using System.Collections.ObjectModel;

namespace AI_labs
{
    public partial class Form1 : Form
    {
        private const int n = 5;
        private const int N = n * n;
        static private List<CheckBox> w = new List<CheckBox>(); //input image
        private static List<CheckBox> x = new List<CheckBox>(); //output image
        public static List<List<CB>> s = new List<List<CB>>(); //trained images
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false; //disable button until there is images to train on
            óäàëèòüÂñåÎáğàçûToolStripMenuItem.Enabled = false; //disable button until there is images to train on
            lRate.Hide();
            tlRate.Hide();
            Pmin.Hide();
            lPot.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in result.Controls.OfType<CheckBox>())
                checkBox.Checked = false; //reset checkboxes in output matrix
            w = input.Controls.OfType<CheckBox>().ToList(); //read input image
            x = result.Controls.OfType<CheckBox>().ToList(); //read where to output result
            if (hopfield.Checked)
                Hopfield_network.restoreImage(x, iteration, iter); //restore image
            else
                SOM.recognize(N, Double.Parse(tlRate.Text), iteration, iter, Double.Parse(Pmin.Text));
        }

        private void äîáàâèòüÎáğàçûToolStripMenuItem_Click(object sender, EventArgs e) //add train images
        {
            IMAGE image = new IMAGE(); //for input images
            image.ShowDialog(this);
            image.Dispose();
            if (s.Count != 0) //if images were inputed
            {
                button1.Enabled = true; //enable button
                óäàëèòüÂñåÎáğàçûToolStripMenuItem.Enabled = true; //enable button
            }
        }

        private void óäàëèòüÂñåÎáğàçûToolStripMenuItem_Click(object sender, EventArgs e) //delete all train images
        {
            button1.Enabled = false; //disable button until there is images to train on
            óäàëèòüÂñåÎáğàçûToolStripMenuItem.Enabled = false; //disable button until there is images to train on
            s.Clear(); 
        }
        static public float[] initialize() //retrieving data from inputed image
        {
            int k = 0;
            float[] result = new float[N]; 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    CheckBox temp = w.Find(x => x.Name == "w" + i + j);
                    if (temp.Checked == true)
                        result[k] = 1;
                    else
                        result[k] = -1;
                    k++;
                }
            }
            return result;
        }
        static public float[,] initImages() //retrieving data from inputed train images
        {
            int k = 0, m;
            var result = new float[s.Count, N];
            foreach (List<CB> image in s)
            {
                m = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        CB temp = image.Find(x => x.CBName == "s" + i + j);
                        if (temp.CBCheckStatus == "Checked")
                            result[k, m] = 1;
                        else
                            result[k, m] = -1;
                        m++;
                    }
                }
                k++;
            }
            return result;
        }
        public static void showImage(float[] s) //show restored image
        {
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    CheckBox temp = x.Find(x => x.Name == "x" + i + j);
                    if (s[k] == 1)
                        temp.CheckState = CheckState.Checked;
                    else
                        temp.CheckState = CheckState.Unchecked;
                    k++;
                }
            }
        }

        private void hopfield_CheckedChanged(object sender, EventArgs e)
        {
            lRate.Hide();
            tlRate.Hide();
            Pmin.Hide();
            lPot.Hide();
        }

        private void som_CheckedChanged(object sender, EventArgs e)
        {
            lRate.Show();
            tlRate.Show();
            Pmin.Show();
            lPot.Show();
        }
    }
}