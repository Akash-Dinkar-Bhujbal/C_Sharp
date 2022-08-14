/* 1. Write a C# program and compute the sum of the digits of an integer. 
use do...while loop
Input a number(integer): 12
Sum of the digits of the said integer: 3    */

//class sample
//{
//    public static void Main()
//    {
//        Console.WriteLine("Enter the number: ");
//        int num = Convert.ToInt32(Console.ReadLine());//12
//        int temp = num, rem, sum=0;
//        do {
//            rem = temp % 10;//rem
//            sum += rem;//sum
//            temp /= 10;//num
//        } while (temp > 0);
//        Console.WriteLine("Sum of the {0} digits: {1}",num,sum);
//    }
//}
/*--------------------------------------------------------------------------*/

/* 2. Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
  The customer id., name and unit consumed by the user should be taken from the keyboard 
  and display the total amount to pay to the customer. The charge are as follow : 
Unit 	Charge/unit
upto 199 	@1.20
200 and above but less than 400 	@1.50
400 and above but less than 600 	@1.80
600 and above 	@2.00

If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-

Test Data :
1001
James
800
Expected Output :
Customer IDNO :1001
Customer Name :James
unit Consumed :800
Amount Charges @Rs. 2.00 per unit : 1600.00
Surchage Amount : 240.00
Net Amount Paid By the Customer : 1840.00   */

//class sample
//{
//    public static void Main()
//    {
//        Console.WriteLine("Enter your Customer Id: ");
//        int customer_id = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter your Customer Name: ");
//        string name= Console.ReadLine();
//        Console.WriteLine("Enter your Billing Unit: ");
//        int unit = Convert.ToInt32(Console.ReadLine());
//        double charges, uCharges, extraCharges = 0, total;

//        // Charges
//        if (unit < 200) {
//            uCharges = 1.20;
//            charges = (double)unit * uCharges;
//        }else if (unit < 400) {
//            uCharges = 1.50;
//            charges = (double)unit * uCharges;
//        }
//        else if (unit < 600) {
//            uCharges = 1.80;
//            charges = (double)unit * uCharges;
//        } else {
//            uCharges = 2;
//            charges = (double)unit * uCharges;
//        }

//        // Surchange Amount
//        if (charges > 400)
//        {
//            extraCharges = charges * 0.15;
//        }

//        total = charges + extraCharges;

//        Console.WriteLine("Customer IDNO :{0}\r\n" +
//            "Customer Name :{1}\r\n" +
//            "unit Consumed :{2}\r\n" +
//            "Amount Charges @Rs. {3} per unit : {4}\r\n" +
//            "Surchage Amount : {5}\r\n" +
//            "Net Amount Paid By the Customer : {6}", 
//            customer_id, name, unit, uCharges, charges,extraCharges,total);
//    }
//}
/*--------------------------------------------------------------------------*/

/* 3. Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1.

   1 
  2 3 
 4 5 6 
7 8 9 10    */

//class sample
//{
//    public static void Main()
//    {
//        Console.WriteLine("Enter the number: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int count = 1;

//        for(int i = 1; i <= n; i++)// rows
//        {
//            for(int j=i; j<=n; j++)
//            {
//                Console.Write(" ");
//            }
//            for (int j = 1; j <= i; j++)
//            {
//                Console.Write(count++ + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
/*--------------------------------------------------------------------------*/

/*4. Write a program in C# Sharp to display the number in reverse order.
Test Data :
Input a number: 12345
Expected Output :
The number in reverse order is : 54321  */

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

/* 5. Write a program in C# Sharp to create a function to check whether a number is prime or not.
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

/* 6. Create a class "PhotoAlbum" with a private attribute "numberOfPages."
It should also have a public method "GetNumberOfPages", which will return the number of pages.
The default constructor will create an album with 16 pages. There will be an additional constructor, 
    with which we can specify the number of pages we want in the album.
Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.
Create a test class "AlbumTest" to create an album with its default constructor, 
    one with 24 pages, a "BigPhotoAlbum" and show the number of pages that the three albums have.   */

class PhotoAlbum
{
    private int numberOfPages;// field
    public int NumberOfPages// property
    {
        get { return numberOfPages; }//getter
        set { numberOfPages = value; }//setter
    }
    public PhotoAlbum()//DefaultConstructor
    {
        numberOfPages = 16;
    }

    public PhotoAlbum(int pages)//ParamaterisedConstructor
    {
        numberOfPages = pages;
    }
}

class BigPhotoAlbum
{
    private int numberOfPages;// field
    public int NumberOfPages// property
    {
        get { return numberOfPages; }//getter
        set { numberOfPages = value; }//setter
    }
    public BigPhotoAlbum()//DefaultConstructor
    {
        numberOfPages = 64;
    }
    public BigPhotoAlbum(int pages)//ParamaterisedConstructor
    {
        numberOfPages = pages;
    }
}

