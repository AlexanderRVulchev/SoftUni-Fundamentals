//You will be given a sequence of strings, each on a new line.
//Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper and so on) and every even - quantity.
//Your task is to collect the resources and print them each on a new line.
//Print the resources and their quantities in the following format:
//"{resource} –> {quantity}"
//The quantities will be in the range [1… 2 000000000].


using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        Dictionary<string, int> oreQuantityPairs = new Dictionary<string, int>();
        string input;
        while ((input = Console.ReadLine()) != "stop")
        {
            string newOre = input;
            int newQuantity = int.Parse(Console.ReadLine());
            if (!oreQuantityPairs.ContainsKey(newOre))
                oreQuantityPairs.Add(newOre, 0);
            oreQuantityPairs[newOre] += newQuantity;
        }

        foreach (var oreQuantity in oreQuantityPairs)
        {
            Console.WriteLine($"{oreQuantity.Key} -> {oreQuantity.Value}");
        }
    }
}