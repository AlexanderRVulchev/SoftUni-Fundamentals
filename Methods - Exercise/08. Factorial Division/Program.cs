//Read two integers. Calculate the factorial of each number.
//Divide the first result by the second and print the result of the division formatted to the second decimal point.

using System;
using System.Linq;
using System.Text;

class Program
{
    static decimal GetFactorial(decimal n)
    {
        decimal result = 1m;
        for (int i = 1; i <= n; i++) result *= i;
        return result;
    }

    static decimal FactorialDivision(decimal a, decimal b)
    {
        return GetFactorial(a) / GetFactorial(b);
    }

    static void Main()
    {
        decimal first = decimal.Parse(Console.ReadLine());
        decimal second = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"{FactorialDivision(first, second):f2}");
    }
}