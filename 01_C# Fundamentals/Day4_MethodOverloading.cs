using System.ComponentModel;

class test
{


    public static void add(int a, int b)
    {
        Console.WriteLine("{0}+{1}={2}", a,b,a+b);
    }

    public static void add(int a, int b, int c)
    {
        Console.WriteLine("{0}+{1}+{2}={3}", a, b,c, a + b+c);
    }
    public static void Main()
    {
        add(5,6);
        add(5, 6, 7);
    }

}
