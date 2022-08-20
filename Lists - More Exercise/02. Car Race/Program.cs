//Write a program to calculate the winner of a car race.
//You will receive an array of numbers.
//Each element of the array represents the time needed to pass through that step (the index).
//There are going to be two cars.
//One of them starts from the left side and the other one starts from the right side.
//The middle index of the array is the finish line.
//The number of elements in the array will always be odd.
//Calculate the total time for each racer to reach the finish, which is the middle of the array,
//and print the winner with his total time (the racer with less time).
//If you have a zero in the array,
//you have to reduce the time of the racer that reached it by 20% (from his current time).
//Print the result in the following format "The winner is {left/right} with total time: {total time}".

using System;
using System.Linq;

class Program
{
    static double GetCarTime(int[] carArray)
    {
        double Sum = 0;
        for (int i = 0; i < carArray.Length; i++)
        {
            if (carArray[i] == 0)
            {
                Sum *= 0.8;
                continue;
            }
            Sum += carArray[i];
        }
        return Sum;
    }

    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] leftCarArray = new int[input.Length / 2];
        int[] rightCarArray = new int[input.Length / 2];

        // Separating input array into 2 arrays - left car path and right car path:
        for (int i = 0; i < input.Length / 2; i++)
            leftCarArray[i] = input[i];

        int index = 0;
        for (int i = input.Length - 1; i > input.Length / 2; i--)
        {
            rightCarArray[index] = input[i];
            index++;
        }

        // Calculating the result times for both cars and printing result
        double leftSum = GetCarTime(leftCarArray);
        double rightSum = GetCarTime(rightCarArray);
        Console.WriteLine(leftSum <= rightSum ? $"The winner is left with total time: {leftSum}"
            : $"The winner is right with total time: {rightSum}");
    }
}