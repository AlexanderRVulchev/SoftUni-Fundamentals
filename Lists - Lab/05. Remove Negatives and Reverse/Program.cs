//Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order.
//In case there are no elements left in the list, print "empty".

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        nums.RemoveAll(x => x < 0);

        if (nums.Count == 0)
        {
            Console.Write("empty");
            return;
        }
        nums.Reverse();
        foreach (int num in nums)
            Console.Write(num + " ");
    }
}