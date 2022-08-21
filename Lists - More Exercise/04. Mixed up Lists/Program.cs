//Write a program that mixes up two lists by some rules.
//You will receive two lines of input, each one being a list of numbers.
//The mixing rules are:
//•	Start from the beginning of the first list and the ending of the second.
//•	Add element from the first and element from the second.
//•	In the end, there will always be a list, in which there are 2 elements are remaining.
//•	These elements will be the range of the elements you need to print.
//•	Loop through the result list and take only the elements that fulfill the condition.
//•	Print the elements ordered in ascending order and separated by a space.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> mixedList = new List<int>();
        int iterations = Math.Min(firstList.Count, secondList.Count);
        for (int i = 0; i < iterations; i++)
        {
            mixedList.Add(firstList[0]);
            firstList.RemoveAt(0);
            mixedList.Add(secondList[secondList.Count - 1]);
            secondList.RemoveAt(secondList.Count - 1);
        }

        int[] leftovers = firstList.Count == 0 ? secondList.ToArray() : firstList.ToArray();
        int lowIntegerBorder = Math.Min(leftovers[0], leftovers[1]);
        int highIntegerBorder = Math.Max(leftovers[0], leftovers[1]);

        mixedList.Sort();
        Console.WriteLine(String.Join(" ", mixedList.Where(x => x > lowIntegerBorder && x < highIntegerBorder)));
    }
}