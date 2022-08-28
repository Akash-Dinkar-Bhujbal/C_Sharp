using System;
using System.Threading.Tasks;

namespace ASYN2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  method1().Wait();
            method1();
            method2();
        }

        ////////////////
        ///
        public static async Task method1()
        {
            await Task.Run(() =>
            {
                for (int a = 1; a < 15; a++)
                {
                    Console.WriteLine(a);
                    Task.Delay(100).Wait();
                }

            });
        }
        //public static void method1()
        //{
        //    for (int a = 1; a < 11; a++)
        //    {
        //        Console.WriteLine(a);
        //        Task.Delay(100).Wait();
        //    }

        //}

        public static void method2()
        {
            for (int a = 11; a < 21; a++)
            {
                Console.WriteLine(a);
                Task.Delay(100).Wait();
            }

        }




    }
}