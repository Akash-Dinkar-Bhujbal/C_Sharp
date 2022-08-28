using System;
using System.Threading;
namespace THREADEXAMPLE
{
    class class1
    {
        public void display()
        {
            lock (this)
            {
                for (int a = 1; a < 11; a++)
                {
                    Console.WriteLine(a);
                    Thread.Sleep(1000);
                }
            }

        }


    }
    class class2
    {


        public void display()
        {
            for (int a = 11; a < 16; a++)
            {
                Console.WriteLine(a);
                Thread.Sleep(1000);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Create Class Object*/
            class1 obj = new class1();
            /*ThreadStart(d): We are using like delegate FOR CALLING FUNCTION DISPLAY IN CLASS1*/
            ThreadStart d = new ThreadStart(obj.display);
            /*Here, we are creating one Thread of d*/
            Thread t1 = new Thread(d);
            t1.Start();//thread1 started

            /*Here, we are creating one more Thread of d*/
            Thread t2 = new Thread(d);
            t2.Start();//thread2 started

            //class2 o = new class11();
            //ThreadStart d2 = new ThreadStart(o.display);
            //Thread t3 = new Thread(d2);
            //t3.Start();
        }
    }
}