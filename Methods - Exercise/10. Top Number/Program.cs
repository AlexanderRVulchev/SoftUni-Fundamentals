//A top number is an integer that holds the following properties:
//•	Its sum of digits is divisible by 8, e.g. 8, 17, 88
//•	Holds at least one odd digit, e.g. 232, 707, 87578
//•	Some examples of top numbers are: 17, 161, 251, 4310, 123200
//Create a program to print all top numbers in the range [1…n].
//You will receive a single integer from the console, representing the end value. 

using System;


class Program
{
    static bool DigitsSumDivisibleBy8(int num)
    {
        int sumDigits = 0;
        while (num > 0)
        {
            sumDigits += num % 10;
            num /= 10;
        }
        if (sumDigits % 8 == 0) return true;
        else return false;
    }

    static bool HasAtLeastOneOddDigit(int num)
    {
        while (num > 0)
        {
            if (num % 2 == 1) return true;
            num /= 10;
        }
        return false;
    }

    static void Main()
    {
        int endValue = int.Parse(Console.ReadLine());
        for (int i = 1; i <= endValue; i++)
            if (DigitsSumDivisibleBy8(i) && HasAtLeastOneOddDigit(i)) Console.WriteLine(i);
    }
}