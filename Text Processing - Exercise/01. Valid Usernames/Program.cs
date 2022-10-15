//Create a program that reads user names on a single line (joined by ", ") and prints all valid usernames. 
//A valid username:
//•	Has length between 3 and 16 characters and
//•	Contains only letters, numbers, hyphens, and underscores


using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        string[] inputNames = Console.ReadLine().Split(", ");
        var validNames = new List<string>();
        foreach (string name in inputNames)
        {
            if (name.Length < 3 || name.Length > 16) 
                continue;

            bool allCharsAreValid = true;
            foreach (char c in name)            
                if (!IsValidChar(c))
                {
                    allCharsAreValid = false;
                    break;
                }
            
            if (allCharsAreValid) validNames.Add(name);
        }
        Console.WriteLine(String.Join(Environment.NewLine, validNames));
    }

    private static bool IsValidChar(char c)
       => (char.IsLetterOrDigit(c) || c == '-' || c == '_');
}
