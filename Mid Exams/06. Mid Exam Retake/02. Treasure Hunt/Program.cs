using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        List<string> chest = Console.ReadLine()
            .Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string input;
        while ((input = Console.ReadLine()) != "Yohoho!")
        {
            string[] tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];
            if (command == "Loot") Loot(chest, tokens.Skip(1).ToList());
            else if (command == "Drop") Drop(chest, int.Parse(tokens[1]));
            else if (command == "Steal") Steal(chest, int.Parse(tokens[1]));
            
        }

        if (chest.Count == 0) Console.WriteLine("Failed treasure hunt.");
        else
        {
            double averageGain = chest.Sum(x => x.Length) / (double)chest.Count;
            Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
        }
    }

    private static void Drop(List<string> chest, int index)
    {
        if (index < 0 || index >= chest.Count) return;
        chest.Add(chest[index]);
        chest.RemoveAt(index);
    }

    private static void Loot(List<string> chest, List<string> items)
    {
        foreach (string item in items)
            if (!chest.Contains(item)) chest.Insert(0, item);
    }

    private static void Steal(List<string> chest, int dropCount)
    {
        List<string> stolenItems = new List<string>();
        for (int i = 0; i < dropCount; i++)
            if (chest.Count > 0)
            {
                stolenItems.Add(chest[chest.Count - 1]);
                chest.RemoveAt(chest.Count - 1);

            }
        stolenItems.Reverse();
        Console.WriteLine(String.Join(", ", stolenItems));
    }
}