//Create a method, which receives two numbers as parameters:
//•	The first number – the base
//•	The second number – the power
// The method should return the base rase to the given power.

using System;
using System.Linq;


class Program
{
    static void PrintSign(int num)
    {
        if (num > 0) Console.WriteLine($"The number {num} is positive.");
        else if (num < 0) Console.WriteLine($"The number {num} is negative.");
        else Console.WriteLine($"The number 0 is zero.");
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintSign(n);
    }
}