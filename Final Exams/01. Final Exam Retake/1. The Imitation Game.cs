﻿//On the first line of the input, you will receive the encrypted message.
//After that, until the "Decode" command is given, you will be receiving strings with instructions
//for different operations that need to be performed upon the concealed message
//to interpret it and reveal its true content. There are several types of instructions, split by '|'
//•	"Move {number of letters}":
//o Moves the first n letters to the back of the string
//•	"Insert {index} {value}":
//o Inserts the given value before the given index in the string
//•	"ChangeAll {substring} {replacement}":
//o Changes all occurrences of the given substring with the replacement text
//Input / Constraints
//•	On the first line, you will receive a string with a message.
//•	On the following lines, you will be receiving commands, split by '|' .
//Output
//•	After the "Decode" command is received, print this message:
//"The decrypted message is: {message}"


using System;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        StringBuilder message = new StringBuilder(Console.ReadLine());
        string input;
        while ((input = Console.ReadLine()) != "Decode")
        {
            string[] tokens = input.Split('|');
            switch (tokens[0])
            {
                case "Move":
                    int length = int.Parse(tokens[1]);
                    string substring = string.Join("", message.ToString().Take(length));
                    message.Remove(0, length);
                    message.Append(substring);
                    break;
                case "Insert":
                    int index = int.Parse(tokens[1]);
                    string chunk = tokens[2];
                    if (index == message.Length)
                        message.Append(chunk);
                    else
                        message.Insert(index, chunk);
                    break;
                case "ChangeAll":
                    string toReplace = tokens[1];
                    string replacement = tokens[2];
                    message.Replace(toReplace, replacement);
                    break;
            }
        }
        Console.WriteLine($"The decrypted message is: {message}");
    }
}