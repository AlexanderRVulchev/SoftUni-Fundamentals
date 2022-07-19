//Create a program that receives an integer n
//and print all triples of the first n small Latin letters, ordered alphabetically:

using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int first = 97; first < 97 + n; first++)
        {
            for (int second = 97; second < 97 + n; second++)
            {
                for (int third = 97; third < 97 + n; third++)
                {
                    Console.WriteLine($"{(char)first}{(char)second}{(char)third}");
                }
            }
        }
    }
}