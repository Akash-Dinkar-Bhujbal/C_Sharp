using Package;
class sample
{
    public static void Main()
    {
        Class1 c = new Class1();
        Console.WriteLine(c.calculate(10, 10));

        // Alternative
        //Console.WriteLine(Package.Class1.calculate(10, 10));
        // But it is non static that's why we can't access here

    }
}
