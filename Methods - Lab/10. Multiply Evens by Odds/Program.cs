//You are given an input of two values of the same type. The values can be of type int, char, or string.
//Create methods called GetMax(), which can compare int, char, or string and returns the biggest of the two values.

using System;


class Program
{
    static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            if (number % 2 == 0) sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static int GetSumOfOddDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            if (number % 2 != 0) sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static int GetMultipleOfEvenAndOdds(int number)
    {
        return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
    }

    static void Main()
    {
        int input = Math.Abs(int.Parse(Console.ReadLine()));
        Console.WriteLine(GetMultipleOfEvenAndOdds(input));
    }
}