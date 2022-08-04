using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORM_WinForms1
{
    public partial class Form5 : Form
    {
        string ConnString = @"Server=NSL-LTRG007\SQLEXPRESS2019;Database=satish;Integrated Security=True;";
        public Form5()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            /*METHOD 1: AOD*/
            //using (SqlConnection sqlCon = new SqlConnection(ConnString))
            //{
            //    sqlCon.Open();
            //    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM EMPLOYEE WHERE ID = "+id, sqlCon); //query
            //    DataTable dtbl = new DataTable(); //table
            //    sqlDa.Fill(dtbl); //fill the table
            //    dataGridView1.DataSource = dtbl;    //show 
            //}


            displayone(id);//MessageBox
        }

        // displayone
        public static void displayone(int id)
        {
            var context = new EmployeeContext();
            Employee emp = context.Employee.Find(id);
            if (emp == null)
                MessageBox.Show("not there");
            else
                MessageBox.Show(emp.Id + " " + emp.Name + " " + emp.Age);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*METHOD 1: AOD*/
            //using(SqlConnection sqlCon = new SqlConnection(ConnString))
            //{
            //    sqlCon.Open();
            //    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM EMPLOYEE",sqlCon); //query
            //    DataTable dtbl = new DataTable(); //table
            //    sqlDa.Fill(dtbl); //fill the table
            //    dataGridView1.DataSource = dtbl;    //show 
            //}

            var context = new EmployeeContext();
            dataGridView1.DataSource = context.Employee.ToList<Employee>();


        }
        //display all records 
        public static IEnumerable displayall()
        {
            var context = new EmployeeContext();
            IEnumerable<Employee> emp = context.Employee.ToList();

            //foreach (Employee o in emp)
            //{
            //    MessageBox.Show(o.Id + " " + o.Name + " " + o.Age+"\\n");
            //}
            return emp;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
