//Create a program that receives an array and several rotations that you have to perform.
//The rotations are done by moving the first element of the array from the front to the back.
//Print the resulting array.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());

        for (int rotation = 0; rotation < n; rotation++)
        {
            int temp = arr[0];
            for (int step = 0; step < arr.Length - 1; step++) arr[step] = arr[step + 1];
            arr[arr.Length - 1] = temp;
        }

        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}