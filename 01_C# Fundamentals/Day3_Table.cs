// See https://aka.ms/new-console-template for more information

public class Class1
{
    public Class1()
    {
    }
    public static void Main(string[] args)
    {
       
        for (int i = 2; i <= 9; i++)
        {
            for(int j = 1;j <= 10; j++)
            {
                Console.WriteLine(i+" x "+j+" = "+(i*j));
            }
            Console.WriteLine();
           
        }
        
    }
}
