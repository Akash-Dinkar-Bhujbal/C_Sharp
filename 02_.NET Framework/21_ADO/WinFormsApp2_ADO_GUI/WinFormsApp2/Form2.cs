using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = null;

            if (checkBox1.Checked)
                ans += "Car ";
             if (checkBox2.Checked)
                ans += "Cycle ";
             if (checkBox3.Checked)
                ans += "Bike ";


            if (ans == null)
                ans = "I don't have anything. Thank You";

            label2.Text = ans;
        }
    }
}
