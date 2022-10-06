//Create a program that extracts all elements from a given sequence of words that are present in it an odd number of times (case-insensitive).
//•	Words are given on a single line, space-separated.
//•	Print the result elements in lowercase, in their order of appearance.

using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        Dictionary<string, int> wordsCounts = new Dictionary<string, int>();
        string[] input = Console.ReadLine().ToLower().Split();
        foreach (string word in input)
        {
            if (!wordsCounts.ContainsKey(word))
                wordsCounts.Add(word, 0);
            wordsCounts[word]++;
        }        
        foreach (KeyValuePair<string, int> word in wordsCounts)
        {
            if (word.Value % 2 == 1)
            Console.Write(word.Key + " ");
        }
    }
}