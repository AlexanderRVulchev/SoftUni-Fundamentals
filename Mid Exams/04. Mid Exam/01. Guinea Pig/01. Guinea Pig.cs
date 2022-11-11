using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        double food = double.Parse(Console.ReadLine());
        double hay = double.Parse(Console.ReadLine());
        double cover = double.Parse(Console.ReadLine());
        double weight = double.Parse(Console.ReadLine());

        for (int day = 1; day <= 30; day++)
        {
            food -= 0.3;
            if (day % 2 == 0) hay -= 0.05 * food;
            if (day % 3 == 0) cover -= weight / 3.0;
            if (food <= 0 || hay <= 0 || cover <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
                return;
            }
        }

        Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
    }
}