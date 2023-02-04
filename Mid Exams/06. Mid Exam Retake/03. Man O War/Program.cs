using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        int[] pirateShip = Console.ReadLine()
            .Split(new[] { ">", " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int[] warship = Console.ReadLine()
            .Split(new[] { ">", " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int maximumHealth = int.Parse(Console.ReadLine());
        string input;

        while ((input = Console.ReadLine()) != "Retire")
        {
            string[] tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];
            if (command == "Fire")
                Fire(warship, int.Parse(tokens[1]), int.Parse(tokens[2]));
            else if (command == "Defend")
                Defend(pirateShip, int.Parse(tokens[1]), int.Parse(tokens[2]), int.Parse(tokens[3]));
            else if (command == "Repair")
                Repair(pirateShip, int.Parse(tokens[1]), int.Parse(tokens[2]), maximumHealth);
            else if (command == "Status")
                Status(pirateShip, maximumHealth);

            if (pirateShip.Any(x => x <= 0))
            {
                Console.WriteLine("You lost! The pirate ship has sunken.");
                return;
            }
            if (warship.Any(x => x <= 0))
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
                return;
            }
        }
        Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
        Console.WriteLine($"Warship status: {warship.Sum()}");
    }

    private static void Status(int[] pirateShip, int maximumHealth)
    {
        int countSectionsNeedingRepair = pirateShip.Where(x => x < 0.2 * maximumHealth).Count();
        Console.WriteLine($"{countSectionsNeedingRepair} sections need repair.");
    }

    private static void Repair(int[] pirateShip, int index, int health, int maximumHealth)
    {
        if (index < 0 || index >= pirateShip.Length) return;
        pirateShip[index] = Math.Min(pirateShip[index] + health, maximumHealth);
    }

    private static void Defend(int[] pirateShip, int startIndex, int endIndex, int damage)
    {
        if (startIndex < 0 || startIndex >= pirateShip.Length ||
            endIndex < 0 || endIndex >= pirateShip.Length)
            return;
        for (int i = startIndex; i <= endIndex; i++)
            pirateShip[i] -= damage;
    }

    private static void Fire(int[] warship, int index, int damage)
    {
        if (index < 0 || index >= warship.Length) return;
        warship[index] -= damage;
    }
}