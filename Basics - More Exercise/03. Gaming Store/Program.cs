//Create a program, which helps you buy the games. The valid games are the following games in this table:
//Name Price
//OutFall 4	$39.99
//CS: OG	$15.99
//Zplinter Zell	$19.99
//Honored 2	$59.99
//RoverWatch	$29.99
//RoverWatch Origins Edition	$39.99
//On the first line, you will receive your current balance – a floating-point number in the range [0.00…5000.00].
//Until you receive the command "Game Time", you have to keep buying games.
//When a game is bought, the user’s balance decreases by the price of the game.
//Additionally, the program should obey the following conditions:
//•	If a game the user is trying to buy is not present in the table above,
//print "Not Found" and read the next line.
//•	If at any point, the user has $0 left, print "Out of money!" and end the program.
//•	Alternatively, if the user is trying to buy a game that they can’t afford,
//print "Too Expensive" and read the next line.
//•	If the game exists and the player has the money for it, print "Bought {nameOfGame}"
//When you receive "Game Time", print the user’s remaining money and total spent on games,
//rounded to the 2nd decimal place.

using System;


class Program
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        double initialBalance = balance;
        string input = Console.ReadLine();
        while (input != "Game Time")
        {
            double price = -1;
            switch (input)
            {
                case "OutFall 4": price = 39.99; break;
                case "CS: OG": price = 15.99; break;
                case "Zplinter Zell": price = 19.99; break;
                case "Honored 2": price = 59.99; break;
                case "RoverWatch": price = 29.99; break;
                case "RoverWatch Origins Edition": price = 39.99; break;
                default:
                    Console.WriteLine("Not Found");
                    break;
            }
            if (price > balance) Console.WriteLine("Too Expensive");
            else if (price != -1)
            {
                balance -= price;
                Console.WriteLine($"Bought {input}");
            }
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Total spent: ${initialBalance - balance:f2}. Remaining: ${balance:f2}");
    }
}