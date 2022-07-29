//Create a program to find all the top integers in an array.
//A top integer is an integer that is greater than all the elements to its right.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int main = 0; main < arr.Length - 1; main++)
        {
            bool isTop = true;
            for (int secondary = main + 1; secondary < arr.Length; secondary++)
                if (arr[main] <= arr[secondary]) isTop = false;
            if (isTop) Console.Write(arr[main] + " ");
        }
        Console.WriteLine(arr[arr.Length - 1]);
    }
}