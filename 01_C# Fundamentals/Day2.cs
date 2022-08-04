using System;

//print all natural numbers from 1 to n. - using while loop

//public class Class1
//{
//    public Class1()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter Number: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int i = 1;
//        while (i <= n)
//        {
//            Console.WriteLine(i);
//            i++;
//        }
//    }
//}


//print all natural numbers in reverse (from n to 1). - using while loop

//public class class2
//{
//    public class2()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter Number: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        while (n > 0)
//        {
//            Console.WriteLine(n);
//            n--;
//        }
//    }
//}

//print all even numbers between 1 to 100. - using while loop

//public class Class3
//{
//    public Class3()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("1 to 100 Even Numbers ");
//        int i = 1;
//        while (100 > i)
//        {
//            if (i % 2 == 0)
//                Console.Write(i+" ");
//            i++;
//        }

//    }
//}

//print all odd number between 1 to 100.

//public class Class4
//{
//    public Class4()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("1 to 100 Odd Numbers ");
//        int i = 1;
//        while (100 > i)
//        {
//            if (i % 2 != 0)
//                Console.Write(i + " ");
//            i++;
//        }

//    }
//}

//find sum of all natural numbers between 1 to n.

//public class Class5
//{
//    public Class5()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter Number: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int sum = 0, temp =1;
//        while (temp <= n)
//        {
//            sum += temp;
//            temp++;
//        }
//        Console.WriteLine(sum);
//    }
//}

//find sum of all even numbers between 1 to n.

//public class Class6
//{
//    public Class6()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter Number: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int sum = 0, temp = 1;
//        while (temp <= n)
//        {
//            if (temp % 2 == 0)
//                sum += temp;
//            temp++;
//        }
//        Console.WriteLine(sum);
//    }
//}

//find sum of all odd numbers between 1 to n.

//public class Class7
//{
//    public Class7()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter Number: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int sum = 0, temp = 1;
//        while (temp <= n)
//        {
//            if (temp % 2 != 0)
//                sum += temp;
//            temp++;
//        }
//        Console.WriteLine(sum);
//    }
//}

//print multiplication table of any number by using while loop.

public class Class8
{
    public Class8()
    {
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (10 >= i)
        {
            Console.WriteLine(n+" * "+i+" = "+i*n);
            i++;
        }
    }
}
