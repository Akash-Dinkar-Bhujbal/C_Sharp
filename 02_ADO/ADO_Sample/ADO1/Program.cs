using System.Data.SqlClient;
class sample
{
    public static void Main()
    {
        SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
        ///*
        // NSL-LTRG007\\SQLEXPRESS2019 ==SERVER_NAME
        // INITIAL CATALOG=TEST1 == DATABASE_NAME
        // INTEGRATED SECURITY=TRUE == NOT CHECKING USERNAME & PASSWORD
        //    ALTERNATIVE: (USERNAME=XXX,PASSWORD=XXX)
        // */
        conn.Open();

        /*SELECT*/
        Console.WriteLine("Enter id whose record you want to display:");
        int id = Convert.ToInt32(Console.ReadLine());
        //SqlCommand cmd = new SqlCommand("select * from employee", conn);//<1
        //SqlCommand cmd = new SqlCommand("select * from employee where id = " + id, conn);//<2
        SqlCommand cmd = new SqlCommand("select * from employee where id = @ID", conn);//<2
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.Write(reader[0].ToString() + " ");//col1:id
            Console.Write(reader[1].ToString() + " ");//col2:name
            Console.WriteLine(reader[2].ToString());//col3:sal
        }
        ////--------------------------------------------------
        ////*Alternate Method 2 : */
        ////for(; reader.Read();)
        ////{
        ////    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
        ////}
        ///
        ////*Alternate Method 3 : */
        //if(reader.HasRows == true)
        //{
        //    while (reader.Read())
        //    {
        //        Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
        //    }
        //}
        //else
        //       Console.WriteLine("No Records present with this Id");
        conn.Close();
        //------------------------------------------------------------------------------------------
        ///*Insert*/
        //SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
        //conn.Open();
        //string query = "Insert Into Employee values (@id, @name, @salary)";
        //SqlCommand cmd = new SqlCommand(query, conn);

        /*Predefined parameters*/
        ////// Pass values to Parameters
        ////cmd.Parameters.AddWithValue("@id", 999);
        ////cmd.Parameters.AddWithValue("@name", "Karan");
        ////cmd.Parameters.AddWithValue("@salary", 8888);

        /*Alternate: User Defined*/
        //Console.WriteLine("Enter id");
        //int id = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Name");
        //string name = Console.ReadLine();
        //Console.WriteLine("Enter Salary");
        //int sal = Convert.ToInt32(Console.ReadLine());

        //cmd.Parameters.AddWithValue("@id", id);
        //cmd.Parameters.AddWithValue("@name", name);
        //cmd.Parameters.AddWithValue("@salary", sal);

        //cmd.ExecuteNonQuery();
        //conn.Close();
        //Console.WriteLine("Record inserted");

        ///*Update*/
        //SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
        //conn.Open();
        //string query = "Update Employee SET Name = @name, salary= @salary where id=@id";
        //SqlCommand cmd = new SqlCommand(query, conn);
        ////// Pass values to Parameters

        //Console.WriteLine("Enter id");
        //int id = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("New Name");
        //string name = Console.ReadLine();
        //Console.WriteLine("New Salary");
        //int sal = Convert.ToInt32(Console.ReadLine());


        //cmd.Parameters.AddWithValue("@id", id);
        //cmd.Parameters.AddWithValue("@name", name);
        //cmd.Parameters.AddWithValue("@salary", sal);

        //cmd.ExecuteNonQuery();
        //conn.Close();
        //Console.WriteLine("Record updated");


        /*Delete*/
        //SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
        //conn.Open();
        //string query = "Delete from Employee where id=@id";
        //SqlCommand cmd = new SqlCommand(query, conn);

        ////// Pass values to Parameters
        //Console.WriteLine("Enter id");
        //int id = Convert.ToInt32(Console.ReadLine());

        //cmd.Parameters.AddWithValue("@id", id);
        //cmd.ExecuteNonQuery();
        //conn.Close();
        //Console.WriteLine("Record deleted");

    }
}
