//Write a program that, depending on the first line of the input, reads an int, double, or string.
//•	If the data type is int, multiply the number by 2.
//•	If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
//•	If the data type is a string, surround the input with "$".
//Print the result on the console.

using System;


class Program
{
    static void CalculateAndPrintInt()
    {
        int inputInt = int.Parse(Console.ReadLine());
        Console.WriteLine(inputInt * 2);
    }

    static void CalculateAndPrintReal()
    {
        double inputReal = double.Parse(Console.ReadLine());
        Console.WriteLine($"{inputReal * 1.5:f2}");
    }

    static void CalculateAndPrintString()
    {
        string inputString = Console.ReadLine();
        Console.WriteLine($"${inputString}$");
    }

    static void Main()
    {
        string type = Console.ReadLine();
        switch (type)
        {
            case "int": CalculateAndPrintInt(); break;
            case "real": CalculateAndPrintReal(); break;
            case "string": CalculateAndPrintString(); break;
        }
    }
}