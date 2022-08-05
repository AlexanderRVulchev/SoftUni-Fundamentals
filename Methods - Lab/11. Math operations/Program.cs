//Write a method that receives two numbers and an operator, calculates the result, and returns it.
//You will be given three lines of input. The first will be the first number,
//the second one will be the operator and the last one will be the second number.
//The possible operators are: /, *, +and -.

using System;
using System.Linq;
using System.Text;

class Program
{
    static double Calculate(double x, char operation, double y)
    {
        if (operation == '+') return x + y;
        if (operation == '-') return x - y;
        if (operation == '*') return x * y;
        if (operation == '/') return x / y;
        return -1; // Error input operator
    }

    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine(Calculate(firstNum, symbol, secondNum));
    }
}