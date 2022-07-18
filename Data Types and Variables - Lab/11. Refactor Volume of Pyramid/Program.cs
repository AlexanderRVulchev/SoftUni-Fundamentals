//You are given a working code that finds the volume of a pyramid.
//However, you should consider that the variables exceed their optimum span and have improper naming.
//Also, search for variables that have multiple purposes.

using System;

class Program
{
    static void Main()
    {
        double length, width, height = 0;
        Console.Write("Length: ");
        length = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine());
        double volume = (length * width * height) / 3;
        Console.WriteLine($"Pyramid Volume: {volume:f2}");
    }
}
