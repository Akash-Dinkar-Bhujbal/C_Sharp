using System;

namespace UNARYOPERATOR
{
    class Sample
    {
        //declare integer data member
        private int val;

        //initialize data members
        public Sample(int val)
        {
            this.val = val;
        }

        //Overload unary decrement operator
        public static Sample operator --(Sample S)
        {
            S.val = --S.val;
            return S;
        }

        //Overload unary increment operator
        public static Sample operator ++(Sample S)
        {
            S.val = ++S.val;
            return S;
        }

        public void PrintValues()
        {
            Console.WriteLine("Values of val: " + val);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample S = new Sample(10);

            S++;
            S++;
            S++;
            S.PrintValues();

            S--;
            S--;
            S.PrintValues();
        }
    }
}
