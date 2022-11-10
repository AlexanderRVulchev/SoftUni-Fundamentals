using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        int energy = int.Parse(Console.ReadLine());
        int wonBattles = 0;
        string input;

        while ((input = Console.ReadLine()) != "End of battle")
        {
            int distance = int.Parse(input);
            if (distance > energy)
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                return;
            }
            else
            {
                wonBattles++;
                energy -= distance;
            }


            if (wonBattles % 3 == 0) energy += wonBattles;
        }
        Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
    }
}