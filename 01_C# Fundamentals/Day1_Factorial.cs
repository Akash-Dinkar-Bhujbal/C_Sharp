// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class factorial
{
    public static int func(int n)
    {
        if (n == 1)
            return 1;
        return func(n - 1) * n;
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int temp = n;
        int fact = 1;
        // Using Loop
        while(temp >0)
        {
            fact = fact * temp;
            temp--;
        }
        Console.WriteLine("Factorial of "+n+" is "+fact);
        // Recursion
        Console.WriteLine(func(n));

    }
}
