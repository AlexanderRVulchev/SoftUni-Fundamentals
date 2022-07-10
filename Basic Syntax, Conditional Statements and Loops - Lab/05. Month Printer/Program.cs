//Create a program that receives an integer and prints the matching month.
//If the number is more than 12 or less than 1 print "Error!".
//Input
//You will receive a single integer on a single line.
//Output
//If the number is within the boundaries print the corresponding month, otherwise print "Error!".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num < 1 || num > 12)
        {
            Console.WriteLine("Error!");
            return;
        }
        string[] month = { "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December" };
        Console.WriteLine(month[num - 1]);
    }
}
