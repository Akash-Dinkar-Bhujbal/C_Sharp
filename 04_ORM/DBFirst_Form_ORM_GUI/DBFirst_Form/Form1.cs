using DBFirst_Form.Models;

namespace DBFirst_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//clear
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)//insert
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            int salary = Convert.ToInt32(textBox3.Text);
            AddRecord(id, name, salary);
        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            int salary = Convert.ToInt32(textBox3.Text);
            Update(id, name, salary);
        }

        private void button4_Click(object sender, EventArgs e)//delete
        {
            int id = Convert.ToInt32(textBox1.Text);
            Delete(id);
        }

        private void button5_Click(object sender, EventArgs e)//search
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = null;
            int sal = 0;
            displayone(id,ref name,ref sal);
            textBox2.Text = name;
            textBox3.Text = sal.ToString();
        }
        public static void AddRecord(int id, string name, int sal)
        {
            Emp emp = new Emp();
            emp.Id = id;
            emp.Name = name;
            emp.Salary = sal;
            var my = new TEST2Context();
            my.Emps.Add(emp);
            my.SaveChanges();
            MessageBox.Show("***Record Inserted***");
        }


        ///updatation of records : Update name
        public static void Update(int id, string name, int sal)
        {
            var context = new TEST2Context();
            Emp emp = context.Emps.Find(id);
            if (emp == null)
                MessageBox.Show("***Record not found***");
            else
            {
                emp.Name = name;
                emp.Salary = sal;
                context.SaveChanges();
                MessageBox.Show("***Updation Done***");
            }

        }
        //deletion of records 
        public static void Delete(int id)
        {
            var context = new TEST2Context();
            Emp emp = context.Emps.Find(id);
            if (emp == null)
                MessageBox.Show("***Record not found***");
            else
            {
                context.Emps.Remove(emp);
                context.SaveChanges();
                MessageBox.Show("***Record Deleted***");
            }

        }

        // displayone
        public static void displayone(int id, ref string name,ref int sal)
        {
            var context = new TEST2Context();
            Emp emp = context.Emps.Find(id);
            if (emp == null)
                MessageBox.Show("not there");
            else
            {
                //textbox1.id=emp.Id ;
                name = emp.Name;
                sal = (int)emp.Salary;
            }

        }

    }
}