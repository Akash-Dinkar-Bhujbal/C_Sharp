using CODEFIRSTCRUD;

class a
{
    public static void Main()
    {

        Console.WriteLine("How mutch employee you want to enter:");
        int no = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < no; i++)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string n = AddRecord(name, age);
            Console.WriteLine(n);
        }
        //string n = AddRecord(); 
        //Console.WriteLine(n);

        //displayall();

        //string n = Update(1,"Suyog");

        //string n = Delete();
        //Console.WriteLine(n);

        //displayone(1);
    }

    public static string AddRecord(string name, int age)
    {
        Employee emp = new Employee();
        //o.Id = 100; // Id is Auto-increment
        //o.Name = "Mihir";
        //o.Age = 22;
        //o.Name = "bISHANT";
        //o.Age = 24;
        emp.Name = name;
        emp.Age = age;
        var my = new EmployeeContext();
        my.Employee.Add(emp);
        my.SaveChanges(); 
        return "***Record Inserted***";
    }

    //display all records 
    public static void displayall()
    {
        var context = new EmployeeContext();
        IEnumerable<Employee> emp = context.Employee.ToList();
        // Interface IEnumerable

        foreach (Employee o in emp)
        {
            Console.Write(o.Id+" ");
            Console.Write(o.Name+" ");
            Console.WriteLine(o.Age);
        }
    }

    ///updatation of records : Update name
    public static string Update(int id, string name)
    {
        var context = new EmployeeContext();
        Employee emp = context.Employee.Find(id);
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
    public static string Delete()
    {
        var context = new EmployeeContext();
        Employee emp = context.Employee.Find(2);
        if (emp == null)
            return "***Record not found***";
        else
        {
            context.Employee.Remove(emp);
            context.SaveChanges();
            return "***Record Deleted***";
        }
        
    }

    // displayone
    public static void displayone(int id)
    {
        var context = new EmployeeContext();
        Employee emp = context.Employee.Find(id);
        if (emp == null)
            Console.WriteLine("not there");
        else
        {
            Console.Write(emp.Id + " ");
            Console.Write(emp.Name + " ");
            Console.WriteLine(emp.Age);
        }

    }

}