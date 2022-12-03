using AI_labs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Networks
{
    public partial class IMAGE : Form
    {
        public IMAGE()
        {
            InitializeComponent();
        }
        private void addImage_Click(object sender, EventArgs e) //add another image
        {
            List<CB> singularImage = new List<CB>();
            foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>()) 
            {
                CB temp = new CB();
                temp.CBName = checkBox.Name;
                temp.CBCheckStatus = checkBox.CheckState.ToString();
                singularImage.Add(temp);
                checkBox.Checked = false;
            }
            Form1.s.Add(singularImage);
            curNum.Text = (Int32.Parse(curNum.Text) + 1).ToString(); //show number of current image
        }

        private void button2_Click(object sender, EventArgs e) //end inputing images
        {
            bool flag = false;
            foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>()) //check if there is image to be added
            {
                if (checkBox.Checked == true)
                {
                    flag = true;
                    break;
                }
            }
            if (flag) //if there is
            {
                List<CB> singularImage = new List<CB>();
                foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
                {
                    CB temp = new CB();
                    temp.CBName = checkBox.Name;
                    temp.CBCheckStatus = checkBox.CheckState.ToString();
                    singularImage.Add(temp);
                    checkBox.Checked = false;
                }
                Form1.s.Add(singularImage);
            }
            this.Close();
        }
    }
}
