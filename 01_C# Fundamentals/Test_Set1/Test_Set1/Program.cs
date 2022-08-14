/* 1. Write a C# Sharp program that takes a number as input and print its multiplication table.
 use while loop
 Test Data:
 Enter the number: 5
 Expected Output:
 5 * 1 = 5
 5 * 2 = 10
 5 * 3 = 15....5 * 10 = 50  */


//public class Sample
//{
//    public static void Main(string[] args)
//    {
//        int temp = 1;
//        Console.WriteLine("Enter the number: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        while (temp <= 10)
//        {
//            Console.WriteLine("{0} * {1} = {2}", n, temp, n * temp);
//            temp++;
//        }

//    }
//}
/*--------------------------------------------------------------------------*/

/* 2. Write a C# program to count a specified number in a given array of integers.
 use while loop
 Input an integer: 5
 Sample Output
 Number of 5 present in the said array: 2   */

//public class Sample
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 1, 5, 3, 5, 4 };//array
//        int temp = arr.Length - 1, count = 0;
//        Console.WriteLine("Enter the number: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        while (temp >= 0)
//        {
//            if (arr[temp] == n)
//            {
//                count++;
//            }
//            temp--;
//        }
//        Console.WriteLine("Number of {0} present in the said array: {1}",n ,count);
//    }
//}

/*--------------------------------------------------------------------------*/
/* 3. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
 use any loop

 *
 **
 ***
 ****   */

//public class Sample
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the number: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        for (int i = 1; i <= n; i++)
//        {
//            for (int j = 1; j <= i; j++)
//            {
//                Console.Write("* ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
/*--------------------------------------------------------------------------*/
/* 4. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
 Test Data :
 Input the number or terms :5
 Expected Output :
 9 99 999 9999 99999
 The sum of the series = 111105 */

//public class Sample
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the number: ");
//        int n = Convert.ToInt32(Console.ReadLine());//5
//        Console.Write("Series : ");
//        int s = 0, sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            s = s * 10 + 9;
//            Console.Write(s + " ");
//            sum += s;
//        }
//        Console.WriteLine();
//        Console.WriteLine("The sum of the series = {0}", sum);//<--
//    }
//}
/*--------------------------------------------------------------------------*/
/* 5. Write a program in C# Sharp to display the number in reverse order.
 Test Data :
 Input a number: 12345
 Expected Output :
 The number in reverse order is : 54321 */

//public class Sample
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the number: ");
//        int n = Convert.ToInt32(Console.ReadLine());//12345
//        int rem = 1, rev = 0;

//        while (n > 0)
//        {
//            rem = n % 10;//lastDigit
//            n = n / 10;//Without_lastDigit
//            rev = (rev * 10) + rem;//reverseNo
//        }

//        Console.WriteLine("The number in reverse order is : " + rev);//54321
//    }
//}
/*--------------------------------------------------------------------------*/
/* 6. Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
 Test Data :
 Input Base number: 3
 Input the Exponent : 2
 Expected Output :
 So, the number 3 ^ (to the power) 2 = 9    */

//public class Sample
//{
//    public static int fun(int b, int e)
//    {
//        int result = 1;
//        for (int i = 1; i <= e; i++)
//        {
//            result *= b;
//        }
//        return result;
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the Base number: ");
//        int b = Convert.ToInt32(Console.ReadLine());//3
//        Console.WriteLine("Enter the Exponent number: ");
//        int e = Convert.ToInt32(Console.ReadLine());//2
//        Console.WriteLine("{0} ^ {1} = {2}", b, e, fun(b, e));//3^2
//    }
//}
/*--------------------------------------------------------------------------*/
/* 7. Write a program in C# Sharp to create a function to check whether a number is prime or not.
 Test Data :
 Input a number : 31
 Expected Output :
 31 is a prime number   */

//public class Sample
//{
//    public static void fun(int n)
//    {
//        int flag = 0;
//        for (int i = 2; i < n / 2; i++)
//        {
//            if (n % i == 0)
//            {
//                flag = 1;
//                break;
//            }
//        }
//        if (n < 2)
//            Console.WriteLine(n + " is neither Prime nor Composite");
//        else if (flag == 0)
//            Console.WriteLine(n + " is a Prime number");
//        else
//            Console.WriteLine(n + " is a Composite number");
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the number: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        fun(n);
//    }
//}
/*--------------------------------------------------------------------------*/
/* 8. Create a new project, and include in it the class Person which has a property age 
  and a function greet and setAge .

     Create a class "Student" and another class "Teacher", both descendants of "Person".
     The class "Student" will have a public method "GoToClasses", which will write on screen "I’m going to class."
     
     The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begins". 
     Also, it will have a private attribute "subject", a string.

     The class Person must have a method "SetAge (int n)" which will indicate the value of their age (eg, 20 years old).
     The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number).

     You must create another test class called "StudentAndTeacherTest" that will contain "Main" and:
         Create a Person and make it say hello
         Create a student, set his age to 21, tell him to Greet and display his age
         Create a teacher, 30 years old, ask him to say hello and then explain. */


