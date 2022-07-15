//Create a program to enter an integer number of centuries and convert it to years, days, hours, and minutes.

using System;

class Program
{
    static void Main()
    {
        ulong centuries = ulong.Parse(Console.ReadLine());
        ulong years = centuries * 100;
        ulong days = (ulong)(years * 365.2422);
        ulong hours = days * 24;
        ulong minutes = hours * 60;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}
