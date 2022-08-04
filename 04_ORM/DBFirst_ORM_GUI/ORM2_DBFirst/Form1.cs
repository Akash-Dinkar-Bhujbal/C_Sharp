namespace ORM2_DBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            int salary = Convert.ToInt32(textBox3.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public static string AddRecord(int id, string name, int sal)
        {
            Emp emp = new Emp();
            emp.Id = id;
            emp.Name = name;
            emp.Salary = sal;
            var my = new TEST2Context();
            my.Emps.Add(emp);
            my.SaveChanges();
            return "***Record Inserted***";
        }

        //display all records 
        public static void displayall()
        {
            var context = new TEST2Context();
            IEnumerable<Emp> emp = context.Emps.ToList();

            foreach (Emp o in emp)
            {
                Console.Write(o.Id + " ");
                Console.Write(o.Name + " ");
                Console.WriteLine(o.Salary);
            }
        }

        ///updatation of records : Update name
        public static string Update(int id, string name)
        {
            var context = new TEST2Context();
            Emp emp = context.Emps.Find(id);
            if (emp == null)
                return "***Record not found***";
            else
            {
                emp.Name = name;

                context.SaveChanges();
                return "***Updation Done***";
            }

        }
        //deletion of records 
        public static string Delete(int id)
        {
            var context = new TEST2Context();
            Emp emp = context.Emps.Find(id);
            if (emp == null)
                return "***Record not found***";
            else
            {
                context.Emps.Remove(emp);
                context.SaveChanges();
                return "***Record Deleted***";
            }

        }

        // displayone
        public static void displayone(int id)
        {
            var context = new TEST2Context();
            Emp emp = context.Emps.Find(id);
            if (emp == null)
                Console.WriteLine("not there");
            else
            {
                Console.Write(emp.Id + " ");
                Console.Write(emp.Name + " ");
                Console.WriteLine(emp.Salary);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}