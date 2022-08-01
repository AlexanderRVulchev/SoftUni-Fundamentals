//The Fibonacci sequence is quite a famous sequence of numbers.
//Each member of the sequence is calculated from the sum of the two previous elements.
//The first two elements are 1, 1. Therefore the sequence goes like 1, 1, 2, 3, 5, 8, 13, 21, 34…
//The following sequence can be generated with an array, but that’s easy, so your task is to implement recursively.
//So if the function GetFibonacci(n) returns the n’th Fibonacci number we can express it using GetFibonacci(n) = GetFibonacci(n - 1) + GetFibonacci(n - 2).
//However, this will never end and in a few seconds, a StackOverflow Exception is thrown.
//For the recursion to stop it has to have a “bottom”.
//The bottom of the recursion is GetFibonacci(2) should return 1 and GetFibonacci(1) should return 1.

using System;


class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(GetFibonacci(input));
    }

    static int GetFibonacci(int n)
    {
        if (n == 2 || n == 1) return 1;
        int number = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        return number;
    }
}