//Create a program that takes 3 lines of characters and prints them in reversed order with a space between them.

using System;


class Program
{
    static void Main()
    {
        char[] symbols = new char[3];
        for (int i = 2; i >= 0; i--) symbols[i] = char.Parse(Console.ReadLine());
        Console.WriteLine(String.Join(" ", symbols));
    }
}