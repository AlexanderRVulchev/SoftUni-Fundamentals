//A theatre is sail tickets at discount, and a program is needed to calculate the price of a single ticket.
//If the given age does not fit one of the categories, you should print "Error!".  
//The prices of the tickers are as follows:
//Day / Age   0 <= age <= 18  18 < age <= 64  64 < age <= 122
//Weekday 12$	18$	12$
//Weekend 15$	20$	15$
//Holiday 5$	12$	10$
//Input
//The input comes in two lines. On the first line, you will receive the type of day.
//On the second – the age of the person.
//Output
//Print the price of the ticket according to the table, or "Error!" if the age is not in the table.

using System;


class Program
{
    static void Main()
    {
        string day = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int[] prices = { 12, 15, 5, 18, 20, 12, 12, 15, 10 };
        int priceIndex = 0;
        if (age < 0 || age > 122)
        {
            Console.WriteLine("Error!");
            return;
        }
        else if (age > 64) priceIndex += 6;
        else if (age > 18) priceIndex += 3;

        if (day == "Weekend") priceIndex += 1;
        else if (day == "Holiday") priceIndex += 2;

        Console.WriteLine($"{prices[priceIndex]}$");
    }
}
