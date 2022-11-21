using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        int numberOfMessages = int.Parse(Console.ReadLine());
        List<string> attackedPlanets = new List<string>();
        List<string> destroyedPlanets = new List<string>();

        for (int i = 0; i < numberOfMessages; i++)
        {
            string input = Console.ReadLine();
            string decodedInput = GetDecodedInputMessage(input);
            string regexPattern = @"@(?<planet>[A-Za-z]+)[^@:!\->]*:(?<population>\d+)[^@:!\->]*!(?<action>[A|D])![^@:!\->]*->(?<soldiers>\d+)";
            MatchCollection matchMessage = Regex.Matches(decodedInput, regexPattern);
            if (matchMessage.Count > 0)
            {
                if (matchMessage[0].Groups["action"].Value == "A")
                    attackedPlanets.Add(matchMessage[0].Groups["planet"].Value);
                else
                    destroyedPlanets.Add(matchMessage[0].Groups["planet"].Value);
            }
        }

        Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
        if (attackedPlanets.Count > 0)
            Console.WriteLine(String.Join(Environment.NewLine, attackedPlanets.OrderBy(x => x).Select(x => $"-> {x}")));

        Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
        if (destroyedPlanets.Count > 0)
            Console.WriteLine(String.Join(Environment.NewLine, destroyedPlanets.OrderBy(x => x).Select(x => $"-> {x}")));
    }

    static string GetDecodedInputMessage(string input)
    {
        MatchCollection starLetters = Regex.Matches(input, @"[starSTAR]");
        StringBuilder sb = new StringBuilder();
        foreach (char c in input)
            sb.Append((char)(c - starLetters.Count));

        return sb.ToString();
    }
}