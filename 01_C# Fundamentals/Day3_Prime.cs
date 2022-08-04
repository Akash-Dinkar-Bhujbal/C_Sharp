
public class Class1
{
    public Class1()
    {
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int flag = 0;
        for(int i = 2; i <= n/2; i++)
        {
           
            if (n % i == 0)
            {
                flag = 1;
                break;
            }
        }
        if (n < 2)
            Console.WriteLine("Not Prime & Not Composite");
        else if (flag==0)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Composite Number");
    }
}
