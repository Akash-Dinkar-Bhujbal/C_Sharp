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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //public object Reader { get; private set; }

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
                        CommandText = "DISP",
                        Connection = conn,// use previous connection object
                        CommandType = CommandType.StoredProcedure
                    };

                    int Id = Convert.ToInt32(textBox4.Text);
                    

                    cmd.Parameters.AddWithValue("@A", Id);
                    

                    ////Set SqlParameter
                    //SqlParameter outParameter = new SqlParameter
                    //{
                    //    ParameterName = "@Id", //Parameter name defined in stored procedure
                    //    SqlDbType = SqlDbType.Int, //Data Type of Parameter
                    //    Direction = ParameterDirection.Output //Specify the parameter as ouput
                    //};
                    ////add the parameter to the SqlCommand object
                    //cmd.Parameters.Add(outParameter);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows == true)//will check rows from table with the help of procedure
                    {
                        while (reader.Read())
                        {
                            label1.Text = reader.GetString(1);
                            label2.Text = reader.GetString(2);
                            label3.Text = reader.GetString(3);
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO RECORD PRESENT ");
                    }
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
