using System.Data;
using System.Data.SqlClient;

namespace MVC_LoginForm.Models
{
    public class DB
    {
        public static int LoginCheck(Ad_login ad)
        {
            SqlConnection con = new SqlConnection("Data Source=NSL-LTRG007\\SQLEXPRESS2019;Initial Catalog=test3;Integrated Security=True");
            SqlCommand com = new SqlCommand("Ab_Login", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Admin_id", ad.Admin_id);
            com.Parameters.AddWithValue("@Password", ad.Ad_Password);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
                com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;
        }
    }
}
