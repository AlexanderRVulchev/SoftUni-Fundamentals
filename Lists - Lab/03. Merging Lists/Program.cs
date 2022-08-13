//You are going to receive two lists with numbers.
//Create a result list, which contains the numbers from both of the lists.
//The first element should be from the first list, the second from the second list and so on.
//If the length of the two lists are not equal, just add the remaining elements at the end of the list.

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<double> list1 = Console.ReadLine().Split().Select(double.Parse).ToList();
        List<double> list2 = Console.ReadLine().Split().Select(double.Parse).ToList();
        List<double> result = new List<double>();
        while (list1.Count > 0 && list2.Count > 0)
        {
            result.Add(list1[0]);
            result.Add(list2[0]);
            list1.RemoveAt(0);
            list2.RemoveAt(0);
        }
        result.AddRange(list1);
        result.AddRange(list2);
        foreach (double item in result)
            Console.Write(item + " ");
    }
}