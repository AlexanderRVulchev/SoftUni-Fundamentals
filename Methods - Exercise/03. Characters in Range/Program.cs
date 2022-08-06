//Create a method that receives two characters and prints all the characters between them according to ASCII (on a single line).
//NOTE: If the second letter's ASCII value is less than that of the first one then the two initial letters should be swapped.

using System;
using System.Linq;
using System.Text;

class Program
{
    static void PrintAllCharsInBetween(char first, char second)
    {
        for (int i = first + 1; i < second; i++)
        {
            Console.Write((char)i + " ");
        }
    }

    static void Main()
    {
        char symbol1 = char.Parse(Console.ReadLine());
        char symbol2 = char.Parse(Console.ReadLine());
        if (symbol1 < symbol2) PrintAllCharsInBetween(symbol1, symbol2);
        else PrintAllCharsInBetween(symbol2, symbol1);
    }
}