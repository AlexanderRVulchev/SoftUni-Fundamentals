//Read two arrays and determine whether they are identical or not.
//The arrays are identical if all their elements are equal.
//If the arrays are identical find the sum of the elements of one of them and print the following message to the console:
//"Arrays are identical. Sum: {sum}"
//Otherwise, find the first index where the arrays differ and print the following message to the console:
//"Arrays are not identical. Found difference at {index} index."

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int sum = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                return;
            }
            sum += arr1[i];
        }
        Console.WriteLine($"Arrays are identical. Sum: {sum}");
    }
}