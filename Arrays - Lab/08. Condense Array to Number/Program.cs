//Create a program to read an array of integers and condense them
//by summing all adjacent couples of elements until a single integer remains.
//For example, let us say we have 3 elements - {2, 10, 3}.
//We sum the first two and the second two elements and get {2 + 10, 10 + 3} = { 12, 13},
//then we sum all adjacent elements again. This results in {12 + 13} = { 25}.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] condensed = new int[nums.Length - 1];

        for (int i = nums.Length - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++) condensed[j] = nums[j] + nums[j + 1];
            nums = condensed;
        }
        Console.WriteLine(nums[0]);
    }
}