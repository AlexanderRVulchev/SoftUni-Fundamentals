//You will receive a number N in the range [0…1000]. Calculate the Factorial of N and print out the result.

using System;
using System.Numerics;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)        
            result *= i;
        Console.WriteLine(result);        
    }
}