using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string regex = @"\B>>(?<name>[A-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
        string input;

        List<string> purchasedItems = new List<string>();
        double totalCost = 0;

        while ((input = Console.ReadLine()) != "Purchase")
        {
            MatchCollection purchase = Regex.Matches(input, regex);
            foreach (Match item in purchase)
            {
                string name = item.Groups["name"].Value;
                double price = double.Parse(item.Groups["price"].Value);
                int quantity = int.Parse(item.Groups["quantity"].Value);
                purchasedItems.Add(name);
                totalCost += price * quantity;
            }
        }
        Console.WriteLine("Bought furniture:");
        if (purchasedItems.Count > 0)
            Console.WriteLine(String.Join("\n", purchasedItems));
        Console.WriteLine($"Total money spend: {totalCost:f2}");
    }
}