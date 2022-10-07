//Create a program that counts all characters in a string, except for space (' '). 
//Print all the occurrences in the following format:
//"{char} -> {occurrences}"


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        char[] chars = Console.ReadLine().Where(c => c != ' ').ToArray();
        Dictionary<char, int> charOccurence = new Dictionary<char, int>();
        foreach (char c in chars)
        {
            if (!charOccurence.ContainsKey(c))
                charOccurence.Add(c, 0);
            charOccurence[c]++;
        }
        foreach (KeyValuePair<char, int> c in charOccurence)        
            Console.WriteLine($"{c.Key} -> {c.Value}");        
    }
}