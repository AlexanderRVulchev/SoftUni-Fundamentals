//Create a program that receives an integer as an input. Print the 10 times table for this integer.

using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} X {i} = {n * i}");
        }
    }
}