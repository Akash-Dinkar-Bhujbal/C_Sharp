/*Multiplication of 5 Nos*/

public class Sample
{
    public static void Main(string[] args)
    {
        int temp = 5, mul =1;

        while (temp > 0)
        {
            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                temp++;
                Console.WriteLine("No must be positive");
            }
            else
                mul *= temp;

            temp--;
        }
        Console.WriteLine("Multiplication: " + mul);

        //int x = 10;
        //Console.WriteLine(x++);
    }
}
