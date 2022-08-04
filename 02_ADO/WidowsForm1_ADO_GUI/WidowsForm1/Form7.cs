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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
            conn.Open();
            /*SELECT*/
            int id = 1;
            SqlCommand cmd = new SqlCommand("select * from Quetion where id = @Id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    groupBox1.Text = reader[1].ToString();
                    radioButton1.Text = reader[2].ToString();
                    radioButton2.Text = reader[3].ToString();
                }
               
                //reader.Close();
            }
            else
            {
                Console.WriteLine("No Data");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
            conn.Open();
            /*SELECT*/
           
            SqlCommand cmd = new SqlCommand("select * from Quetion ", conn);
           // cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            //***********
            string ans = null;
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    ans = reader[4].ToString();
                }
            }
            if(radioButton1.Text == ans && radioButton1.Checked==true  )
            {
                MessageBox.Show("unmatched");
            }
            if (radioButton2.Text == ans && radioButton2.Checked == true)
            {
                MessageBox.Show("matched");
            }

            conn.Close();
        }
    }
}
