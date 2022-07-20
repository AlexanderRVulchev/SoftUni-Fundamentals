//Tony and Andi love playing in the snow and having snowball fights,
//but they always argue about which makes the best snowballs.
//They have decided to involve you in their fray, by making you write a program,
//which calculates snowball data and outputs the best snowball value.
//You will receive N – an integer, the number of snowballs being made by Tony and Andi.
//For each snowball you will receive 3 input lines:
//•	On the first line, you will get the snowballSnow – an integer.
//•	On the second line, you will get the snowballTime – an integer.
//•	On the third line, you will get the snowballQuality – an integer.
//For each snowball you must calculate its snowballValue by the following formula:
//(snowballSnow / snowballTime) ^ snowballQuality
//In the end, you must print the highest calculated snowballValue.
//Input
//•	On the first input line, you will receive N – the number of snowballs.
//•	On the next N * 3 input lines you will be receiving data about snowballs.
//Output
//•	As output, you must print the highest calculated snowballValue, by the formula, specified above. 
//•	The output format is: 
//{ snowballSnow} : { snowballTime} = { snowballValue} ({ snowballQuality})


using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bestSnow = 0;
        int bestTime = 0;
        int bestQuality = 0;
        BigInteger bestValue = 0;

        for (int i = 0; i < n; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());
            int snowballDivided = snowballSnow / snowballTime;
            BigInteger snowballValue = 1;
            for (int j = 1; j <= snowballQuality; j++)
                snowballValue *= snowballDivided;

            if (snowballValue > bestValue)
            {
                bestQuality = snowballQuality;
                bestSnow = snowballSnow;
                bestTime = snowballTime;
                bestValue = snowballValue;
            }
        }
        Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
    }
}