//You are given a working code that is a solution to Problem 5. Special Numbers.
//However, the variables are improperly named, declared before they are needed and some of them are used for multiple things.
//Without using your previous solution, modify the code so that it is easy to read and understand.

using System;


class Program
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int sum = 0;
        bool isSpecialNumber = false;
        for (int i = 1; i <= inputNumber; i++)
        {
            sum = 0;
            int currentNumber = i;
            while (currentNumber > 0)
            {
                sum += currentNumber % 10;
                currentNumber = currentNumber / 10;
            }
            isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
        }
    }
}