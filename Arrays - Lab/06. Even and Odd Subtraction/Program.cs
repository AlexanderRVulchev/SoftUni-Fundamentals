//Create a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int even = 0;
        int odd = 0;

        for (int i = 0; i < array.Length; i++)
            if (array[i] % 2 == 0) even += array[i];
            else odd += array[i];
        Console.WriteLine(even - odd);
    }
}