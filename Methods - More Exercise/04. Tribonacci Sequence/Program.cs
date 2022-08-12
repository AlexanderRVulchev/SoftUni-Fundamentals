//In the "Tribonacci" sequence, every number is formed by the sum of the previous 3.
//You are given a number num. Write a program that prints num numbers from the Tribonacci sequence,
//each on a new line, starting from 1. The input comes as a parameter named num.
//The value num will always be a positive integer.

using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int previous1 = 2;
        int previous2 = 1;
        int previous3 = 1;
        int currentNumber = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == 2) Console.Write("1 ");
            else if (i == 3) Console.Write("2 ");
            else
            {
                currentNumber = previous1 + previous2 + previous3;
                Console.Write(currentNumber + " ");
                previous3 = previous2;
                previous2 = previous1;
                previous1 = currentNumber;
            }
        }
    }
}