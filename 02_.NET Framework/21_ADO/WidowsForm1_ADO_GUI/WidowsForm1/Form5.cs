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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Delete*/
            SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
            conn.Open();
            

            //*****************
            //// Pass values to Parameters
            int id = Convert.ToInt32(textBox1.Text);
            SqlCommand cmd1 = new SqlCommand("select * from employee where id = @ID", conn);
            cmd1.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd1.ExecuteReader();
           
           
            if (reader.HasRows == true)
            {
                reader.Close();
                string query = "Delete from Employee where id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");
            }
            else
            {
                MessageBox.Show("ID not found");
            }
            conn.Close();

        }
    }
}
