//Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
//	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well (see the examples below).
//	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available).

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
        bool pairIsFound = true;
        while (pairIsFound)
        {
            pairIsFound = false;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] += (double)nums[i + 1];
                    nums.RemoveAt(i + 1);
                    pairIsFound = true;
                    break;
                }
            }
        }
        foreach (double item in nums)
        {
            Console.Write($"{item} ");
        }
    }
}