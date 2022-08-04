using System;
namespace ClassTest// Collection of class:namespace
    //Main Class
{

    class Employee
    {
        private int Id;
        private String Name;
        private int Salary;

        public void acceptdata()
        {
            Console.WriteLine("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }

        public void displaydata()
        {
            Console.WriteLine("Id is "+Id+" , Name is "+Name+" , Salary is "+Salary);
        }

    }


    class rectangle
    {
        private int length, width;
        public void acceptdata()
        {
            Console.WriteLine("Enter length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine());
        }

        public int area(int l, int w)
        {
            return l*w;
        }

        public int perimeter(int l, int w)
        {
            return 2*(l*w);
        }

        public void displaydata()
        {
            Console.WriteLine("Area of Rectangle is " + area(length, width));
            Console.WriteLine("Perimeter of Rectangle is " + perimeter(length, width));
        }

    }

   /* make a class Employee with following properties
Id, Basic salary,DA(DEARNESS ALLOWANCE) ,HRA(HOUSE RENT ALLOWANCE),GROSS,TAX,NET
--------------------------------
INPUT ID AND BASICSALARY THEN
 CALCULATE DA AS BELOW
IF SALARY >=50000 THEN
DA MUST BE 10 PERCENT OF SALARY OTHERWISE
DA MUST BE 5 PERCENT OF SALARY
FOR HRA
------------------------------------
 CALCULATE HRA AS BELOW
IF SALARY >=60000 THEN
DA MUST BE 20 PERCENT OF SALARY OTHERWISE
DA MUST BE 10 PERCENT OF SALARY
FOR HRA
-----------
GROSS WILL BE SUM OF BASICSALARY+DA+HRA
-------------------------------------
TAX WILL BE 10 PERCENT OF GROSS IF GROSS WI MORE THAN 80000 OTHERWISE 5 PERCENT
-------------------------
NET WILL BE TAX SUBTRACTED FROM GROSS */
    class Employee1
    {
        public double Id, basic_salary;
        public double DA, HRA, GROSS, TAX, NET;
        public void acceptdata(double Id, double bs)
        {
            //Console.WriteLine("Enter Id: ");
            //Id = Convert.ToInt32(Console.ReadLine());
            this.Id = Id;
            //Console.WriteLine("Enter Salary: ");
            //basic_salary = Convert.ToInt32(Console.ReadLine());
            basic_salary = bs;
           

            if (basic_salary >= 50000)
                DA = (basic_salary) * (10 / 100);
            //DA = basic_salary * 0.10;
            else
                        DA = basic_salary * 0.05;

            if (basic_salary >= 60000)
                HRA = ((basic_salary) * 20 / 100);
            else
                HRA = ((basic_salary) * 10 / 100);

            GROSS = (basic_salary + DA + HRA);

            if (GROSS > 80000)
                TAX = ((GROSS) * 10 / 100);
            else
                TAX = ((GROSS) * 5 / 100);

            NET = GROSS - TAX;


        }

        public void displaydata()
        {
           
            Console.WriteLine("***** Thank you for visiting..." + Id+" *****");
            Console.WriteLine("Basic " + basic_salary);
            Console.WriteLine("DA " + DA);
            Console.WriteLine("HRA " + HRA);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Gross " + GROSS);
            Console.WriteLine("TAX " + TAX);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("NET " + NET);
            Console.WriteLine("-----------------------------");
        }



    }


    class Program
    {
        static void Main(String[] args)
        {
            //Employee e1 = new Employee();
            //e1.acceptdata();
            //e1.displaydata();
            //Employee e2 = new Employee();
            //e2.acceptdata();
            //e2.displaydata();

            //rectangle r = new rectangle();
            //r.acceptdata();
            //r.displaydata();

            Employee1 e = new Employee1();
            //e.acceptdata(14228, 300000);
            //e.displaydata();
            //Console.WriteLine(Convert.ToDouble(10 / 100));

            //float f = (10) / (100);
            //Console.WriteLine(f);
            
            

        }
    }
}

