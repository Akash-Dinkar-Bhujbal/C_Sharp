public class sample
{
    public static void Main()
    {
        //// Data source
        //string[] names = { "Bill", "Steve", "James", "Mohan"};

        //// LINQ Query
        ///Array myLinqQuery:
        //var myLinqQuery = from name in names
        //                  where name.Contains('a')
        //                  select name;

        //// Query execution
        //foreach(var name in myLinqQuery)
        //    Console.Write(name+" ");

        //List<int> integerList = new List<int>()
        //{
        //    1, 2, 3, 4, 5, 6, 7, 8,9, 10
        //};

        //var QuerySyntax = from obj in integerList
        //                  where obj > 5
        //                  select obj;

        //QuerySyntax : List/Array
        //foreach(var item in QuerySyntax)
        //{
        //    Console.WriteLine(item+" ");
        //}

        List<Student> studentList = new List<Student>()
        {
            new Student(){StudentID=1, StudentName="John", Age=13},
            new Student(){StudentID=2, StudentName="Moin", Age=21},
            new Student(){StudentID=3, StudentName="Bill", Age=18},
            new Student(){StudentID=4, StudentName="Ram", Age=20},
            new Student(){StudentID=5, StudentName="Ron", Age=15}
        };


        // LINQ Query Syntax to find out teenager students
        var teenAgerStudent = from s in studentList
                              where s.Age > 12 && s.Age < 20
                              select s;
        // Console.WriteLine(teenAgerStudent);
        foreach (var m in teenAgerStudent)
            Console.WriteLine(m.Age +" "+ m.StudentName +" "+ m.StudentID);
        ///////////////////////
        ///
        //var orderByResult = from s in studentList
        //                    orderby s.StudentName
        //                    select s;

        //var orderByDescendingResult = from s in studentList
        //                              orderby s.StudentName descending
        //                              select s;


        Console.WriteLine();
        var orderByResult = from s in studentList
                            orderby s.StudentName, s.Age
                            select new { s.StudentID, s.StudentName, s.Age };

        foreach (var m in orderByResult)
            Console.WriteLine(m.Age +"___"+ m.StudentName + "___" + m.StudentID);


    }
}

class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}