//Create a program that determines if an element exists in an array for which the sum of all elements
//to its left is equal to the sum of all elements to its right.
//If there are no elements to the left or right, their sum is considered to be 0.
//Print the index of the element that satisfies the condition or "no" if there is no such element.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string output = "no";
        for (int current = 0; current < arr.Length; current++)
        {
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < current; i++) leftSum += arr[i];
            for (int i = current + 1; i < arr.Length; i++) rightSum += arr[i];
            if (leftSum == rightSum) output = current.ToString();
        }
        Console.WriteLine(output);
    }
}