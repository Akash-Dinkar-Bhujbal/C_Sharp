using System;
using System.Data;
using System.Data.SqlClient;
namespace CALLOUTPARAMETER
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // connection string use
                using (SqlConnection conn = new SqlConnection("server=NSL-LTRG007\\SQLEXPRESS2019; database=TEST2; integrated security=TRUE"))
                {
                    //Create the command object
                    SqlCommand cmd = new SqlCommand()
                    {
                        CommandText = "abCreateStudent",
                        Connection = conn,// use previous connection object
                        CommandType = CommandType.StoredProcedure
                    };
                    //Set SqlParameter
                    //SqlParameter param1 = new SqlParameter
                    //{
                    //    ParameterName = "@Name", //Parameter name defined in stored procedure
                    //    SqlDbType = SqlDbType.NVarChar, //Data Type of Parameter
                    //    Value = "Test",// default
                    //    Direction = ParameterDirection.Input //Specify the parameter as input
                    //};
                    //add the parameter to the SqlCommand object
                    //cmd.Parameters.Add(param1);

                    Console.WriteLine("Enter Student Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter EmailId");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter Mobile Number");
                    string mob = Console.ReadLine();


                    /*Another approach to add input parameter*/
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
                    cmd.ExecuteNonQuery(); //INSERT , UPDATE , DELETE

                    Console.WriteLine("YOUR ACCOUNT IS CREATED AND THE NEW ID IS  : " + outParameter.Value.ToString());
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }

        }
    }
}