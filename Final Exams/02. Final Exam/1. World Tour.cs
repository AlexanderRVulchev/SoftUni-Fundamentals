//On the first line, you will be given a string containing all of your stops. Until you receive the command "Travel",
//you will be given some commands to manipulate that initial string. The commands can be:
//•	"Add Stop:{index}:{string}":
//o Insert the given string at that index only if the index is valid
//•	"Remove Stop:{start_index}:{end_index}":
//o Remove the elements of the string from the starting index to the end index (inclusive) if both indices are valid
//•	"Switch:{old_string}:{new_string}":
//o If the old string is in the initial string, replace it with the new one(all occurrences)
//Note: After each command, print the current state of the string
//After the "Travel" command, print the following: "Ready for world tour! Planned stops: {string}"
//Input / Constraints
//•	JavaScript: you will receive a list of strings
//•	An index is valid if it is between the first and the last element index (inclusive) in the sequence.
//Output
//•	Print the proper output messages in the proper cases as described in the problem description

using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder stops = new StringBuilder(Console.ReadLine());
        string input;
        while ((input = Console.ReadLine()) != "Travel")
        {
            string[] cmd = input.Split(':');
            switch (cmd[0])
            {
                case "Add Stop":
                    AddStop(stops, cmd); break;
                case "Remove Stop":
                    RemoveStop(stops, cmd); break;
                case "Switch":
                    stops.Replace(cmd[1], cmd[2]); break;
            }
            Console.WriteLine(stops.ToString());
        }
        Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
    }

    private static void AddStop(StringBuilder stops, string[] cmd)
    {
        int index = int.Parse(cmd[1]);
        string stringToInsert = cmd[2];
        if (index >= 0 && index < stops.Length)
            stops.Insert(index, stringToInsert);
    }

    private static void RemoveStop(StringBuilder stops, string[] cmd)
    {
        int startIndex = int.Parse(cmd[1]);
        int endIndex = int.Parse(cmd[2]);
        if (startIndex >= 0 && startIndex < stops.Length &&
            endIndex >= 0 && endIndex < stops.Length)
        {
            stops.Remove(startIndex, endIndex - startIndex + 1);
        }
    }
}