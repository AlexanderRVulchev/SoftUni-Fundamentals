//Create a program that prints a sum of all characters between two given characters (their ASCII code).
//In the first line, you will get a character. On the second line, you get another character.
//On the last line, you get a random string. Find all the characters between the two given and print their ASCII sum.

using System;

internal class Program
{
    static void Main()
    {
        char inputChar1 = char.Parse(Console.ReadLine());
        char inputChar2 = char.Parse(Console.ReadLine());

        char lowerChar = (char)Math.Min(inputChar1, inputChar2);
        char higherChar = (char)Math.Max(inputChar1, inputChar2);

        string inputString = Console.ReadLine();
        int sum = 0;

        foreach (char c in inputString)
        {
            if (c > lowerChar && c < higherChar)
                sum += c;
        }

        Console.WriteLine(sum);
    }
}

