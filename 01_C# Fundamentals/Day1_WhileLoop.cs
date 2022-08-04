

class test
{
    public static void Main(String[] args)
    {
        /*ADDITION UPTO THAT NUMBER*/
        //int a = 1, s = 0, n;
        //while(a <= 5)
        //{
        //    Console.WriteLine("Enter number: ");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    if (n < 0)
        //        break;
        //    s += n;
        //    a++;
        //}
        //Console.WriteLine(s);

        /*ADDITION UPTO THAT NUMBER*/
        int sum = 0, n;
        Console.WriteLine("Enter number: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        while (n>0)
        {
            sum += n;
            n--;
        }
        Console.WriteLine("Addition: "+sum);


    }
}
