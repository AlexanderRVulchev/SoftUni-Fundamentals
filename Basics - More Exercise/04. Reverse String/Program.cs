//Create a program which reverses a string and print it on the console.

using System;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
    }
}