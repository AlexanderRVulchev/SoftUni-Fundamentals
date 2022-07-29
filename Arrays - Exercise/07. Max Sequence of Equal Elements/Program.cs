//Create a program that finds the longest sequence of equal elements in an array of integers.
//If several equal sequences are present in the array, print out the leftmost one.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int startIndex = 0;
        int length = 0;
        int bestIndex = 0;
        int bestLength = 0;

        for (int current = 0; current < arr.Length - 1; current++)
        {
            if (arr[current] == arr[current + 1])
            {
                if (length == 0) { startIndex = current; length++; }
                else length++;
                if (length > bestLength) { bestIndex = startIndex; bestLength = length; }
            }
            else length = 0;
        }

        for (int i = bestIndex; i <= bestIndex + bestLength; i++)
            Console.Write(arr[i] + " ");
    }
}