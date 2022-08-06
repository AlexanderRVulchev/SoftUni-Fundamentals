//Create a method that prints out the smallest of three integer numbers.

using System;
using System.Linq;
using System.Text;

class Program
{
    static void PrintSmallestNumber(int a, int b, int c)
    {
        int smallest = Math.Min(a, b);
        smallest = Math.Min(smallest, c);
        Console.WriteLine(smallest);
    }

    static void Main()
    {
        // I just want to practice tuple variables. They're not necessary.
        (int one, int two, int three) nums = (0, 0, 0);
        nums.one = int.Parse(Console.ReadLine());
        nums.two = int.Parse(Console.ReadLine());
        nums.three = int.Parse(Console.ReadLine());
        PrintSmallestNumber(nums.one, nums.two, nums.three);
    }
}