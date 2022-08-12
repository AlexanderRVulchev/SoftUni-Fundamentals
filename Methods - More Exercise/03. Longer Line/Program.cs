//You are given the coordinates of four points in the 2D plane.
//The first and the second pair of points form two different lines.
//Print the longer line in the format "(X1, Y1)(X2, Y2)" starting with the point that is closer
//to the center of the coordinate system (0, 0) (You can reuse the method that you wrote for the previous problem).
//If the lines are of equal length, print only the first one.

using System;


class Program
{
    static double GetDistanceSquared(double pointX, double pointY)
    {
        return pointX * pointX + pointY * pointY;
    }

    static (double, double, double, double) ArrangeClosestCoordinates(double x1, double y1, double x2, double y2)
    {
        double firstDistance = GetDistanceSquared(x1, y1);
        double secondDistance = GetDistanceSquared(x2, y2);
        return firstDistance <= secondDistance ? (x1, y1, x2, y2) : (x2, y2, x1, y1);
    }

    static double CalculateLineLengthSquared(double x1, double y1, double x2, double y2)
    {
        return (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
    }

    static void Main()
    {
        double firstX1 = double.Parse(Console.ReadLine());
        double firstY1 = double.Parse(Console.ReadLine());
        double firstX2 = double.Parse(Console.ReadLine());
        double firstY2 = double.Parse(Console.ReadLine());

        double secondX1 = double.Parse(Console.ReadLine());
        double secondY1 = double.Parse(Console.ReadLine());
        double secondX2 = double.Parse(Console.ReadLine());
        double secondY2 = double.Parse(Console.ReadLine());

        double resultX1, resultY1, resultX2, resultY2;
        if (CalculateLineLengthSquared(firstX1, firstY1, firstX2, firstY2) >= CalculateLineLengthSquared(secondX1, secondY1, secondX2, secondY2))
            (resultX1, resultY1, resultX2, resultY2) = ArrangeClosestCoordinates(firstX1, firstY1, firstX2, firstY2);
        else (resultX1, resultY1, resultX2, resultY2) = ArrangeClosestCoordinates(secondX1, secondY1, secondX2, secondY2);

        Console.WriteLine($"({resultX1}, {resultY1})({resultX2}, {resultY2})");
    }
}