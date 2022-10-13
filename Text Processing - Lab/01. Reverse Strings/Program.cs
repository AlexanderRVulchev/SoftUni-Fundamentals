//You will be given a series of strings until you receive an "end" command.
//Write a program that reverses strings and prints each pair on a separate line in the format "{word} = {reversed word}".

using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string word;
        while ((word = Console.ReadLine()) != "end")
        {            
            StringBuilder reversedWord = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)            
                reversedWord.Append(word[i]);

            Console.WriteLine($"{word} = {reversedWord}");
        }
    }
}
