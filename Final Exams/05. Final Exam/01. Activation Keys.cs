//The first line of the input will be your raw activation key.
//It will consist of letters and numbers only. 
//After that, until the "Generate" command is given,
//you will be receiving strings with instructions for different operations
//that need to be performed upon the raw activation key.
//There are several types of instructions, split by ">>>":
//•	"Contains>>>{substring}":
//o If the raw activation key contains the given substring,
//prints: "{raw activation key} contains {substring}".
//o Otherwise, prints: "Substring not found!"
//•	"Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
//o Changes the substring between the given indices (the end index is exclusive)
//to upper or lower case and then prints the activation key.
//o	All given indexes will be valid.
//•	"Slice>>>{startIndex}>>>{endIndex}":
//o Deletes the characters between the start and end indices
//(the end index is exclusive) and prints the activation key.
//o	Both indices will be valid.
//Input
//•	The first line of the input will be a string consisting of letters and numbers only. 
//•	After the first line, until the "Generate" command is given, you will be receiving strings.
//Output
//•	After the "Generate" command is received, print:
//o "Your activation key is: {activation key}"

using System;


class Program
{
    static void Main()
    {
        string key = Console.ReadLine();
        string input;
        while ((input = Console.ReadLine()) != "Generate")
        {
            string[] cmd = input.Split(">>>");
            switch (cmd[0])
            {
                case "Contains": Contains(key, cmd[1]); break;
                case "Flip": key = Flip(key, cmd); break;
                case "Slice": key = Slice(key, cmd); break;
            }
        }
        Console.WriteLine($"Your activation key is: {key}");
    }

    private static void Contains(string key, string substring)
    {
        if (key.Contains(substring))
            Console.WriteLine($"{key} contains {substring}");
        else
            Console.WriteLine("Substring not found!");
    }

    private static string Flip(string key, string[] cmd)
    {
        int startIndex = int.Parse(cmd[2]);
        int endIndex = int.Parse(cmd[3]);
        string substring = key.Substring(startIndex, endIndex - startIndex);
        key = key.Remove(startIndex, endIndex - startIndex);

        if (cmd[1] == "Upper")
            substring = substring.ToUpper();
        else if (cmd[1] == "Lower")
            substring = substring.ToLower();

        key = key.Insert(startIndex, substring);
        Console.WriteLine(key);
        return key;
    }

    private static string Slice(string key, string[] cmd)
    {
        int startIndex = int.Parse(cmd[1]);
        int endIndex = int.Parse(cmd[2]);
        key = key.Remove(startIndex, endIndex - startIndex);
        Console.WriteLine(key);
        return key;
    }
}