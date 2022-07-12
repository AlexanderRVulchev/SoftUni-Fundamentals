//You will receive three lines from the console:
//•	A count of people, which are going on vacation.
//•	Type of the group (Students, Business, or Regular).
//•	 The day of the week which the group will stay (Friday, Saturday, or Sunday).
//Based on the given information calculate how much the group will pay for the entire vacation. 
//The price for a single person is as follows:
//	Friday Saturday	Sunday
//Students	8.45	9.80	10.46
//Business	10.90	15.60	16
//Regular	15	20	22.50
//There are also discounts based on some conditions:
//•	For Students, if the group is 30 or more people, you should reduce the total price by 15%
//•	For Business, if the group is 100 or more people, 10 of the people stay for free.
//•	For Regular, if the group is between 10 and 20  people (both inclusively), reduce the total price by 5%
//Note: You should reduce the prices in that EXACT order!
//As an output print the final price which the group is going to pay in the format: 
//"Total price: {price}"
//The price should be formatted to the second decimal point.

using System;


class Program
{
    static double GetPrice(int people, string type, string day)
    {
        double[] prices = { 8.45, 10.90, 15.00, 9.80, 15.60, 20.00, 10.46, 16.00, 22.50 };
        int priceIndex = 0;

        if (type == "Business") priceIndex += 1;
        else if (type == "Regular") priceIndex += 2;
        if (day == "Saturday") priceIndex += 3;
        else if (day == "Sunday") priceIndex += 6;

        return prices[priceIndex] * people;
    }

    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string day = Console.ReadLine();
        double price;

        if (type == "Students" && people >= 30)
            price = 0.85 * GetPrice(people, type, day);
        else if (type == "Business" && people >= 100)
            price = GetPrice(people - 10, type, day);
        else if (type == "Regular" && people >= 10 && people <= 20)
            price = 0.95 * GetPrice(people, type, day);
        else price = GetPrice(people, type, day);

        Console.WriteLine($"Total price: {price:f2}");
    }
}