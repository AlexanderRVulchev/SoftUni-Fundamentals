//Write a program to append several arrays of numbers.
//	Arrays are separated by '|'.
//	Values are separated by spaces (' ', one or several).
//	Order the arrays from the last to the first, and their values from left to right.

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine().Split('|').ToArray();
        List<int> result = new List<int>();
        for (int i = inputArray.Length - 1; i >= 0; i--)
        {
            char[] separators = { ' ' };
            List<int> trimmedNums = inputArray[i]
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            result.AddRange(trimmedNums);
        }
        Console.WriteLine(string.Join(" ", result));
    }
}