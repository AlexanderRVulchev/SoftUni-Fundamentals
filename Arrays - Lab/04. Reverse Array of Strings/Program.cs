//Create a program that reads an array of strings, reverses it, and prints its elements.
//The input consists of a sequence of space-separated Strings.
//Print the output on a single line (space separated).

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split().ToArray();
        string[] reversed = new string[array.Length];

        for (int i = 0; i < array.Length; i++) reversed[i] = array[array.Length - 1 - i];
        for (int i = 0; i < reversed.Length; i++) Console.Write(reversed[i] + " ");
    }
}