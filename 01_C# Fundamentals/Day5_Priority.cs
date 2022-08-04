class class1
{
    public class1(string b)
    {
        Console.WriteLine("base class constructor " + b);
    }
}
class class2 : class1
{
    public class2(string a) : base("airoli")
    {
        Console.WriteLine("Derived  class constructor " + a);
    }
}
class class3 : class1
{
    public class3(string a) : base("mulund")
    {
        Console.WriteLine("Derived  class constructor " + a);
    }
}
class a
{
    public static void Main()
    {
        class3 o = new class3("powai");
    }
}
