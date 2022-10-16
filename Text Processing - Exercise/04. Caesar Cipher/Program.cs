//Create a program that returns an encrypted version of the same text.
//Encrypt the text by shifting each character with three positions forward.
//For example, A would be replaced by D, B would become E, and so on
//. Print the encrypted text.

using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        
        foreach (char c in input)
            result.Append((char)(c + 3));
        Console.WriteLine(result);
    }
}