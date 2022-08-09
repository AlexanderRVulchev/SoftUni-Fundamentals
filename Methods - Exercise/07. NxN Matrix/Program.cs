//Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.

using System;
using System.Linq;
using System.Text;

class Program
{
    static void PrintMatrix(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintMatrix(n);
    }
}