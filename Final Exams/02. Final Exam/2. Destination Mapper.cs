//You will be given a string representing some places on the map. You have to filter only the valid ones.
//A valid location is:
//•	Surrounded by "=" or "/" on both sides (the first and the last symbols must match)
//•	After the first "=" or "/" there should be only letters (the first must be upper-case,
//other letters could be upper or lower-case)
//•	The letters must be at least 3
//Example: In the string "=Hawai=/Cyprus/=Invalid/invalid==i5valid=/I5valid/=i=" only the first two locations are valid.
//After you have matched all the valid locations, you have to calculate travel points.
//They are calculated by summing the lengths of all the valid destinations that you have found on the map. 
//In the end, on the first line, print: "Destinations: {destinations joined by ', '}".
//On the second line, print "Travel Points: {travel_points}".
//Input / Constraints
//•	You will receive a string representing the locations on the map
//•	JavaScript: you will receive a single parameter: string
//Output
//•	Print the messages described above

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string regex = @"([=\/])(?<destination>[A-Z][A-Za-z]{2,})\1";
        MatchCollection matches = Regex.Matches(input, regex);
        List<string> destinations = new List<string>();
        int travelPoints = 0;
        for (int i = 0; i < matches.Count; i++)
        {
            string destination = matches[i].Groups["destination"].Value;
            travelPoints += destination.Length;
            destinations.Add(destination);
        }
        Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
        Console.WriteLine($"Travel Points: {travelPoints}");
    }
}