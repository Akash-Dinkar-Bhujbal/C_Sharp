using System.Data.SqlClient;

namespace MVC_JsonConnection.Models
{
    public class UserDataModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public int SaveDetails()
        {
            SqlConnection conn = new SqlConnection(GetConString.ConString());
            string query = "INSERT INTO Profile(Name, Age, City) values ('" + Name + "'," + Age + ",'"+City+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
