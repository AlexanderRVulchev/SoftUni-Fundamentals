//You are given a program that checks if numbers in a given range [2...N] are prime.
//For each number is printed "{number} -> {true or false}".
//The code, however, is not very well written.
//Your job is to modify it in a way that is easy to read and understand.

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int currentNumber = 2; currentNumber <= n; currentNumber++)
        {
            bool isPrime = true;
            for (int div = 2; div < currentNumber; div++)
            {
                if (currentNumber % div == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            string result = string.Empty;
            result = isPrime ? "true" : "false";
            Console.WriteLine("{0} -> {1}", currentNumber, result);
        }
    }
}