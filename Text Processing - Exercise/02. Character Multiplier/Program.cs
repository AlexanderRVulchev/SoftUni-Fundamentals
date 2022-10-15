//Create a method that takes two strings as arguments and returns the sum of their character codes multiplied
//(multiply str1[0] with str2[0] and add to the total sum).
//Then continue with the next two characters.
//If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.

using System;

internal class Program
{

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Console.WriteLine(SumOfMultipliedElements(input[0], input[1]));
    }


    private static int SumOfMultipliedElements(string str1, string str2)
    {
        int sum = 0;
        int index = 0;
        int shorterStringLength = Math.Min(str1.Length, str2.Length);

        while (index < shorterStringLength)
        {
            sum += str1[index] * str2[index];
            index++;
        }

        if (str1.Length > str2.Length) 
            sum += AddRemainingChars(str1, index);
        else 
            sum += AddRemainingChars(str2, index);

        return sum;
    }

    private static int AddRemainingChars(string str, int index)
    {
        int sumRemainingChars = 0;
        while (index < str.Length)
        {
            sumRemainingChars += str[index];
            index++;
        }
        return sumRemainingChars;
    }
}