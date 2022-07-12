//You will receive two whole numbers from the console representing the start and the end of a sequence of numbers. 
//Your task is to print two lines:
//•	On the first line print, all numbers from the start of the sequence to the end inclusive
//•	On the second line print the sum of the sequence in the format: "Sum: {sum}"

using System;


class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = first; i <= second; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine($"\nSum: {sum}");
    }
}