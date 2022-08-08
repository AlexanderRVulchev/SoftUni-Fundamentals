//You will receive a single string.
//Create a method that prints the character found at its middle.
//If the length of the string is even there are two middle characters.

using System;


class Program
{
    static void PrintMiddleChars(string str)
    {
        if (str.Length % 2 == 0)
            Console.WriteLine($"{str[str.Length / 2 - 1]}{str[str.Length / 2]}");
        else Console.WriteLine(str[str.Length / 2]);
    }

    static void Main()
    {
        string input = Console.ReadLine();
        PrintMiddleChars(input);
    }
}