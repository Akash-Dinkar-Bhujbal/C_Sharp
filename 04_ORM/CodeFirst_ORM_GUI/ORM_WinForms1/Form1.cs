namespace ORM_WinForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);

            AddRecord(name, age);
        }

        public static void AddRecord(string name, int age)
        {
            Employee emp = new Employee();
            emp.Name = name;
            emp.Age = age;
            var my = new EmployeeContext();
            my.Employee.Add(emp);
            my.SaveChanges();
            //return "***Record Inserted***";
            MessageBox.Show("Employee account created");
        }
    }
}