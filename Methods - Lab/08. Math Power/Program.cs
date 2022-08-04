//Create a method, which receives two numbers as parameters:
//•	The first number – the base
//•	The second number – the power
// The method should return the base rase to the given power.

using System;
using System.Linq;
using System.Text;

class Program
{
    static double RaiseToPower(double x, double y)
    {
        return Math.Pow(x, y);
    }

    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(RaiseToPower(x, y));
    }
}