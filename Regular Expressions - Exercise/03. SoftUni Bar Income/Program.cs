using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class ValidOrder
{
    public string Name { get; set; }

    public string Product { get; set; }

    public int Count { get; set; }

    public double Price { get; set; }

    public ValidOrder(string name, string product, int count, double price)
    {
        this.Name = name;
        this.Product = product;
        this.Price = price;
        this.Count = count;
    }

    public override string ToString()
    => $"{this.Name}: {this.Product} - {this.Price * this.Count:f2}";
}

internal class Program
{
    static void Main()
    {
        var validOrders = new List<ValidOrder>();
        string regexName = @"%(?<name>[A-Z][a-z]+)%";
        string regexProduct = @"<(?<product>\w+)>";
        string regexCount = @"[|](?<count>\d+)[|]";
        string regexPrice = @"(?<price>\d+[.]?\d*?)[$]";
        string input;

        while ((input = Console.ReadLine()) != "end of shift")
        {
            MatchCollection matchName = Regex.Matches(input, regexName);
            MatchCollection matchProduct = Regex.Matches(input, regexProduct);
            MatchCollection matchCount = Regex.Matches(input, regexCount);
            MatchCollection matchPrice = Regex.Matches(input, regexPrice);

            if (matchName.Count > 0 && matchProduct.Count > 0 && matchPrice.Count > 0 && matchCount.Count > 0)
            {
                string name = matchName[0].Groups["name"].Value;
                string product = matchProduct[0].Groups["product"].Value;
                int count = int.Parse(matchCount[0].Groups["count"].Value);
                double price = double.Parse(matchPrice[0].Groups["price"].Value);

                validOrders.Add(new ValidOrder(name, product, count, price));
            }
        }

        foreach (ValidOrder validOrder in validOrders)
            Console.WriteLine(validOrder.ToString());

        double totalIncome = validOrders.Sum(x => x.Price * x.Count);
        Console.WriteLine($"Total income: {totalIncome:f2}");
    }
}