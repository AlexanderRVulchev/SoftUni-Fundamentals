//Create a program that prints on a new line the next n odd numbers (starting from 1).
//On the last row prints the sum of all n odd numbers.

using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i + i - 1);
        }
        Console.WriteLine($"Sum: {n * n}");
    }
}