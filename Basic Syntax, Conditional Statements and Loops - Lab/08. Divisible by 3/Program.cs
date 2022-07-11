//Create a program, which prints all the numbers from 1 to 100, that is divisible by 3.
//You have to use a single for loop. The program should not receive input.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        for (int i = 3; i <= 100; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}