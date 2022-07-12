//Write a program that receives a single integer and calculates is it a strong or not.
//A number is strong if the sum of the Factorial of each digit is equal to the number. 
//Example: 145 is a strong number, because 1! + 4! + 5! = 145.
//Print "yes" if the number is strong or "no" if the number is not strong.

using System;
using System.Collections.Generic;


class Program
{
    static int GetFactoriel(int n)
    {
        if (n <= 1) return 1;
        return n * GetFactoriel(n - 1);
    }

    static List<int> GetDigitsList(int number)
    {
        List<int> digits = new List<int>();
        while (number != 0)
        {
            digits.Add(number % 10);
            number /= 10;
        }
        return digits;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<int> digits = GetDigitsList(number);
        int sumFactoriels = 0;
        foreach (int digit in digits)
            sumFactoriels += GetFactoriel(digit);

        if (sumFactoriels == number) Console.WriteLine("yes");
        else Console.WriteLine("no");
    }
}