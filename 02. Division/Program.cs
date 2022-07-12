//You will be given an integer, write a program which check if the given integer is divisible by 2, or 3, or 6, or 7, or 10 without a reminder.
//You should always take the bigger division:
//•	If the number is divisible by both 2, 3, and 6, you should print only the division by 6 only. 
//•	If a number is divisible by 2 and 10, you should print the division by 10. 
//If the number is not divisible by any of the given numbers print "Not divisible".
//Otherwise, print "The number is divisible by {number}".

using System;


class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] divs = { 10, 7, 6, 3, 2 };
        for (int i = 0; i < divs.Length; i++)
            if (num % divs[i] == 0)
            {
                Console.WriteLine($"The number is divisible by {divs[i]}");
                return;
            }
        Console.WriteLine("Not divisible");
    }
}
