using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        List<int> targets = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "Shoot":
                    Shoot(targets, int.Parse(tokens[1]), int.Parse(tokens[2])); break;
                case "Add":
                    Add(targets, int.Parse(tokens[1]), int.Parse(tokens[2])); break;
                case "Strike":
                    Strike(targets, int.Parse(tokens[1]), int.Parse(tokens[2])); break;
                default:
                    break;
            }
        }
        Console.WriteLine(String.Join("|", targets));
    }

    private static void Strike(List<int> targets, int index, int radius)
    {
        if (index - radius < 0 || index + radius >= targets.Count)
        {
            Console.WriteLine("Strike missed!");
            return;
        }
        targets.RemoveRange(index - radius, radius * 2 + 1);
    }

    private static void Add(List<int> targets, int index, int value)
    {
        if (index < 0 || index >= targets.Count)
        {
            Console.WriteLine("Invalid placement!");
            return;
        }
        targets.Insert(index, value);
    }

    private static void Shoot(List<int> targets, int index, int power)
    {
        if (index < 0 || index >= targets.Count) return;

        if (targets[index] <= power) targets.RemoveAt(index);
        else targets[index] -= power;
    }
}