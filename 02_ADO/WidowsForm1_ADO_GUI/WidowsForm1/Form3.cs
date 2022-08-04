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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///*Insert*/
            SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
            conn.Open();
            string query = "Insert Into Employee values (@id, @name, @salary)";
            SqlCommand cmd = new SqlCommand(query, conn);

            //// Pass values to Parameters

            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            int sal = Convert.ToInt32(textBox3.Text);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@salary", sal);

            cmd.ExecuteNonQuery();
            conn.Close();
            label4.Text="***Record inserted***";
        }
    }
}
