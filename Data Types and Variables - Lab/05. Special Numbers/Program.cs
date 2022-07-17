//A number is special when its sum of digits is 5, 7, or 11.
//Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).

using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.WriteLine($"{i} -> {IsNumberSpecial(i)}");
    }

    static bool IsNumberSpecial(int num)
    {
        int digitSum = 0;
        while (num > 0)
        {
            digitSum += num % 10;
            num /= 10;
        }
        int[] specialSums = { 5, 7, 11 };
        return specialSums.Contains(digitSum);
    }
}