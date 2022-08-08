//You will receive 3 integers.
//Create a method that returns the sum of the first two integers and another method
//that subtracts the third integer from the result of the sum method.

using System;
using System.Linq;
using System.Text;

class Program
{
    static int SumNumbers(int x, int y)
    {
        return x + y;
    }

    static int SubtractNumbers(int x, int y)
    {
        return x - y;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(SubtractNumbers(SumNumbers(a, b), c));
    }
}