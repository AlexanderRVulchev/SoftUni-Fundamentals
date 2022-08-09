//Create a program that reads positive integers until you receive the "END" command.
//For each number, print whether the number is a palindrome or not.
//A palindrome is a number that reads the same backward as forward, such as 323 or 1001. 

using System;
using System.Linq;
using System.Text;

class Program
{
    static bool DetermineIfPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
            if (str[i] != str[str.Length - 1 - i]) return false;

        return true;
    }

    static void Main()
    {
        string input;
        while ((input = Console.ReadLine()) != "END")
            Console.WriteLine(DetermineIfPalindrome(input));
    }
}