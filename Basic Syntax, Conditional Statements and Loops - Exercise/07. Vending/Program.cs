//Write a program that accumulates coins.
//Until the "Start" command is given, you will receive coins, and only the valid ones should be accumulated. Valid coins are:
//•	0.1, 0.2, 0.5, 1, and 2
//If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
//On the next lines, until the "End" command is given you will start receiving products, which a customer wants to buy.
//The vending machine has only:
//•	"Nuts" with a price of 2.0
//•	"Water" with a price of 0.7
//•	"Crisps" with a price of 1.5
//•	"Soda" with a price of 0.8
//•	"Coke" with a price of 1.0
//If the customer tries to purchase a not existing product print "Invalid product".
//When a customer has enough money to buy the selected product, print "Purchased {product name}",
//otherwise print "Sorry, not enough money", and continue to the next line.
//When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change: {money left}".

using System;
using System.Linq;


class Program
{
    static void Main()
    {
        double[] coinValues = { 0.1, 0.2, 0.5, 1, 2 };
        string[] products = { "Nuts", "Water", "Crisps", "Soda", "Coke" };
        double[] prices = { 2.0, 0.7, 1.5, 0.8, 1.0 };
        double balance = 0;
        string input;
        while ((input = Console.ReadLine()) != "Start")
        {
            double coin = double.Parse(input);
            if (coinValues.Contains(coin)) balance += coin;
            else Console.WriteLine($"Cannot accept {coin}");
        }

        while ((input = Console.ReadLine()) != "End")
        {
            if (!products.Contains(input))
            {
                Console.WriteLine("Invalid product");
                continue;
            }
            for (int i = 0; i < 5; i++)
                if (input == products[i])
                {
                    if (balance - prices[i] < 0) Console.WriteLine("Sorry, not enough money");
                    else
                    {
                        Console.WriteLine($"Purchased {input.ToLower()}");
                        balance -= prices[i];
                    }
                    break;
                }
        }
        Console.WriteLine($"Change: {balance:f2}");
    }
}
