//Write a program, which receives a number – n, and prints a triangle from 1 to n.

using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
