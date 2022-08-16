//Create a program that keeps track of the guests that are going to a house party.
//On the first line of input, you are going to receive the number of commands that will follow.
//On the next lines, you are going to receive some of the following:  "{name} is going!"
//•	You have to add the person if they are not on the guestlist already.
//•	If the person is on the list print the following to the console: "{name} is already in the list!"
//"{name} is not going!"
//•	You have to remove the person if they are on the list. 
//•	If not, print out: "{name} is not in the list!"
//Finally, print all of the guests, each on a new line.

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        int numberOfLines = int.Parse(Console.ReadLine());
        for (int line = 0; line < numberOfLines; line++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string name = input[0];
            if (input[2] == "not") // input: "{name} is not going!"
            {
                if (list.Contains(name)) list.Remove(name);
                else Console.WriteLine($"{name} is not in the list!");
            }
            else // input: "{name} is going!"
            {
                if (list.Contains(name)) Console.WriteLine($"{name} is already in the list!");
                else list.Add(name);
            }
        }
        Console.WriteLine(string.Join("\n", list));
    }
}