//Every gamer knows what rage-quitting means.
//It’s basically when you’re just not good enough and you blame everybody else for losing a game.
//You press the CAPS LOCK key on the keyboard and flood the chat with gibberish to show your frustration.
//Chochko is a gamer and a bad one at that. He asks for your help;
//he wants to be the most annoying kid on his team, so when he rage-quits he wants something truly spectacular.
//He’ll give you a series of strings followed by non-negative numbers, e.g. "a3";
//you need to print on the console each string repeated N times;
//convert the letters to uppercase beforehand. In the example, you need to write back "AAA". 
//On the output, print first a statistic of the number of unique symbols used
//(the casing of letters is irrelevant, meaning that 'a' and 'A' are the same);
//the format should be "Unique symbols used {0}". Then, print the rage message itself.
//The strings and numbers will not be separated by anything.
//The input will always start with a string and for each string, there will be a corresponding number.
//The entire input will be given on a single line; Chochko is too lazy to make your job easier.
//Input
//•	The input data should be read from the console.
//•	It consists of a single line holding a series of string-number sequences.
//•	The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//•	The output should be printed on the console. It should consist of exactly two lines.
//•	On the first line, print the number of unique symbols used in the message.
//•	On the second line, print the resulting rage message itself.


using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();

        MatchCollection matchesByPattern = Regex.Matches(input, @"(?<string>[^\d]+)(?<number>[\d]+)");
        StringBuilder resultString = new StringBuilder();

        foreach (Match match in matchesByPattern)        
            resultString.Append(GetRepeatedText(match));
        
        char[] uniqueSymbols = GetUniqueSymbols(resultString.ToString());
     
        Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
        Console.WriteLine($"{resultString}");
    }
        
    static string GetRepeatedText(Match match)
    {
        StringBuilder sb = new StringBuilder();
        string rageText = match.Groups["string"].Value;
        int numberOfRepeats = int.Parse(match.Groups["number"].Value);

        for (int i = 0; i < numberOfRepeats; i++)
            sb.Append(rageText);

        return sb.ToString();
    }

    static char[] GetUniqueSymbols(string result)
    {
        var uniqueSymbolsList = new List<char>();
        foreach (char c in result)
        {
            if (c >= '0' && c <= '9') continue;
            if (!uniqueSymbolsList.Contains(c))
                uniqueSymbolsList.Add(c);            
        }
        return uniqueSymbolsList.ToArray();
    }
}
