//Create a program that creates 2 arrays. You will be given an integer n.
//On the next n lines, you will get 2 integers.
//Form 2 new arrays in a zig-zag pattern as shown below.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int[] array2 = new int[n];
        for (int i = 0; i < n; i++)
        {
            int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (i % 2 == 0) { array1[i] = temp[0]; array2[i] = temp[1]; }
            else { array1[i] = temp[1]; array2[i] = temp[0]; }
        }
        for (int i = 0; i < n; i++) Console.Write(array1[i] + " ");
        Console.WriteLine();
        for (int i = 0; i < n; i++) Console.Write(array2[i] + " ");
    }
}