using System.Data.SqlTypes;
using System.Threading;
namespace MultiThread
{
    class thread1
    {
        public void child()
        {
            int a = 1;
            while (a < 10)
            {
                Console.WriteLine(a);
                Thread.Sleep(1000);
                a++;
            }
        }
        /*1 2 3 .... 9*/
    }
    class thread2
    {
        public void child1()
        {
            int b = 10;
            while (b < 100)
            {
                Console.WriteLine(b);
                Thread.Sleep(1000);
                b = b + 10;

            }
        }
        /*10 20 30 .... 90*/
    }

    class program
    {
        static void Main(string[] args)
        {
            thread1 o = new thread1();// class1 obj
            thread2 o1 = new thread2();// class2 obj

            // ThreadStart use as like delegate to call class(obj) method
            ThreadStart reff = new ThreadStart(o.child);
            // Create Thread of ThreadStart/ class(obj) method
            Thread chi = new Thread(reff);
            // Thread started
            chi.Start();

            ThreadStart reff1 = new ThreadStart(o1.child1);
            Thread chi1 = new Thread(reff1);
            chi1.Start();

            /*
            Shedular will be decide which thread will call when
             Here Shedular run both Threads simultaneously
            -------------------------------------------------------
            Shedular will decide priority of threads.
             */
        }
    }
}