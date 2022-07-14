//Create a method that returns the English spelling of the last digit of a given number.
//Write a program that reads an integer and prints the returned value from this method.

using System;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        int lastDigit = int.Parse(number[number.Length - 1].ToString());
        switch (lastDigit)
        {
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
            case 0: Console.WriteLine("zero"); break;
            default: break;
        }
    }
}