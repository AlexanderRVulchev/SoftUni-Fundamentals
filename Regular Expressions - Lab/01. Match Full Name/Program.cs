//Write a C# Program to match full names from a list of names and print them on the console.
//Writing the Regular Expression
//First, create a regular expression to match a valid full name, according to these conditions:
//•	A valid full name has the following characteristics:
//o It consists of two words.
//o	Each word starts with a capital letter.
//o	After the first letter, it only contains lowercase letters afterward.
//o	Each of the two words should be at least two letters long.
//o	The two words are separated by a single space.


using System;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
        string names = Console.ReadLine();

        MatchCollection matchedNames = Regex.Matches(names, regex);

        foreach (Match name in matchedNames)
            Console.Write(name.Value + " ");

        Console.WriteLine();
    }
}
