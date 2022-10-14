//Create a program that receives a single string and on the first line prints all the digits, on the second –
//all the letters, and on the third – all the other characters.
//There will always be at least one digit, one letter, and one other character.

using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        StringBuilder digits = new StringBuilder();
        StringBuilder letters = new StringBuilder();
        StringBuilder other = new StringBuilder();

        foreach (char c in inputString)
        {
            if (char.IsDigit(c)) digits.Append(c);
            else if (char.IsLetter(c)) letters.Append(c);
            else other.Append(c);
        }
        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(other);
    }
}
