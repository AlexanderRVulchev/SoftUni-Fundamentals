//Create a program that reads N lines of strings and extracts the name and age of a given person.
//The name of the person will be between '@' and '|'. The person’s age will be between '#' and '*'. 
//Example: "Hello my name is @Peter| and I am #20* years old."
//For each found name and age print a line in the following format "{name} is {age} years old."


using System;

internal class Program
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLines; i++)
        {
            string input = Console.ReadLine();

            string[] nameChunks = input.Split('@', '|');
            string name = nameChunks[1];

            string[] ageChunks = input.Split('#', '*');
            string age = ageChunks[1];

            Console.WriteLine($"{name} is {age} years old.");
        }
    }
}