//You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2, and Y2.
//Create a method that prints the point that is closest to the center of the coordinate system (0, 0) in the format(X, Y).
//If the points are at the same distance from the center, print only the first one.

using System;


class Program
{
    static double GetDistanceSquared(double pointX, double pointY)
    {
        return Math.Abs(pointX * pointX + pointY * pointY);
    }

    static (double, double) GetBestCoordinates(double x1, double y1, double x2, double y2)
    {
        double firstDistance = GetDistanceSquared(x1, y1);
        double secondDistance = GetDistanceSquared(x2, y2);
        return firstDistance <= secondDistance ? (x1, y1) : (x2, y2);
    }

    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        (double bestX, double bestY) = GetBestCoordinates(x1, y1, x2, y2);
        Console.WriteLine($"({bestX}, {bestY})");
    }
}