class AlbumTest
{
    private int numberOfPages;// field
    public int NumberOfPages// property
    {
        get { return numberOfPages; }//getter
        set { numberOfPages = value; }//setter
    }
    public AlbumTest()//DefaultConstructor
    {
        numberOfPages = 24;
    }
    public AlbumTest(int pages)//ParamaterisedConstructor
    {
        numberOfPages = pages;
    }
    public static void Main()
    {
        PhotoAlbum pa = new PhotoAlbum();
        BigPhotoAlbum ba = new BigPhotoAlbum();
        AlbumTest at = new AlbumTest();
        Console.WriteLine("In PhotoAlbum number of pages is {0}",pa.NumberOfPages);
        Console.WriteLine("In BigPhotoAlbum number of pages is {0}", ba.NumberOfPages);
        Console.WriteLine("In AlbumTest number of pages is {0}", at.NumberOfPages);
    }
}

/*--------------------------------------------------------------------------*/
/* 7. Create a C# program that prompts the user for three names of people 
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


//public class sample
//{
//    public static void Main(string[] args)
//    {
//        Person[] persons = new Person[3];
//        int size = persons.Length;

//        for (int i = 0; i < size; i++)
//        {
//            if (i == 0)
//            {
//                persons[i] = new Teacher(Console.ReadLine());
//            }
//            else
//            {
//                persons[i] = new Student(Console.ReadLine());
//            }
//        }

//        for (int i = 0; i < size; i++)
//        {
//            if (i == 0)
//            {
//                ((Teacher)persons[i]).Explain();

//            }
//            else
//            {
//                ((Student)persons[i]).Study();
//            }
//        }
//    }

//    public class Person
//    {
//        protected string Name { get; set; }

//        public Person(string name)
//        {
//            Name = name;
//        }

//        public override string ToString()
//        {
//            return "Hello! My name is " + Name;
//        }

//        ~Person()
//        {
//            Name = string.Empty;
//        }
//    }

//    public class Teacher : Person
//    {
//        public Teacher(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Explain()
//        {
//            Console.WriteLine("Explain");
//        }
//    }

//    public class Student : Person
//    {
//        public Student(string name) : base(name)
//        {
//            Name = name;
//        }

//        public void Study()
//        {
//            Console.WriteLine("Study");
//        }
//    }
//}
/*--------------------------------------------------------------------------*/

/* 8. declare a delegate which will take 2 parameter of integer type 
 * and then then implement the same in two classes one doing the addition 
 * and another subtraction */

//class class1
//{
//    public int fun(int a, int b)
//    {
//        return a + b;
//    }
//}
//class class2
//{
//    public int fun(int a, int b)
//    {
//        return a - b;
//    }
//}
//class sample
//{
//    public delegate int myFun(int a, int b);
//    public static void Main()
//    {
//        class1 c1 = new class1();
//        class2 c2 = new class2();
//        myFun d;
//        d = new myFun(c1.fun);
//        Console.WriteLine(d.Invoke(5, 7));
//        d = new myFun(c2.fun);
//        Console.WriteLine(d.Invoke(5, 7));
//    }
//}


/* 9. Write C# program to find first and last digit of any number   */

//class sample
//{
//    public static void Main()
//    {
//        Console.WriteLine("Enter the number: ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        List<int> digit = new List<int>();
//        int temp = num;
//        while (num > 0)
//        {
//            int rem = num % 10;
//            digit.Add(rem);
//            num /= 10;
//        }

//        Console.WriteLine("First digit of {0} is {1}",temp, digit[digit.Count - 1]);
//        Console.WriteLine("Last digit of {0} is {1}",temp, digit[0]);
//    }
//}

/* 10. Create a C# program that implements an IVehiculo interface with two methods, 
 * one for Drive of type void and another for Refuel of type bool that has 
 * a parameter of type integer with the amount of gasoline to refuel. 
 * Then create a Car class with a builder that receives a parameter 
 * with the car's starting gasoline amount and 
 * implements the Drive and Refuel methods of the car.

The Drive method will print on the screen that the car is Driving, 
if the gasoline is greater than 0. 
The Refuel method will increase the gasoline of the car and return true.

To carry out the tests, 
create an object of type Car with 0 of gasoline in the Main of the program 
and ask the user for an amount of gasoline to refuel, 
finally execute the Drive method of the car.
Input

    50

Output

    Driving */

//interface IVehiculo
//{
//    public void Drive();
//    public bool Refuel(int amt);
//}

//class Car : IVehiculo
//{
//    int Fuel { get; set;}

//    public Car(int fuel)//ParamaterisedConstructor
//    {
//        Fuel = fuel;
//    }

//    public Car()//NoArgsConstructor
//    {
//        Fuel = 0;
//    }

//    public void Drive()
//    {
//        if(Fuel>0)
//            Console.WriteLine("Driving");
//        else
//            Console.WriteLine("Not Fuel");
//    }

//    public bool Refuel(int amt)
//    {
//        Fuel += amt;
//        return true;
//    }
//}

//class sample
//{
//    public static void Main()
//    {
//        Car c = new Car(0);
//        Console.WriteLine("How much amount of fuel you want to fill:");
//        int fuel = Convert.ToInt32(Console.ReadLine());//50
//        if (c.Refuel(fuel))
//            c.Drive();
//    }
//}