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


namespace ProcedureCallwithOutput_ADO_GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // connection string use
                using (SqlConnection conn = new SqlConnection("server=NSL-LTRG007\\SQLEXPRESS2019; database=TEST2; integrated security=TRUE"))
                {
                    //Create the command object
                    SqlCommand cmd = new SqlCommand()
                    {
                        CommandText = "abUpdateStudent",
                        Connection = conn,// use previous connection object
                        CommandType = CommandType.StoredProcedure
                    };

                    string name = textBox1.Text;
                    string email = textBox2.Text;
                    string mob = textBox3.Text;
                    int id = Convert.ToInt32(textBox4.Text);

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Mobile", mob);

                    //Set SqlParameter
                    SqlParameter outParameter = new SqlParameter
                    {
                        ParameterName = "@Id", //Parameter name defined in stored procedure
                        SqlDbType = SqlDbType.Int, //Data Type of Parameter
                        Direction = ParameterDirection.Output //Specify the parameter as ouput
                    };
                    //add the parameter to the SqlCommand object
                    cmd.Parameters.Add(outParameter);

                    conn.Open();
                    cmd.ExecuteNonQuery(); //UPDATE

                    MessageBox.Show("ID IS UPDATED : " + outParameter.Value.ToString());
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OOPs, something went wrong." + ex);
            }
        }
    }
}
