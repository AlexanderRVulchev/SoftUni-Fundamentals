//Create a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());

        for (int main = 0; main < arr.Length - 1; main++)
            for (int secondary = main + 1; secondary < arr.Length; secondary++)
                if (arr[main] + arr[secondary] == n) Console.WriteLine(arr[main] + " " + arr[secondary]);
    }
}