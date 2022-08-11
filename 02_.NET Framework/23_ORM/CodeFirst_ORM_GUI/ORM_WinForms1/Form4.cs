using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORM_WinForms1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Delete(id);
        }

        //deletion of records 
        public static void Delete(int id)
        {
            var context = new EmployeeContext();
            Employee emp = context.Employee.Find(id);
            if (emp == null)
                MessageBox.Show("***Record not found***");
            else
            {
                context.Employee.Remove(emp);
                context.SaveChanges();
                MessageBox.Show("***Record Deleted***");
            }

        }
    }
}
