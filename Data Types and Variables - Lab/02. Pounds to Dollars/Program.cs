//Create a program that converts British pounds to US dollars formatted to the 3rd decimal point.
//1 British Pound = 1.31 Dollars

using System;


class Program
{
    static void Main()
    {
        double pound = double.Parse(Console.ReadLine());
        double dollar = 1.31 * pound;
        Console.WriteLine($"{dollar:f3}");
    }
}
