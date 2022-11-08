using System;

class Program
{
    static void Main()
    {
        double basePrice = 0;
        string input = Console.ReadLine();
        while (input != "special" && input != "regular")
        {
            double currentPrice = double.Parse(input);
            if (currentPrice < 0)
            {
                Console.WriteLine("Invalid price!");
                input = Console.ReadLine();
                continue;
            }

            basePrice += currentPrice;
            input = Console.ReadLine();
        }

        if (basePrice == 0)
        {
            Console.WriteLine("Invalid order!");
            return;
        }

        double taxes = 0.2 * basePrice;
        double total = basePrice + taxes;
        if (input == "special") total *= 0.9;

        Console.WriteLine("Congratulations you've just bought a new computer!");
        Console.WriteLine($"Price without taxes: {basePrice:f2}$");
        Console.WriteLine($"Taxes: {taxes:f2}$");
        Console.WriteLine("-----------");
        Console.WriteLine($"Total price: {total:f2}$");
    }
}