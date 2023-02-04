using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        int totalDays = int.Parse(Console.ReadLine());
        double dailyPlunder = double.Parse(Console.ReadLine());
        double expectedPlunder = double.Parse(Console.ReadLine());
        double plunder = 0;

        for (int day = 1; day <= totalDays; day++)
        {
            plunder += dailyPlunder;
            if (day % 3 == 0) plunder += 0.5 * dailyPlunder;
            if (day % 5 == 0) plunder *= 0.7;
        }

        Console.WriteLine(plunder >= expectedPlunder ?
            $"Ahoy! {plunder:f2} plunder gained." :
            $"Collected only {plunder / expectedPlunder * 100:f2}% of the plunder.");
    }
}