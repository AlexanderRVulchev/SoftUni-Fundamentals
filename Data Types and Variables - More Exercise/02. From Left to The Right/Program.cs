//You will receive a number that represents how many lines we will get as input.
//On the next N lines, you will receive a string with 2 numbers separated by a single space.
//You need to compare them. If the left number is greater than the right number,
//you need to print the sum of all digits in the left number, otherwise,
//print the sum of all digits in the right number.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            long[] numbers = input.Split().Select(long.Parse).ToArray();
            long biggerNumber = numbers[0] >= numbers[1] ? numbers[0] : numbers[1];
            string numString = biggerNumber.ToString();
            int position = numString[0] == '-' ? 1 : 0;
            int sum = 0;
            for (int j = position; j < numString.Length; j++)
                sum += int.Parse(numString[j].ToString());
            Console.WriteLine(sum);
        }
    }
}