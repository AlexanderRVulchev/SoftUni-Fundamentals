//You have a water tank with a capacity of 255 liters.
//On the next n lines, you will receive liters of water, which you have to pour into your tank.
//If the capacity is not enough, print "Insufficient capacity!" and continue reading the next line.
//On the last line, print the liters in the tank.
//Input
//The input will be on two lines:
//•	On the first line, you will receive n – the number of lines, which will follow
//•	On the next n lines – you receive quantities of water, which you have to pour into the tank
//Output
//Every time you do not have enough capacity in the tank to pour the given liters, print:
//Insufficient capacity!
//On the last line, print only the liters in the tank.

using System;


class Program
{
    static void Main()
    {
        int tankLiters = 0;
        int attempts = int.Parse(Console.ReadLine());
        for (int i = 0; i < attempts; i++)
        {
            int litersToPour = int.Parse(Console.ReadLine());
            if (litersToPour > 255 - tankLiters) Console.WriteLine("Insufficient capacity!");
            else tankLiters += litersToPour;
        }
        Console.WriteLine(tankLiters);
    }
}