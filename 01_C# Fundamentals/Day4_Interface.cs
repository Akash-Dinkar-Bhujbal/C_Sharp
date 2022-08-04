interface interface1
{
    public void calculate(int a, int b);
}

interface interface2
{
    public void fun1(int a);
}

class class1 : class2, interface1, interface2
{
    public void calculate(int a, int b)
    {
        Console.WriteLine(a * b);
    }

    public void fun1(int a)
    {
        Console.WriteLine(a * a);
    }
}

class class2
{
    public void welcome()
    {
        Console.WriteLine("Welcome function of class 2");
    }
}

class sam
{
    public static void Main()
    {
        class1 o1 = new class1();
        o1.calculate(5, 2);
        o1.fun1(5);
        o1.welcome();
    }
}
