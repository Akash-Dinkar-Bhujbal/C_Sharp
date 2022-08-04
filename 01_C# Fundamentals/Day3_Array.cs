/*Accept & Print Array*/
//public class Class1
//{
//    public Class1()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        // Declare an array
//        int[] ar = new int[5];

//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine("Enter element of Array: ");
//            ar[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        // Print an array
//        Console.WriteLine("Array Elemets are: ");
//        for (int i = 0; i < ar.Length; i++)
//            Console.Write(ar[i] + " ");
//    }
//}

/*Addition of all elements in Array*/
//public class Class2
//{
//    public Class2()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        // declare an array
//        int[] ar = new int[5];
//        int sum = 0;

//        for (int i = 0; i < 5; i++)
//        {

//            Console.WriteLine("Enter element of Array: ");
//            ar[i] = Convert.ToInt32(Console.ReadLine());
//            sum += ar[i];

//        }
//        Console.WriteLine("Sum of Array Elemets are: "+sum);
//    }
//}

/* Count of all Even elements in Array*/
//public class Class3
//{
//    public Class3()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        //Initializing array
//        //int[] ar = { 6, 1, 3, 4, 5 };

//        Console.WriteLine("Enter size of Array: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int[] arr = new int[n];
//        int count = 0;

//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("Enter element of Array: ");
//            arr[i] = Convert.ToInt32(Console.ReadLine());
//            if (arr[i] % 2 == 0)
//                count++;
//        }

//        Console.WriteLine("Count of Even Number are: " + count);
//    }
//}

/*Max No in Array*/
//public class Class4
//{
//    public Class4()
//    {
//    }
//    public static void Main(string[] args)
//    {
//        int[] ar = { 9,11,5,3,7 };
//        int max = ar[0];
//        for (int i = 1; i < ar.Length; i++)
//        {
//            if (max < ar[i])
//                max = ar[i];

//        }
//        Console.WriteLine("Max no is: " + max);
//    }
//}


/*Bubble Sort*/
public class Class5
{
    
    public static void Main(string[] args)
    {

        int[] arr = {9,2,1,8,3 };
        int temp;

        for(int i = 0; i < arr.Length; i++)
        {
            for(int j=i+1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        for(int i=0; i < arr.Length; i++)
            Console.WriteLine(arr[i]+" ");
        

    }
}
