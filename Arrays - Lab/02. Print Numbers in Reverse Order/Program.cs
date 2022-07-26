//Read n numbers and print them in reverse order, separated by a single space.

using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
        for (int i = n - 1; i >= 0; i--) Console.Write(arr[i] + " ");
    }
}