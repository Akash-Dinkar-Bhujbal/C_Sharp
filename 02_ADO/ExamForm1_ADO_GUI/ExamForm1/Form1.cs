using System.Data.SqlClient;


namespace ExamForm1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
        SqlCommand cmd;
        SqlDataReader reader;
        public int RollNo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            /*SELECT*/
            RollNo = Convert.ToInt32(textBox1.Text);
            cmd = new SqlCommand("select * from EXAM where ROLLNO = @RollNo", conn);
            cmd.Parameters.AddWithValue("@RollNo", RollNo);
            reader = cmd.ExecuteReader();
            string status = null;

            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    status = reader[2].ToString();
                }
                if (status == "Updated")
                {
                    MessageBox.Show("Your exam is already done.");
                }else  if (status == "")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }

            }
            else
            {
                MessageBox.Show("Please check Roll No");
            }

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}