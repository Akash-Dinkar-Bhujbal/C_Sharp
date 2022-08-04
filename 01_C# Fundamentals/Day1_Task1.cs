
public class evenodd
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n < 1)
        {
            Console.WriteLine("No Even No Odd");
        }
        else if (n % 2 == 0)
        
            Console.WriteLine("Even");
        else
                Console.WriteLine("Odd");
        
    }
}
