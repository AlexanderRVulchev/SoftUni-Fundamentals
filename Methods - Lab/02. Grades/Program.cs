//Create a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade definition:
//•	2.00 – 2.99 - "Fail"
//•	3.00 – 3.49 - "Poor"
//•	3.50 – 4.49 - "Good"
//•	4.50 – 5.49 - "Very good"
//•	5.50 – 6.00 - "Excellent"

using System;
using System.Linq;
using System.Text;

class Program
{
    static void PrintGradeText(double grade)
    {
        if (grade < 3) Console.WriteLine("Fail");
        else if (grade < 3.5) Console.WriteLine("Poor");
        else if (grade < 4.5) Console.WriteLine("Good");
        else if (grade < 5.5) Console.WriteLine("Very good");
        else Console.WriteLine("Excellent");
    }

    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        PrintGradeText(grade);
    }
}