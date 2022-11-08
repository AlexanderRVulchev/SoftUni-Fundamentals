using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < wagons.Length; i++)
        {
            if (wagons[i] + people > 4)
            {
                people -= 4 - wagons[i];
                wagons[i] = 4;                
            }
            else if (wagons[i] + people <= 4)
            {
                wagons[i] += people;
                people = 0;
                break;
            }
        }

        if (people > 0)
            Console.WriteLine($"There isn't enough space! {people} people in a queue!");
        else if (wagons.Sum() < wagons.Length * 4)
            Console.WriteLine($"The lift has empty spots!");

        Console.WriteLine(String.Join(" ", wagons));
    }
}