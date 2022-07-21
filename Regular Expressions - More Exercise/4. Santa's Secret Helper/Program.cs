//After the successful second Christmas, Santa needs to gather information about the behavior of children
//to plan the presents for next Christmas.
//He has a secret helper, who is sending him encrypted information.
//Your task is to decrypt it and create a list of the good children. 
//You will receive an integer, which represents a key, and afterward some messages,
//which you must decode by subtracting the key from the value of each character.
//After the decryption, to be considered a valid match, a message should:
//-Have a name, which starts after '@' and contains only letters from the Latin alphabet
//-	Have a behavior type - "G"(good) or "N"(naughty) and must be surrounded by "!" (exclamation mark).
//The order in the message should be the child’s name -> child’s behavior.
//They can be separated from the others by any character except: '@', '-', '!', ':' and '>'.
//You will be receiving messages until you are given the “end” command.
//Afterward, print the names of the children, who will receive a present, each on a new line.
//Input / Constraints
//•	The first line holds n – the number which you have to subtract from the characters – integer in the range [1…100];
//•	On the next lines, you will be receiving encrypted messages.
//Output
//Print the names of the children, each on a new line


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        var goodChildren = new List<string>();
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string message = GetDecodedInput(input, key);
            string regex = @"[@](?<name>[A-Za-z]+)[^@!:>-]+[!](?<behaviour>[G|N])[!]";
            MatchCollection matchInfo = Regex.Matches(message, regex);

            if (matchInfo.Count == 0)
                continue;

            string childName = matchInfo[0].Groups["name"].Value;
            string childBehaviour = matchInfo[0].Groups["behaviour"].Value;

            if (childBehaviour == "G")
                goodChildren.Add(childName);
        }
        Console.WriteLine(String.Join("\n", goodChildren));
    }

    static string GetDecodedInput(string input, int key)
    {
        char[] decodedChars = input
            .ToCharArray()
            .Select(x => (char)(x - key))
            .ToArray();
        return String.Join("", decodedChars);
    }
}