//class Person
//{
//    public int age;
//    public void greet()
//    {
//        Console.WriteLine("hello");
//    }
//    public void setAge(int a)
//    {
//        age = a;
//    }
//}

//class Student : Person
//{
//    public void GoToClasses()
//    {
//        Console.WriteLine("I'm going to class.");
//    }
//    public void ShowAge()
//    {
//        Console.WriteLine("My age is: " + age + " years old");
//    }
//}

//class Teacher : Person
//{
//    private string subject;
//    public void Explain()
//    {
//        Console.WriteLine("Explanation begins");
//    }
//}

//class StudentAndTeacherTest
//{
//    static void Main(String[] args)
//    {
//        Person p = new Person();
//        p.greet();
//        Student s = new Student();
//        s.setAge(21);
//        s.ShowAge();
//        Teacher t = new Teacher();
//        t.setAge(30);
//        t.greet();
//        t.Explain();
//    }
//}
/*--------------------------------------------------------------------------*/
/* 9. Create a class named "Table".It must have a constructor, indicating the width and height of the board. 
  It will have a method "ShowData" which will write on the screen the width and that height of the table. 
  Create an array containing 4 tables, with  sizes between 50 and 200 cm, and display all the data.  */

//class Table
//{
//    public int width, height;
//    public Table(int w, int h)
//    {
//        width = w;
//        height = h;
//    }
//    public void ShowData()
//    {
//        Console.WriteLine("Table width is " + width + " height is " + height);
//    }
//}
//class test
//{
//    static void Main()
//    {
//        Table[] arr = new Table[4];
//        Random rnd = new Random();
//        //Console.WriteLine(rnd.Next(50, 201));

//        for (int i = 0; i < 4; i++)
//        {
//            /*Random value in arr[i]*/ //rnd.Next(50, 201) --> Range 50 to 200
//            Table t = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
//            arr[i] = t;
//            arr[i].ShowData();
//        }

//        /*NotWorking*/
//        //foreach (Table t in arr)
//        //{
//        //    t = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
//        //    t.ShowData();
//        //}
//    }
//}
/*--------------------------------------------------------------------------*/
/* 10. Create a C# program that prompts the user for three names of people 
  and stores them in an array of Person-type objects. 
  There will be two people of the Student type and one person of the Teacher type.

  To do this, create a Person class that has a Name property of type string, 
  a constructor that receives the name as a parameter and and function to print the name.

  Then create two more classes that inherit from the Person class, 
  they will be called Student and Teacher. 
  The Student class has a Study method that writes by console that the student is studying. 
  The Teacher class will have an Explain method that writes to the console that the teacher is explaining. 
  Remember to also create two constructors on the child classes that call the parent constructor of the Person class.

End the program by reading the people (the teacher and the students) and execute the Explain and Study methods.
Input:

    Juan
    Sara
    Carlos

Output:

    Explain
    Study
    Study   */


class Person
{
    protected string name;
    public Person(string n)
    {
        name = n;
    }
    ~Person()
    {
        name = string.Empty;
    }
    public override string ToString()
    {
        return "Hello! My name is " + name;
    }
}

class Student : Person
{

    public Student(string n) : base(n)
    {
        name = n;
    }
    public void Study()
    {
        Console.WriteLine("student is studying");
    }
}

class Teacher : Person
{
    public Teacher(string n) : base(n)
    {
        name = n;
    }
    public void Explain()
    {
        Console.WriteLine("the teacher is explaining");
    }
}

class sample
{
    static void Main(String[] args)
    {
        Person[] arr = new Person[3];
        for(int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
            {
                Person p = new Teacher(Console.ReadLine());
            }
            else
            {
                Person p = new Student(Console.ReadLine());
            }
        }
        /*NotWorking*/
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
            {
                ((Teacher)arr[i]).Explain();
            }
            else
            {
                ((Student)arr[i]).Study();
            }
        }
    }
}
/*--------------------------------------------------------------------------*/