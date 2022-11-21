using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


internal class Program
{
    static void Main()
    {
        var racersDistances = GetRacersNames();
        string input;
        while ((input = Console.ReadLine()) != "end of race")
        {
            KeyValuePair<string, int> newRacerInfo = GetNewRacerInfo(input);

            if (racersDistances.ContainsKey(newRacerInfo.Key))
                racersDistances[newRacerInfo.Key] += newRacerInfo.Value;
        }

        string[] bestRacers = racersDistances.OrderByDescending(x => x.Value)
            .Take(3)
            .Select(x => x.Key)
            .ToArray();

        Console.WriteLine($"1st place: {bestRacers[0]}");
        Console.WriteLine($"2nd place: {bestRacers[1]}");
        Console.WriteLine($"3rd place: {bestRacers[2]}");
    }

    private static KeyValuePair<string, int> GetNewRacerInfo(string input)
    {
        string regexName = @"[A-Za-z]";
        string regexDistance = @"\d";
        MatchCollection nameMatch = Regex.Matches(input, regexName);
        MatchCollection distanceMatch = Regex.Matches(input, regexDistance);

        StringBuilder name = new StringBuilder();
        int distance = 0;

        foreach (Match letter in nameMatch)
            name.Append(letter.Value);

        foreach (Match digit in distanceMatch)
            distance += int.Parse(digit.Value);

        return new KeyValuePair<string, int>(name.ToString(), distance);
    }

    static Dictionary<string, int> GetRacersNames()
    {
        var dicNames = new Dictionary<string, int>();
        string[] namesOfRacers = Console.ReadLine().Split(", ");
        foreach (var name in namesOfRacers)
            dicNames.Add(name, 0);
        return dicNames;
    }

}