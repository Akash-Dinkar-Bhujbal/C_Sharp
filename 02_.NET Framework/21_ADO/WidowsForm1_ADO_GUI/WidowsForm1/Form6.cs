using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidowsForm1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            int score = 0;
            if (radioButton1.Checked == true)
            {
                score++;
            }

            if (radioButton3.Checked == true)
            {
                score++;
            }
            if (radioButton5.Checked == true)
            {
                score++;
            }
            if (score == 0)
                label1.Text = "FAIL";
            else
                label1.Text = "SCORE = "+score.ToString()+"/3";

        }
    }
}
