//On the first line of the input, you will receive the concealed message.
//After that, until the "Reveal" command is given, you will receive strings with instructions
//for different operations that need to be performed upon the concealed message to interpret it
//and reveal its actual content. There are several types of instructions, split by ":|:"
//•	"InsertSpace:|:{index}":
//o Inserts a single space at the given index. The given index will always be valid.
//•	"Reverse:|:{substring}":
//o If the message contains the given substring, cut it out, reverse it and add it at the end of the message. 
//o	If not, print "error".
//o	This operation should replace only the first occurrence of the given substring if there are two or more occurrences.
//•	"ChangeAll:|:{substring}:|:{replacement}":
//o Changes all occurrences of the given substring with the replacement text.
//Input / Constraints
//•	On the first line, you will receive a string with a message.
//•	On the following lines, you will be receiving commands, split by ":|:".
//Output
//•	After each set of instructions, print the resulting string. 
//•	After the "Reveal" command is received, print this message:
//"You have a new text message: {message}"

using System;
using System.Linq;


class Program
{
    static void Main()
    {
        string message = Console.ReadLine();
        string input;
        while ((input = Console.ReadLine()) != "Reveal")
        {
            string[] tokens = input.Split(":|:");
            if (tokens[0] == "InsertSpace")
            {
                message = message.Insert(int.Parse(tokens[1]), " ");
            }
            else if (tokens[0] == "Reverse")
            {
                string substring = tokens[1];
                if (!message.Contains(substring))
                {
                    Console.WriteLine("error");
                    continue;
                }
                message = message.Remove(message.IndexOf(substring), substring.Length);
                string reversedSubstring = string.Join("", substring.ToCharArray().Reverse());
                message += reversedSubstring;
            }
            else if (tokens[0] == "ChangeAll")
            {
                message = message.Replace(tokens[1], tokens[2]);
            }
            Console.WriteLine(message);
        }

        Console.WriteLine($"You have a new text message: {message}");
    }
}