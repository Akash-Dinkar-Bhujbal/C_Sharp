//write a program which will have one interface shape and which has a
//function calculatearea with 1 parameter and implement the same interface in two classes
//rectange and circle and do the necesary calculation

using System.Data;

interface shape
{
    public double calculatearea(int a);
    public double calculatearea(int a, int b);
}

class rectangle : shape
{
    public double calculatearea(int a)
    {
        return a*a;
    }
    public double calculatearea(int a, int b)
    {
        return a * b;
    }

    public void fun()
    {
        Console.WriteLine("Try...");
    }
}

class circle : shape
{
    public double calculatearea(int a)
    {
        return (3.14 * a * a);
    }
    public double calculatearea(int a, int b)
    {
        return 0;
    }
}


class test
{
    public static void Main()
    {
        shape s;
        s = new rectangle();
        Console.WriteLine("Area of Rectangle " + s.calculatearea(3, 2));
        Console.WriteLine("area of square " + s.calculatearea(3));
        //s.fun(); /*Not calling because this function is not part of shape interface*/
        s = new circle();
        Console.WriteLine("Area of Circle " + s.calculatearea(5));

        //rectangle r = new rectangle();
        //Console.WriteLine("Area of Rectangle "+r.calculatearea(3,2));
        //Console.WriteLine("Area of Square " + r.calculatearea(3));
        //circle c = new circle();
        //Console.WriteLine("Area of Circle "+c.calculatearea(5));
    }
}
