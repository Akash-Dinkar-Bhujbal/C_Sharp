class class1
{
    public void calculate(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}

class class2 : class1
{
    public void calculate(int a, int b)
    {
        Console.WriteLine(a * b);
    }
}

class sam
{
    public static void Main()
    {
        class1 o1 = new class1();
        o1.calculate(11, 2);

        class2 o2 = new class2();
        o2.calculate(9, 3);
    }
}
