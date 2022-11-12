using System;


internal class Program
{
    static void Main()
    {
        string[] rooms = Console.ReadLine().Split('|');
        int health = 100;
        int bitcoins = 0;


        for (int i = 0; i < rooms.Length; i++)
        {
            string[] thisInput = rooms[i].Split(' ');
            string command = thisInput[0];
            int number = int.Parse(thisInput[1]);

            switch (command)
            {
                case "potion":
                    int healedFor = number;
                    if (health + number > 100) healedFor = 100 - health;
                    health += healedFor;
                    Console.WriteLine($"You healed for {healedFor} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                    break;
                case "chest":
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoins += number;
                    break;
                default:
                    health -= number;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    Console.WriteLine($"You slayed {command}.");
                    break;
            }
        }
        Console.WriteLine("You've made it!");
        Console.WriteLine($"Bitcoins: {bitcoins}");
        Console.WriteLine($"Health: {health}");
    }
}