//Create a program that reads the path to a file and subtracts the file name and its extension.

using System;

internal class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(@"\");
        string[] tokens = input[input.Length - 1].Split('.');
        string fileName = tokens[0];
        string fileExtension = tokens[1];
        Console.WriteLine($"File name: {fileName}");
        Console.WriteLine($"File extension: {fileExtension}");
    }
}
