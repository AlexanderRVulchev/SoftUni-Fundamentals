//Create a program that reads 3 lines of input. On each line, you get a single character.
//Combine all the characters into one string and print it on the console.

using System;


class Program
{
    static void Main()
    {
        double meters = double.Parse(Console.ReadLine());
        double kilometers = meters / 1000;
        Console.WriteLine($"{Math.Round(kilometers, 2, MidpointRounding.AwayFromZero):f2}");
    }
}