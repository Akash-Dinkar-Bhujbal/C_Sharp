class sam
{
    public static void Main()
    {
        var a = 'f';
        var b = "thane";
        var c = 30.67d;
        var d = false;
        var e = 54544;
        //var m;
        //m = "hello";

        // Display the type
        Console.WriteLine("Type of a " + a.GetType());

        Console.WriteLine("Type of b " + b.GetType());

        Console.WriteLine("Type of c " + c.GetType());

        Console.WriteLine("Type of d" + d.GetType());

        Console.WriteLine("Type of e " + e.GetType());
        //////////////
        ///
        dynamic val1 = "harish";
        dynamic val2 = 3234;
        dynamic val3 = 32.55;
        dynamic val4 = true;
        dynamic val5;
        val5 = "suresh";

        Console.WriteLine(val1.GetType());

        Console.WriteLine(val2.GetType());
        Console.WriteLine(val3.GetType());
        Console.WriteLine(val4.GetType());

    }
}
