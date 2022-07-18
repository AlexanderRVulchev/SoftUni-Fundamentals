//Create a program that prints whether a given character is upper-case or lower case.

using System;


class Program
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());
        Console.WriteLine(symbol.ToString() == symbol.ToString().ToLower() ? "lower-case" : "upper-case");
    }
}
