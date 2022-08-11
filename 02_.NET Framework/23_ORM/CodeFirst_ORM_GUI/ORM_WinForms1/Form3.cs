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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            UpdateName(id, name);
        }
        public static void UpdateName(int id, string name)
        {
            var context = new EmployeeContext();
            Employee emp = context.Employee.Find(id);
            if (emp == null)
                MessageBox.Show("***Record not found***");
            else
            {
                emp.Name = name;

                context.SaveChanges();
                MessageBox.Show("***Updation Done***");
            }

        }
        public static void UpdateAge(int id, int age)
        {
            var context = new EmployeeContext();
            Employee emp = context.Employee.Find(id);
            if (emp == null)
                MessageBox.Show("***Record not found***");
            else
            {
                emp.Age = age;

                context.SaveChanges();
                MessageBox.Show("***Updation Done***");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            int age = Convert.ToInt32(textBox3.Text);
            UpdateAge(id, age);
        }
    }
}
