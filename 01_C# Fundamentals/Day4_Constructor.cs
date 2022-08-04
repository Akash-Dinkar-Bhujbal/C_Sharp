
class test
{
    private int l, m;
    public void hello()
    {
        Console.WriteLine("Hello Function");
        Console.WriteLine(l+" "+m);
    }

    public test()
    {
        Console.WriteLine("Constructor calling");
    }

    public test(int x, int y)
    {
        l = x;
        m = y;
        Console.WriteLine("Object created");
    }

    public static void sam()
    {
        Console.WriteLine("I am static function");
    }
}

class Person
{
    public String Name;
    public string Address;
    public int Age;

    public void acceptData()
    {
        Console.WriteLine("Enter your name: ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter your address: ");
        Address = Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        Age = Convert.ToInt32(Console.ReadLine());
    }

    public void displayData()
    {
        Console.WriteLine("Name is "+Name+" Your address is "+Address+" Your age is "+Age);
    }
}

class Employee : Person
{
    public int Salary;
    public Employee()
    {
        Console.WriteLine("\n*****HANDLING WITH EMPLOYEE OBJECT*****");
    }
    public void acceptSalary()
    {
        Console.WriteLine("Enter your salary: ");
        Salary = Convert.ToInt32(Console.ReadLine());
    }

    public void displaySalary()
    {
        Console.WriteLine( "Your salary is " + Salary);
    }
}
class Student : Person
{
    public int RollNo;
    public Student()
    {
        Console.WriteLine("\n*****HANDLING WITH STUDENT OBJECT*****");
    }
    public void acceptRollNo()
    {
        Console.WriteLine("Enter your roll no: ");
        RollNo = Convert.ToInt32(Console.ReadLine());
    }

    public void displayRollNo()
    {
        Console.WriteLine("Your roll no is " + RollNo);
    }
}


class sample
{
    public static void Main(String[] args)
    {
        //test t1 = new test();
        //t1.hello();
        //test t2 = new test(1,6);
        //t2.hello();
        //test.sam();

        //Person p1 = new Person();
        //p1.acceptData();
        //p1.displayData();

        Employee e = new Employee();
        e.acceptData();
        e.acceptSalary();
        e.displayData();
        e.displaySalary();
       

        Student s = new Student();
        s.acceptData();
        s.acceptRollNo();
        s.displayData();
        s.displayRollNo();

    }
}
