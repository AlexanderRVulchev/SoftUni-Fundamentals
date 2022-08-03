//Create a program that receives three lines of input:
//•	On the first line, a string - "add", "multiply", "subtract", "divide"
//•	On the second line, a number
//•	On the third line, another number
//You should create four methods (for each calculation) and invoke the corresponding method depending on the command. The method should also print the result (needs to be void).

using System;
using System.Linq;
using System.Text;

class Program
{
    static void AddNums(double x, double y)
    {
        Console.WriteLine(x + y);
    }

    static void MultiplyNums(double x, double y)
    {
        Console.WriteLine(x * y);
    }

    static void SubtractNums(double x, double y)
    {
        Console.WriteLine(x - y);
    }

    static void DivideNums(double x, double y)
    {
        Console.WriteLine(x / y);
    }

    static void Main()
    {
        string input = Console.ReadLine();
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        switch (input)
        {
            case "add": AddNums(firstNum, secondNum); break;
            case "multiply": MultiplyNums(firstNum, secondNum); break;
            case "subtract": SubtractNums(firstNum, secondNum); break;
            case "divide": DivideNums(firstNum, secondNum); break;
        }
    }
}