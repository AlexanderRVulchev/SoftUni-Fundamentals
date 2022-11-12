using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        List<string> inventory = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string input;
        while ((input = Console.ReadLine()) != "Craft!")
        {
            string[] tokens = input.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];
            string item = tokens[1];

            if (command == "Collect" && !inventory.Contains(item)) inventory.Add(item);
            else if (command == "Drop") inventory.Remove(item);
            else if (command == "Combine Items") Combine(inventory, item);
            else if (command == "Renew") Renew(inventory, item);
        }
        Console.WriteLine(String.Join(", ", inventory));
    }

    private static void Renew(List<string> inventory, string item)
    {
        if (!inventory.Contains(item)) return;
        inventory.Remove(item);
        inventory.Add(item);
    }

    private static void Combine(List<string> inventory, string item)
    {
        string[] splitItems = item.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
        string oldItem = splitItems[0];

        if (!inventory.Contains(oldItem)) return;

        string newItem = splitItems[1];
        int oldIndex = inventory.IndexOf(oldItem);

        if (oldIndex == inventory.Count - 1) inventory.Add(newItem);
        else inventory.Insert(oldIndex + 1, newItem);
    }
}