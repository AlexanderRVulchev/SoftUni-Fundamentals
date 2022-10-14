//Create a program that takes a text and a string of banned words.
//All words included in the ban list should be replaced with asterisks "*", equal to the word's length.
//The entries in the ban list will be separated by a comma and space ", ".
//The ban list should be entered on the first input line and the text on the second input line. 

using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(", ");                
        string bigText = Console.ReadLine();
        
        foreach (string word in bannedWords)
        {
            string replacement = new String('*', word.Length);            
            
            while (bigText.Contains(word))
                bigText = bigText.Replace(word, replacement);
        }

        Console.WriteLine(bigText);
    }
}