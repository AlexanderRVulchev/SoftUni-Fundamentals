//A single integer is given, create a method that checks if the given number is positive, negative, or zero. As a result print:
//•	For positive number: "The number {number} is positive. "
//•	For negative number: "The number {number} is negative. "
//•	For zero number: "The number {number} is zero. "

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