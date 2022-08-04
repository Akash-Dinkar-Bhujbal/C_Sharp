/*COUNT EVEN ODD NUMBERS FROM THE RANGE*/

public class evenodd
{
    public static void Main(string[] args)
    {
        int temp=5, ec=0, oc=0;
        while (temp > 0)
        {
            int n;
            Console.WriteLine("Enter number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                ec++;
            else
                oc++;
            temp--;
        }
                Console.WriteLine("Even Count: "+ec);
                Console.WriteLine("Odd Count: "+oc);
       

    }
}
