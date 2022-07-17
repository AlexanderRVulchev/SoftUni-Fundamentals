//Read two names and a delimiter. Print the names joined by the delimiter.

using System;


class Program
{
    static void Main()
    {
        string[] input = new string[3];
        input[0] = Console.ReadLine();
        input[2] = Console.ReadLine();
        input[1] = Console.ReadLine();
        Console.WriteLine(string.Join(string.Empty, input));
    }
}