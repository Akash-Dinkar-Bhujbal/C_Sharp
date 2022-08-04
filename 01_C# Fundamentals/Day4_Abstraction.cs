abstract class class1
{
    public void calculate(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public abstract void fun1(int a);
}

class class2 : class1
{
    public void calculate(int a, int b)
    {
        Console.WriteLine(a * b);
    }


    public override void fun1(int a)
    {
        Console.WriteLine(a * a);
    }
}

class class3: class1
{
    public override void fun1(int a)
    {
        Console.WriteLine(a * a * a);
    }
}

class sam
{
    public static void Main()
    {
        //class1 o1 = new class1();
        //o1.calculate(11, 2);

        class2 o2 = new class2();
        o2.calculate(9, 3);

        class3 o3 = new class3();
        o3.calculate(11, 2);
    }
}

