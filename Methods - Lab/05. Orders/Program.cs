//Create a program that calculates and prints the total price of an order. The method should receive two parameters:
//•	A string, representing a product - "coffee",  "water", "coke", "snacks"
//•	An integer, representing the quantity of the product
//The prices for a single item of each product are:
//•	coffee – 1.50
//•	water – 1.00
//•	coke – 1.40
//•	snacks – 2.00
//Print the result rounded to the second decimal place.

using System;


class Program
{
    static void CalculateOrderPrice(string item, int quantity)
    {
        double price = 0;
        switch (item)
        {
            case "coffee": price = 1.50; break;
            case "water": price = 1.00; break;
            case "coke": price = 1.40; break;
            case "snacks": price = 2.00; break;
            default: break;
        }
        Console.WriteLine($"{price * quantity:f2}");
    }

    static void Main()
    {
        string item = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        CalculateOrderPrice(item, quantity);
    }
}