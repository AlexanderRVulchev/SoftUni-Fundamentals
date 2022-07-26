//Enter a number in range 1-7 and print out the word representing it or "Invalid Day!". Use an array of strings.

using System;


class Program
{
    static void Main()
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int n = int.Parse(Console.ReadLine());
        if (n > 0 && n < 8)
        {
            Console.WriteLine(days[n - 1]);
        }
        else Console.WriteLine("Invalid day!");
    }
}