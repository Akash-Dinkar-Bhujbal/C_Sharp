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


namespace ExamForm1
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
        public int id;
        public static int marks = 0;
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
            /*SELECT*/
            id = 1;
            SqlCommand cmd = new SqlCommand("select * from QUETION where ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    label1.Text = reader[1].ToString();// Question
                    radioButton1.Text = reader[2].ToString();// Option1
                    radioButton2.Text = reader[3].ToString();// Option2
                }
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Quetion where ID = @id ", conn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            string ans = null;
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    ans = reader[4].ToString();//RA
                    if ((radioButton1.Text == ans && radioButton1.Checked == true)|| (radioButton2.Text == ans && radioButton2.Checked == true))
                        marks++;
                }
                reader.Close();

                id++;
                cmd = new SqlCommand("select * from Quetion where ID = @id ", conn);
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        label1.Text = reader[1].ToString();// Question
                        radioButton1.Text = reader[2].ToString();// Option1
                        radioButton2.Text = reader[3].ToString();// Option2
                    }
                }
                //conn.Close();
            }
            else
            {
                //conn.Open();
                MessageBox.Show("Marks: " + marks.ToString());
                Result();
                this.Close();
            }
            conn.Close();

        }

        public static void Result()
        {
            SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE EXAM SET MARKS=@marks, STATUS =@status where ROLLNO = @RollNo", conn);
            Form1 f = new Form1();
            cmd.Parameters.AddWithValue("@RollNo", f.RollNo);
            cmd.Parameters.AddWithValue("@marks", marks);
            cmd.Parameters.AddWithValue("@status", "Updated");
            cmd.ExecuteReader();
            conn.Close();
            
        }

    }
    
}