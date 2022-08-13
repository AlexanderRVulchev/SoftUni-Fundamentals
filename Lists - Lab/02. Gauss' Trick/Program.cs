//Write a program that sums all of the numbers in a list in the following order: 
//first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
        int iterations = list.Count / 2;
        for (int i = 0; i < iterations; i++)
        {
            list[i] += list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
        }
        foreach (double item in list)
        {
            Console.Write(item + " ");
        }
    }
}