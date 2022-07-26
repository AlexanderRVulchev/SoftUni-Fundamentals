//Read an array of real numbers (space separated), round them in "away from 0" style, and print the output as in the examples:

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            double number = numbers[i];
            int rounded = (int)Math.Round(number, MidpointRounding.AwayFromZero);

            Console.WriteLine($"{number} => {rounded}");
        }
    }
}