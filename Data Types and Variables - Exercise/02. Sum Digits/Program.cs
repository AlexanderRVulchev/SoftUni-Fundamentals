//Create a program that receives a single integer. Your task is to find the sum of its digits.
//For example: 12345-> 1 + 2 + 3 + 4 + 5 = 15

using System;


class Program
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        int sum = 0;
        while (inputNum > 0)
        {
            sum += inputNum % 10;
            inputNum /= 10;
        }
        Console.WriteLine(sum);
    }
}