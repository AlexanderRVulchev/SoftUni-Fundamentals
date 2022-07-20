//Create a program, which calculates the volume of n beer kegs.
//You will receive in total 3 * n lines. Every three lines will hold information for a single keg.
//First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the keg.
//Calculate the volume using the following formula: π* r^2 * h.
//In the end, print the model of the biggest keg.
//Input
//You will receive 3 * n lines. Each group of lines will be on a new line:
//•	First – model – string.
//•	Second –radius – floating - point number
//•	Third – height – integer number
//Output
//Print the model of the biggest keg.

using System;

class Program
{
    static void Main()
    {
        int numberOfKegs = int.Parse(Console.ReadLine());
        string bestModel = string.Empty;
        double bestVolume = 0;
        for (int i = 0; i < numberOfKegs; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double volume = Math.PI * radius * radius * height;
            if (volume > bestVolume)
            {
                bestVolume = volume;
                bestModel = model;
            }
        }
        Console.WriteLine(bestModel);
    }
}