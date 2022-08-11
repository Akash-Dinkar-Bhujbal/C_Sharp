using System;
using System.Data;
using System.Data.SqlClient;

namespace ProcedureCall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//MessageBoxButton
        {
            string connString = "Server =NSL-LTRG007\\SQLEXPRESS2019; Database = TEST2; INTEGRATED SECURITY = True;";
            //variables to store the query results
            int empID, empsalary;
            string empFirstName;

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //set stored procedure name
                    string spName = "EMP_INFO";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(spName, conn);


                    //Set SqlParameter - the employee id parameter value will be set from the command line
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@EMPID";
                    param1.SqlDbType = SqlDbType.Int;

                    //param1.Value = int.Parse(args[0].ToString());
                    //Console.WriteLine("Enter Employoee Id whose record you will need to display ");
                    //param1.Value = Convert.ToInt32(Console.ReadLine());
                    param1.Value = Convert.ToInt32(textBox1.Text);

                    //add the parameter to the SqlCommand object
                    cmd.Parameters.Add(param1);

                    //open connection
                    conn.Open();

                    //set the SqlCommand type to stored procedure and execute
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();

                    //Console.WriteLine(Environment.NewLine + "Retrieving data from database..." + Environment.NewLine);
                    //Console.WriteLine("Retrieved records:");

                    //check if there are records
                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            empID = dr.GetInt32(0);
                            empFirstName = dr.GetString(1);
                            empsalary = dr.GetInt32(2);


                            //display retrieved record
                            //Console.WriteLine("Id " + empID + "   " + "Name " + empFirstName + "  " + "Salary " + empsalary);
                            MessageBox.Show("Id " + empID + "   " + "Name " + empFirstName + "  " + "Salary " + empsalary);
                        }
                    }
                    else
                    {
                        //Console.WriteLine("No data found WITH THIS ID ");
                        MessageBox.Show("No data found WITH THIS ID ");
                    }

                    //close data reader
                    dr.Close();

                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                //Console.WriteLine("Exception: " + ex.Message);
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)//GridViewButton
        {
            try
            {
                SqlCommand cmd = new SqlCommand();// passing sql cmd
                SqlDataAdapter sda = new SqlDataAdapter();// for read the data
                DataSet ds = new DataSet();//create virtual data table
                string connString = "Server =NSL-LTRG007\\SQLEXPRESS2019; Database = TEST2; INTEGRATED SECURITY = True;";
                SqlConnection conn = new SqlConnection(connString);// for connect db
                conn.Open();//start
                cmd.Connection = conn;// connection pass kel cmd la
                cmd.CommandType = CommandType.StoredProcedure;// just for known it is store procedure
                cmd.CommandText = "EMP_INFO";//procedure name
                                             //****
                SqlParameter param1 = new SqlParameter();//input of procedure
                param1.ParameterName = "@EMPID";////para
                param1.SqlDbType = SqlDbType.Int;//it is int type
                param1.Value = Convert.ToInt32(textBox1.Text);//value come from textbox1
                cmd.Parameters.Add(param1);// cmd mdhe para pass kela
                                           //****
                sda = new SqlDataAdapter(cmd);//data adapter cmd pass keli
                sda.Fill(ds); //store/fill data in virtual table
                conn.Close();//close
                dataGridView1.DataSource = ds.Tables[0];
                // that is first table from dataset or virtual table

            }
            catch
            {
                MessageBox.Show("***WRONG INPUT***");
            }



        }
    }
}