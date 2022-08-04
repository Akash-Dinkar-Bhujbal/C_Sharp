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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i.ToString());
                
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Even Odd in ListBox*/
            //int i  = Convert.ToInt32(listBox1.SelectedIndex+1);
            int i = Convert.ToInt32(listBox1.SelectedItem);
            if (i % 2 == 0)
                listBox2.Items.Add(i.ToString());
            else
                listBox3.Items.Add(i.ToString());
        }
    }
}
