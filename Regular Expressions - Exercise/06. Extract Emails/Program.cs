using System;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        MatchCollection matchEMails = Regex.Matches(input,
            @"\s\b[a-zA-Z\d]+([-._][a-zA-Z\d]+)*[@][a-zA-z]+([-][a-zA-z]+)*([.]([a-zA-z]+([-][a-zA-z]+)*))+");
        Console.WriteLine(String.Join("\n", matchEMails));
    }
}