using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        int[] houses = Console.ReadLine()
            .Split(new string[] {"@"}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int index = 0;
        string input;
        while ((input = Console.ReadLine()) != "Love!")
        {
            string[] command = input.Split();
            int jump = int.Parse(command[1]);
            if (index + jump >= houses.Length) index = 0;
            else index += jump;

            if (houses[index] <= 0)
            {
                Console.WriteLine($"Place {index} already had Valentine's day.");
                continue;
            }
            houses[index] -= 2;
            if (houses[index] <= 0) Console.WriteLine($"Place {index} has Valentine's day.");
        }
        Console.WriteLine($"Cupid's last position was {index}.");
        Console.WriteLine(houses.Any(x => x > 0) ?
            $"Cupid has failed {houses.Where(x => x > 0).Count()} places." :
            $"Mission was successful.");
    }
}