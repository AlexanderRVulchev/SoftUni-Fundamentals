//A train has an **n** number of wagons (integer, received as input).
//On the next n lines, you will receive the number of people that are going to get on each wagon.
//Print out the number of passengers in each wagon followed by the total number of passengers on the train.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] train = new int[n];
        for (int i = 0; i < n; i++)
        {
            train[i] = int.Parse(Console.ReadLine());
            sum += train[i];
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(train[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(sum);
    }
}