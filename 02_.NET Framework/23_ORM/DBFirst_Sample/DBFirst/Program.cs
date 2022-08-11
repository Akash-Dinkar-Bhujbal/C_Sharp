/*
    microsoft.entityframeworkcore.sqlserver

    Microsoft.EntityFrameworkCore.Tools

    microsoft.entityframeworkcore.design

    microsoft.entityframeworkcore 

 PM> Scaffold-DbContext "Server=NSL-LTRG007\SQLEXPRESS2019;Database=TEST2;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

 */
using DBFirst.Models;

class Program
{
    public static void Main()
    {

        //Console.WriteLine("How mutch employee you want to enter:");
        //int no = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < no; i++)
        //{
        //    Console.WriteLine("Enter Id: ");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Name: ");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter salary: ");
        //    int sal = Convert.ToInt32(Console.ReadLine());

        //    string n = AddRecord(id,name, sal);
        //    Console.WriteLine(n);
        //}
        //string n = AddRecord(); 
        //Console.WriteLine(n);

        displayall();

        //string n = Update(1,"Suyog");

        //Console.WriteLine("Enter Id for Delete Emp: ");
        //int id = Convert.ToInt32(Console.ReadLine());
        //string n = Delete(id);
        //Console.WriteLine(n);

        //displayone(1);
    }

    public static string AddRecord(int id,string name, int sal)
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
}