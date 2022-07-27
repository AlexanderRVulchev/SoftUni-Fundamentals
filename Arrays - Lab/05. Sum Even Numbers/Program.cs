//Read an array from the console and sum only its even values. 

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
            if (array[i] % 2 == 0) sum += array[i];
        Console.WriteLine(sum);
    }
}