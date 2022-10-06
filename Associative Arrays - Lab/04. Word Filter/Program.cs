//Read an array of strings and take only words, whose length is an even number. Print each word on a new line.

using System;
using System.Linq;


internal class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();
        foreach (string word in words)
            Console.WriteLine(word);
    }
}

