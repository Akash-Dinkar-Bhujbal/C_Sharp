
public class Test
{
    public static void sample()
    {
        Console.WriteLine("It is sample function");
        return;
    }

    public static int sample1(int a)
    {

        return a*a;
    }

    public static String sample2(int a, int b)
    {
        if (a == b)
            return "equal";
        else
            return "not equal";
    }

    public static String sample3(String a, String b)
    {

        return "Your name is "+a+", You stay at "+b;
    }

    public static void Main(string[] args)
    {
        sample();
        Console.WriteLine(sample1(2));
        Console.WriteLine(sample2(5, 6));
        Console.WriteLine(sample3("Akash", "Khopoli"));

        

    }
}
