//Modify the program from the previous problem, so it will print "Failed!" if the grade is lower than 3.00.
//Input
//The input comes as a single double number.
//Output
//The output is either "Passed!" if the grade is more than 2.99, otherwise you should print "Failed!".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        if (grade >= 3.00) Console.WriteLine("Passed!");
        else Console.WriteLine("Failed!");
    }
}