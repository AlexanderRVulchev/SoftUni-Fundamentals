//Create a program that reads a string from the console and replaces any sequence of the same letter with a single corresponding letter.

using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Console.ReadLine());
        int index = 0;
        
        while (index < sb.Length - 1)
        {
            if (sb[index] == sb[index + 1])
                sb.Remove(index + 1, 1);
            else index++;
        }

        Console.WriteLine(sb);
    }
}