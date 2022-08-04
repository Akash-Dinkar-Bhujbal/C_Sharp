
class student
{
    public static void Main(String[] args)
    {
        int m, s, e;
        Console.WriteLine("Enter marks of Maths: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks of Science: ");
        s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter marks of English: ");
        e = Convert.ToInt32(Console.ReadLine());

        int total = m + s + e;
        int avg = total / 3;
        String grade = "";

        /*AND OPERATOR*/
        //if(m>50 && s>50 && e > 50)
        //{
        //    if (avg >= 75)
        //        grade = "A";
        //    else if (avg >= 60)
        //        grade = "B";
        //    else if (avg >= 50)
        //        grade = "C";
        //    else
        //        grade = "Pass";
        //}
        //else
        //    grade = "Fail";

        /*OR OPERATOR*/
        if (m<50 || s<50 || e < 50)
        {
            grade = "Fail";
        }
        else
        {
            if (avg >= 75)
                grade = "A";
            else if (avg >= 60)
                grade = "B";
            else if (avg >= 50)
                grade = "C";
            else
                grade = "Pass";
        }
        Console.WriteLine("Total = " + total);
        Console.WriteLine("Avg = " + avg);
        Console.WriteLine("Grade = " + grade);
    }
}
