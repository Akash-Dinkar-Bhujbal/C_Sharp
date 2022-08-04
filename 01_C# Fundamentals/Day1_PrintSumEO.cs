/**/
public class PrintEO
{
    public static void Main(string[] args)
    {
        int s,e, temp;
        
        Console.WriteLine("Enter start number: ");
        s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end number: ");
        e = Convert.ToInt32(Console.ReadLine());
        //Swap
        if (s > e)
        {
            temp = s;
            s = e;
            e = temp;
        }
        s++;

        //---------------------------------------------------

        /*Add all Even Nos*/
        //int sum = 0;
        //Console.Write("Start: "+s);
        //while (e > s)
        //{
        //    if (s % 2 == 0)
        //        sum += s;
        //    s++;
        //}
        //Console.WriteLine(", End: "+ --s);
        //Console.WriteLine("Even No Sum: "+sum);

        //---------------------------------------------------

        /*Print all Odd Nos*/
        //while (e > s)
        //{
        //    if (s % 2 != 0)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    s++;
        //}

    }
}
