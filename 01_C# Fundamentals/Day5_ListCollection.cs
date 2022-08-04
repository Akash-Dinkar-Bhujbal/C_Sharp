//using System.Collections.Generic;

class student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    //public int Id;
    //public string Name;
    //public int Marks;
}

class test
{
    public static void Main()
    {
        student s1 = new student();
        s1.Id = 101;
        s1.Name = "Akash";
        s1.Marks = 89;
        student s2 = new student();
        s2.Id = 102;
        s2.Name = "Ankit";
        s2.Marks = 69;
        List<student> stud = new List<student>();
        stud.Add(s1);
        stud.Add(s2);
        foreach(var i in stud)
        {
            Console.WriteLine("Student id: "+i.Id);
            Console.WriteLine("Student Name: " + i.Name);
            Console.WriteLine("Student Marks: " + i.Marks);
            Console.WriteLine("-----------------------");
        }
    }
}


//class Program
//{
//    static void Main()
//    {
//        //List<string> names = new List<string>();
//        //names.Add("sonoo");
//        //names.Add("Ankit");
//        //names.Add("Peter");
//        //names.Add("Irfan");

//        List<string> names = new List<string>() { "Sonoo", "Akash","Vimal","Baba"};

//        //Console.WriteLine("Enter number: ");
//        //int n = Convert.ToInt32(Console.ReadLine());

//        //for (int i = 0; i < n; i++)
//        //{
//        //    Console.WriteLine("Enter name: ");
//        //    names.Add(Console.ReadLine());
//        //}

//        //names.Insert(2,"Maya");

//        foreach (var i in names)
//        {
//            Console.WriteLine(i);
//        }

//        //Console.WriteLine("------------------------------");

//        //Console.WriteLine("Enter position: ");
//        //int p = Convert.ToInt32(Console.ReadLine());
//        //Console.WriteLine("Enter Name: ");
//        //string s = Console.ReadLine();
//        //names.Insert(p, s);
//        //// Remove, RemoveAt

//        //foreach (var i in names)
//        //{
//        //    Console.WriteLine(i);
//        //}

//        //Console.WriteLine("------------------------------");
//        //names.Remove("Maya");

//        //Console.WriteLine("After Removing Maya: ");

//        //foreach (var i in names)
//        //{
//        //    Console.WriteLine(i);
//        //}

//        //Console.WriteLine("------------------------------");
//        //names.RemoveAt(3);

//        //Console.WriteLine("After Removing 3rd Position: ");

//        //foreach (var i in names)
//        //{
//        //    Console.WriteLine(i);
//        //}

//        //Console.WriteLine("------------------------------");
//        //names.RemoveRange(2,1);

//        //Console.WriteLine("After Removing (Pos, rang) Position: ");

//        //foreach (var i in names)
//        //{
//        //    Console.WriteLine(i);
//        //}


//        //Console.WriteLine("------------------------------");
//        //names.Clear();

//        //Console.WriteLine("After Clear function: ");
//        ///*Clear all list*/

//        //int idx = names.IndexOf("Akash");
//        //Console.WriteLine("Index of Akash: " + idx);

//        //Console.WriteLine("Index of Akash: " + names.IndexOf("Baba",2));// If not present return -1

//        Console.WriteLine("------------------------------");
//        names.Sort();
//        for(int i = 0; i < names.Count(); i++)
//        {
//            Console.WriteLine(names[i]);
//        }

//    }
//}
        
