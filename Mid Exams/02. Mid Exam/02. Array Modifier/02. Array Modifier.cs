using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] cmd = input.Split();
            if (cmd[0] == "swap") Swap(arr, int.Parse(cmd[1]), int.Parse(cmd[2]));
            else if (cmd[0] == "multiply") Multiply(arr, int.Parse(cmd[1]), int.Parse(cmd[2]));
            else if (cmd[0] == "decrease") Decrease(arr);
        }
        Console.WriteLine(String.Join(", ", arr));
    }

    private static void Decrease(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i]--;
    }

    private static void Multiply(int[] arr, int index1, int index2)
    {
        arr[index1] *= arr[index2];
    }

    private static void Swap(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }
}