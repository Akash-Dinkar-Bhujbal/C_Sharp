using System;
using System.Data.SqlClient;
using System.Data;

class A
{// This is Story : where we don't need Connection Open & Close
    static void Main(string[] args)
    {
        // Connection using Server, DatabaseName, Username & Password
        SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
        // Alternative of SqlCommand which fetch the data from table
        SqlDataAdapter da = new SqlDataAdapter("select * from employee", conn);
        // DataSet is memory area where data is store(offline)
        DataSet ds = new DataSet();
        // emp = Virtual view of table employee
        da.Fill(ds,"emp");
        foreach(DataRow dr in ds.Tables["emp"].Rows)
        {
            Console.WriteLine(dr[0].ToString()+" "+ dr[1].ToString()+" "+ dr[2].ToString());
        }
    }
}