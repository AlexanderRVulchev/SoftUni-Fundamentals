//Your task is to write a program that extracts emojis from a text and find the threshold based on the input.
//You have to get your cool threshold. It is obtained by multiplying all the digits found in the input.
//The cool threshold could be a huge number, so be mindful.
//An emoji is valid when:
//•	It is surrounded by 2 characters, either "::" or "**"
//•	It is at least 3 characters long(without the surrounding symbols)
//•	It starts with a capital letter
//•	Continues with lowercase letters only
//Examples of valid emojis: ::Joy::, **Banana * *, ::Wink::
//Examples of invalid emojis: ::Joy * *, ::fox:es:, **Monk3ys * *, :Snak::Es::
//You need to count all valid emojis in the text and calculate their coolness.
//The coolness of the emoji is determined by summing all the ASCII values of all letters in the emoji. 
//Examples: ::Joy:: - 306, **Banana * *-577, ::Wink:: - 409
//You need to print the result of the cool threshold and,
//after that to take all emojis out of the text, count them and print only the cool ones on the console.
//Input
//•	On the single input, you will receive a piece of string. 
//Output
//•	On the first line of the output, print the obtained Cool threshold in the format:
//"Cool threshold: {coolThresholdSum}"
//•	On the following line, print the count of all emojis found in the text in format:
//"{countOfAllEmojis} emojis found in the text. The cool ones are:
//{ cool emoji 1}
//{ cool emoji 2}
//…
//{ cool emoji N}
//"
//Constraints
//There will always be at least one digit in the text!

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        MatchCollection digits = Regex.Matches(input, @"\d");
        MatchCollection emojis = Regex.Matches(input, @"([:*])\1[A-Z][a-z]{2,}\1\1");

        BigInteger coolThreshold = new BigInteger(1);
        foreach (Match digit in digits)
            coolThreshold *= int.Parse(digit.Value);

        List<string> coolEmojis = new List<string>();
        foreach (Match emoji in emojis)
        {
            string emojiString = emoji.Value;
            int emojiValue = 0;
            for (int i = 0; i < emoji.Value.Length; i++)
            {
                if (char.IsLetter(emojiString[i]))
                    emojiValue += (int)emojiString[i];
            }
            if (emojiValue > coolThreshold)
                coolEmojis.Add(emojiString);
        }

        Console.WriteLine($"Cool threshold: {coolThreshold}");
        Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
        Console.WriteLine(String.Join("\n", coolEmojis));
    }
}