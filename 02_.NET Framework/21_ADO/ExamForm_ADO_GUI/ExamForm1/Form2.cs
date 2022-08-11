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
        public static SqlConnection conn = new SqlConnection("SERVER=NSL-LTRG007\\SQLEXPRESS2019;INITIAL CATALOG=TEST1;INTEGRATED SECURITY=TRUE");
        public static SqlCommand cmd;
        public int id;
        public static int marks;
        public string ans;
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            id = 1;
            ans = "";
            marks = 0;
            conn.Open();
            /*SELECT*/
            
            cmd = new SqlCommand("select * from QUETION where ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    label1.Text = reader[1].ToString();// Question
                    radioButton1.Text = reader[2].ToString();// Option1
                    radioButton2.Text = reader[3].ToString();// Option2
                    ans = reader[4].ToString();// RA
                    label2.Text = "***Welcome RollNo " + Form1.RollNo + ", \nYour time start now!!!HURRY UP!!! ***";
                }
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Text == ans && radioButton1.Checked == true) || (radioButton2.Text == ans && radioButton2.Checked == true))
                marks++;

            id++;
            conn.Open();
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
                    ans = reader[4].ToString();// RA
                }
            }
            else
            {
                reader.Close();
                this.Close();
                MessageBox.Show("Marks: " + marks.ToString());
                Result();
                Form1 f1 = new Form1();
                f1.Show();
            }           
            conn.Close();

        }

        public static void Result()
        {
            string status = "Updated";
            try
            {
                string query = "UPDATE EXAM SET MARKS=@marks, STATUS =@status where ROLLNO = @RollNo";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RollNo", Form1.RollNo);
                cmd.Parameters.AddWithValue("@marks", marks);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Save operation not perform fine :"+ex);
            }
           
        }

    }
    
}   