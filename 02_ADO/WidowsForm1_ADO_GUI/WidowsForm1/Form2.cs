using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WidowsForm1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
            conn.Open();
            /*SELECT*/
            int id = Convert.ToInt32(textBox1.Text);
            SqlCommand cmd = new SqlCommand("select * from employee where id = @ID", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    label2.Text = "Name = "+reader[1].ToString();
                    label3.Text = "Salary = "+reader[2].ToString();
                }
            }
            else
            {
                label2.Text = "0";
                label3.Text = "No Records present with this Id";
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
