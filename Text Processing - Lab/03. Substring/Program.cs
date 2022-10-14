//On the first line, you will receive a string.
//On the second line, you will receive a second string.
//Create a program that removes all of the occurrences of the first string in the second until there is no match.
//At the end print the remaining string.

using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string subString = Console.ReadLine();
        string mainString = Console.ReadLine();

        while (mainString.Contains(subString))
        {
            int index = mainString.IndexOf(subString);
            mainString = mainString.Remove(index, subString.Length);
        }

        Console.WriteLine(mainString);
    }
}