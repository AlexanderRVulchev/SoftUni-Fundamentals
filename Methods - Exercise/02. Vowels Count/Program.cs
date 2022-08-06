//Create a method that receives a single string and prints out the number of vowels contained in it.

using System;
using System.Linq;
using System.Text;

class Program
{
    static void PrintNumberOfVowels(string str)
    {
        int vowelCount = 0;
        for (int i = 0; i < str.Length; i++)
        {
            switch (str[i])
            {
                case 'a':
                case 'e':
                case 'o':
                case 'i':
                case 'u': vowelCount++; break;
            }
        }
        Console.WriteLine(vowelCount);
    }

    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        PrintNumberOfVowels(input);
    }
}