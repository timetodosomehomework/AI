using Neural_Networks;
using System.Collections.ObjectModel;

namespace AI_labs
{
    public partial class Form1 : Form
    {
        private List<CheckBox> w = new List<CheckBox>(); //input image
        private List<CheckBox> x = new List<CheckBox>(); //output image
        public static List<List<CB>> s = new List<List<CB>>(); //trained images
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false; //disable button until there is images to train on
            óäàëèòüÂñåÎáğàçûToolStripMenuItem.Enabled = false; //disable button until there is images to train on
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in result.Controls.OfType<CheckBox>())
                checkBox.Checked = false; //reset checkboxes in output matrix
            w = input.Controls.OfType<CheckBox>().ToList(); //read input image
            x = result.Controls.OfType<CheckBox>().ToList(); //read where to output result
            Hopfield_network.initialize(w); //initialize inputed image
            Hopfield_network.restoreImage(x, iteration); //restore image
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
                Hopfield_network.initImages(s);
            }
        }

        private void óäàëèòüÂñåÎáğàçûToolStripMenuItem_Click(object sender, EventArgs e) //delete all train images
        {
            button1.Enabled = false; //disable button until there is images to train on
            óäàëèòüÂñåÎáğàçûToolStripMenuItem.Enabled = false; //disable button until there is images to train on
            s.Clear(); 
        }
    }
}