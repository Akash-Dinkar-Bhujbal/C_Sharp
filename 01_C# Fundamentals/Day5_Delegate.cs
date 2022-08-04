using System.Security.Cryptography.X509Certificates;

public delegate void myFun(int a, int b);

class class1
{
    public void sum(int a, int b)
    {
        Console.WriteLine(a+b);
    }
}

class class2
{
    public void sum(int a, int b)
    {
        Console.WriteLine(a * b);
    }
}

class class3
{
    public void sum(int a, int b)
    {
        Console.WriteLine(a - b);
    }
}

class sample{
    public static void Main()
    {
        class1 obj1 = new class1();
        class2 obj2 = new class2();
        class3 obj3 = new class3();
        //myFun d = new myFun(obj3.sum);
        //d.Invoke(4, 2);

        myFun f;
        f = new myFun(obj1.sum);
        f += new myFun(obj2.sum);
        f.Invoke(2, 5);

        f -= new myFun(obj2.sum);
        f.Invoke(1, 2);

    }
}
