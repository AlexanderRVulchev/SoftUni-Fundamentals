using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> sequence = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        string input;
        int moves = 0;
        while ((input = Console.ReadLine()) != "end")
        {
            moves++;
            int[] indexes = input
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (indexes[0] == indexes[1] ||
                indexes[0] < 0 ||
                indexes[1] < 0 ||
                indexes[0] >= sequence.Count ||
                indexes[1] >= sequence.Count)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                sequence.Insert(sequence.Count / 2, "-" + moves + "a");
                sequence.Insert(sequence.Count / 2, "-" + moves + "a");
            }
            else if (sequence[indexes[0]] == sequence[indexes[1]])
            {
                Console.WriteLine($"Congrats! You have found matching elements - {sequence[indexes[0]]}!");
                if (indexes[0] < indexes[1])
                {
                    sequence.RemoveAt(indexes[1]);
                    sequence.RemoveAt(indexes[0]);
                }
                else
                {
                    sequence.RemoveAt(indexes[0]);
                    sequence.RemoveAt(indexes[1]);
                }
            }
            else Console.WriteLine("Try again!");

            if (sequence.Count == 0)
            {
                Console.WriteLine($"You have won in {moves} turns!");
                return;
            }
        }

        Console.WriteLine("Sorry you lose :(");
        Console.WriteLine(String.Join(" ", sequence));
    }
}