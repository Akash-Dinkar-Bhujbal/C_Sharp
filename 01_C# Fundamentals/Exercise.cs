/*write a program which will make a class with rectange having properties like
lenght,widhth
calculate area and with by making a class
*/
using System.ComponentModel.DataAnnotations;

class Rectangle
{
    public int length { get; set; }
    public int width { get; set; }


    public void acceptData ()
    {
        Console.WriteLine("Enter length: ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter width: ");
        width = Convert.ToInt32(Console.ReadLine());
    }

    public void displayData()
    {
        Console.WriteLine("Area of Rectangle: "+length*width);
    }
}

class sample
{
    /*MCQ 1*/
    //static void Main(string[] args)
    //{
    //    int i = 30;
    //    int j = 25 % 25;
    //    if (Convert.ToBoolean(Convert.ToInt32(i = j)))
    //    {
    //        Console.WriteLine("In if");
    //    }
    //    else
    //    {
    //        Console.WriteLine("In else");
    //    }
    //    Console.WriteLine("In main");
    //    Console.ReadLine();
    //}
    /*O/P:
     In else
     In main

     */

    /*MCQ 2*/
    //static void Main(string[] args)
    //{
    //    int i;
    //    int b = 8, a = 32;
    //    for (i = 0; i <= 10; i++)
    //    {
    //        if ((a / b * 2) == 2)
    //        {
    //            Console.WriteLine(i + " ");
    //            continue;
    //        }
    //        else if (i != 4)
    //            Console.Write(i + " ");
    //        else
    //            break;
    //    }
    //    Console.ReadLine();
    //}
    /*O/p:
     0 1 2 3

     */

    public static void Main()
    {
        /*Area of Rectangle*/
        //Rectangle r = new Rectangle();
        //r.acceptData();
        //r.displayData();

        //----------------------------------------------------

        /*
         * write a program to input any two numbers and 
         * count total numbers of prime numbers between these two numbers 
         * by using nested while loop */

        Console.WriteLine("Enter starting no: ");
        int s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter ending no: ");
        int e = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        while (s<e)
        {
            int flag = 0;
            int n = s, i =2;
            while (i<=n/2)
            {
                if (n%i==0)
                {
                    flag = 1;
                    break;
                }
               
                i++;
            }
            if (flag == 0 & n>1)
            {
                count++;
                //Console.WriteLine("No: " + n);
            }
            
            s++;
        }
        Console.WriteLine("Count: "+count);
    }
}
