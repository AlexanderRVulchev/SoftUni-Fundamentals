//You are given a number num1, num2, and num3.
//Write a program that finds if num1 * num2 * num3 (the product) is negative,
//positive, or zero.Try to do this WITHOUT multiplying the 3 numbers.

using System;


class Program
{
    static bool IsItPositiveNumber(int num, bool equasionSign)
    {
        if (num < 0) equasionSign = equasionSign ? false : true;
        return equasionSign;
    }
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            Console.WriteLine("zero");
            return;
        }
        bool isPositive = true;
        isPositive = IsItPositiveNumber(num1, isPositive);
        isPositive = IsItPositiveNumber(num2, isPositive);
        isPositive = IsItPositiveNumber(num3, isPositive);
        Console.WriteLine(isPositive ? "positive" : "negative");
    }
}