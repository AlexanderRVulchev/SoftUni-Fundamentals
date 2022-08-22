//You will be given a string that will contain words separated by a single space.
//Randomize their order and print each word on a new line.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();
        Random rnd = new Random();
        for (int i = 0; i < input.Length; i++)
        {
            int swapIndex = rnd.Next(input.Length);
            string swapValue = input[swapIndex];
            input[swapIndex] = input[i];
            input[i] = swapValue;
        }
        Console.WriteLine(String.Join("\n", input));
    }
}