//Create a program that receives three real numbers and sorts them in descending order.
//Print each number on a new line.

using System;


class Program
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());

        double highest = Math.Max(Math.Max(x1, x2), Math.Max(x2, x3));
        double lowest = Math.Min(Math.Min(x1, x2), Math.Min(x2, x3));
        double middle = x1 + x2 + x3 - highest - lowest;

        Console.WriteLine($"{highest}\n{middle}\n{lowest}");
    }
}