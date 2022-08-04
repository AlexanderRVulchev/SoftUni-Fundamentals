//Create a method that calculates and returns the area of a rectangle. 

using System;
using System.Linq;
using System.Text;

class Program
{
    static double GetRectangleArea(double width, double height)
    {
        return width * height;
    }

    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine(GetRectangleArea(width, height));
    }
}