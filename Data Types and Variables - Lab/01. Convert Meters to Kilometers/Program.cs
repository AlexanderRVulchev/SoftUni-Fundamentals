//You will be given an integer that will be a distance in meters.
//Create a program that converts meters to kilometers formatted to the second decimal point.

using System;


class Program
{
    static void Main()
    {
        double meters = double.Parse(Console.ReadLine());
        double kilometers = meters / 1000;
        Console.WriteLine($"{kilometers:f2}");
    }
}
