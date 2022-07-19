//Create a program, which sums the ASCII codes of n characters and prints the sum on the console.

using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += (int)char.Parse(Console.ReadLine());
        Console.WriteLine($"The sum equals: {sum}");
    }
}