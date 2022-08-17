//Create a program that reads a sequence of numbers and a special bomb number holding a certain power.
//Your task is to detonate every occurrence of the special bomb number and according to its power the numbers to its left and right.
//The bomb power refers to how many numbers to the left and right will be removed, no matter their values.
//Detonations are performed from left to right and all the detonated numbers disappear.
//Finally, print the sum of the remaining elements in the sequence.

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static (List<int>, bool) Detonation(List<int> list, int bombNumber, int power)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == bombNumber)
            {
                int start = i - power;
                int end = i + power;
                if (start < 0) start = 0;
                if (end >= list.Count) end = list.Count - 1;
                list.RemoveRange(start, end - start + 1);
                return (list, true);
            }
        }
        return (list, false);
    }

    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] numberAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int bombNumber = numberAndPower[0];
        int power = numberAndPower[1];
        bool hasDetonated = true;
        while (hasDetonated)
        {
            (list, hasDetonated) = Detonation(list, bombNumber, power);
        }
        Console.WriteLine(list.Sum());
    }
}