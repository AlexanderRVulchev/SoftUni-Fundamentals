//A lottery is exciting. What is not, is checking a million tickets for winnings only by hand.
//So, you are given the task to create a program that automatically checks if a ticket is a winner. 
//You are given a collection of tickets separated by commas and spaces.
//You need to check every one of them if it has a winning combination of symbols.
//A valid ticket should have exactly 20 characters.
//The winning symbols are '@', '#', '$' and '^'.
//But for a ticket to be a winner the symbol should uninterruptedly repeat
//at least 6 times in both the tickets left half and the tickets right half. 
//For example, a valid winning ticket should be something like this: 
//"Cash$$$$$$Ca$$$$$$sh"
//The left half "Cash$$$$$$" contains "$$$$$$", which is also contained in the tickets right half "Ca$$$$$$sh".
//A winning ticket should contain symbols repeating up to 10 times in both halves,
//which is considered a Jackpot (for example "$$$$$$$$$$$$$$$$$$$$").
//Input
//The input will be read from the console.
//The input consists of a single line containing all tickets separated by commas and one or more white spaces in the format:
//•	"{ticket}, {ticket}, … {ticket}"
//Output
//Print the result for every ticket in the order of their appearance, each on a separate line in the format:
//•	Invalid ticket - "invalid ticket"
//•	No match - "ticket "{ticket}" - no match"
//•	Match with length 6 to 9 - "ticket "{ticket}" - {match length}{match symbol}"
//•	Match with length 10 - "ticket "{ticket}" - {match length}{match symbol} Jackpot!"
//Constrains
//•	The number of tickets will be in the range [0 … 100]


using System;
using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string[] allTickets = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < allTickets.Length; i++)
        {
            string ticket = allTickets[i];

            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            string leftSide = String.Join("", ticket.Take(10));
            string rightSide = String.Join("", ticket.Skip(10));

            string regex = @"([@#$^])\1{5,9}";
            MatchCollection matchLeft = Regex.Matches(leftSide, regex);
            MatchCollection matchRight = Regex.Matches(rightSide, regex);

            if ((matchLeft.Count > 0 && matchRight.Count > 0) &&
                (matchLeft[0].Value.Contains(matchRight[0].Value) ||
                matchRight[0].Value.Contains(matchLeft[0].Value)))
            {
                char winningSymbol = matchLeft[0].Value[0];
                int winningLength = Math.Min(matchLeft[0].Value.Length, matchRight[0].Value.Length);

                string output = $"ticket \"{ticket}\" - {winningLength}{winningSymbol}";
                if (winningLength == 10) output += " Jackpot!";
                Console.WriteLine(output);
            }
            else
                Console.WriteLine($"ticket \"{ticket}\" - no match");
        }
    }
}