//We are placing N orders at a time. You need to calculate the price on the following formula:
//((daysInMonth * capsulesCount) * pricePerCapsule)
//Input / Constraints
//•	On the first line, you will receive integer N – the count of orders the shop will receive.
//•	For each order you will receive the following information:
//o Price per capsule - the floating-point number in the range [0.00…1000.00]
//o Days – integer in the range [1…31]
//o Capsules count - integer in the range [0…2000]
//The input will be in the described format, there is no need to check it explicitly.
//Output
//The output should consist of N + 1 line. For each order you must print a single line in the following format:
//•	"The price for the coffee is: ${price}"
//On the last line you need to print the total price in the following format:
//•	 "Total: ${totalPrice}"
//The price must be formatted to 2 decimal places. 

using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double allOrdersCost = 0;
        for (int i = 0; i < n; i++)
        {
            double priceCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsules = int.Parse(Console.ReadLine());
            double orderPrice = priceCapsule * days * capsules;
            Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            allOrdersCost += orderPrice;
        }
        Console.WriteLine($"Total: ${allOrdersCost:f2}");
    }
}