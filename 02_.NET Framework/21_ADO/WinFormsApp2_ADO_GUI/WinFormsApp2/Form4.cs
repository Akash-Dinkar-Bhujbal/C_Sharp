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


namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
            conn.Open();
            /*SELECT*/
            SqlCommand cmd = new SqlCommand("select * from Item ", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    ID.Items.Add(reader[0].ToString());
                }

                //reader.Close();
            }
            else
            {
                Console.WriteLine("No Data");
            }
            conn.Close();
        }

        private void ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(ID.SelectedItem);
            SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
            conn.Open();
            /*SELECT*/
            int id = Convert.ToInt32(ID.SelectedItem);
            SqlCommand cmd = new SqlCommand("select * from Item where ITEMID = @Id ", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    label4.Text = reader[1].ToString();
                    label5.Text = reader[2].ToString();
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
            int i = Convert.ToInt32(ID.SelectedItem);
            SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
            conn.Open();
            /*SELECT*/
            int id = Convert.ToInt32(ID.SelectedItem);
            SqlCommand cmd = new SqlCommand("select * from Item where ITEMID = @Id ", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            int price = 0;
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    price = Convert.ToInt32(reader[2].ToString());
                }

                //reader.Close();
            }
            else
            {
                Console.WriteLine("No Data");
            }
            int qty= Convert.ToInt32(textBox3.Text);
            int Total =price*qty;
            label6.Text = Total.ToString();
            conn.Close();
        }
    }
}
