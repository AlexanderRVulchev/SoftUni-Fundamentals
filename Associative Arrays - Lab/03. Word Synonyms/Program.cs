//Create a program, which keeps a dictionary with synonyms. The key of the dictionary will be the word.
//The value will be a list of all the synonyms of that word. You will be given a number n – the count of the words.
//After each word, you will be given a synonym, so the count of lines you have to read from the console is 2 * n.
//You will be receiving a word and a synonym each on a separate line like this:
//•	{ word}
//•	{ synonym}
//If you get the same word twice, just add the new synonym to the list.
//Print the words in the following format:
//"{word} - {synonym1, synonym2, …, synonymN}"


using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
        int countWords = int.Parse(Console.ReadLine());
        for (int i = 0; i < countWords; i++)
        {
            string newWord = Console.ReadLine();
            string newSynonym = Console.ReadLine();
            if (!words.ContainsKey(newWord))
                words.Add(newWord, new List<string>());
            words[newWord].Add(newSynonym);
        }
        foreach (KeyValuePair<string, List<string>> word in words)
        {
            Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
        }
    }
}

