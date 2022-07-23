//On the first line of the input, you will be given a text string.
//To win the competition, you have to find all hidden word pairs, read them,
//and mark the ones that are mirror images of each other.
//First of all, you have to extract the hidden word pairs. Hidden word pairs are:
//•	Surrounded by "@" or "#" (only one of the two) in the following pattern #wordOne##wordTwo# or @wordOne@@wordTwo@
//•	At least 3 characters long each (without the surrounding symbols)
//•	Made up of letters only
//If the second word, spelled backward, is the same as the first word and vice versa (casing matters!),
//they are a match, and you have to store them somewhere. Examples of mirror words: 
//#Part##traP# @leveL@@Level@ #sAw##wAs#
//•	If you don`t find any valid pairs, print: "No word pairs found!"
//•	If you find valid pairs print their count: "{valid pairs count} word pairs found!"
//•	If there are no mirror words, print: "No mirror words!"
//•	If there are mirror words print:
//"The mirror words are:
//{ wordOne} <=> { wordtwo}, { wordOne} <=> { wordtwo}, … { wordOne} <=> { wordtwo}
//"
//Input / Constraints
//•	You will recive a string.
//Output
//•	Print the proper output messages in the proper cases as described in the problem description.
//•	If there are pairs of mirror words, print them in the end, each pair separated by ", ".
//•	Each pair of mirror word must be printed with " <=> " between the words.

using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string regex = @"([@#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
        MatchCollection matches = Regex.Matches(input, regex);
        var results = new Dictionary<string, string>();

        foreach (Match match in matches)
        {

            string first = match.Groups["first"].Value;
            string second = match.Groups["second"].Value;
            string secondReversed = string.Join("", second.ToCharArray().Reverse().ToArray());
            if (first == secondReversed)
                results.Add(first, second);
        }

        if (matches.Count == 0)
            Console.WriteLine("No word pairs found!");
        else
            Console.WriteLine($"{matches.Count} word pairs found!");

        if (results.Count == 0)
            Console.WriteLine("No mirror words!");
        else
        {
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(String.Join(", ", results.Select(x => $"{x.Key} <=> {x.Value}")));
        }
    }
}