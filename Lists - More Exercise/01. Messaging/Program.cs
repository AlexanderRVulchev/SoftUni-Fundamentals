//You will be given a list of numbers and a string.
//For each element of the list, you must calculate the sum of its digits and take the element,
//corresponding to that index from the text. If the index is greater than the length of the text,
//start counting from the beginning (so that you always have a valid index).
//After you get that element from the text, you must remove the character you have taken from it
//(so for the next index, the text will be with one characterless).

using System;
using System.Collections.Generic;


class Program
{
    static List<char> PrintAndRemoveTargetChar(List<char> message, int target)
    {
        int index = 0;
        while (target != 0)
        {
            index++;
            if (index >= message.Count) index = 0;
            target--;
        }
        Console.Write(message[index]);
        message.RemoveAt(index);
        return message;
    }

    static int GetSumDigits(string num)
    {
        int sumDigits = 0;
        for (int i = 0; i < num.Length; i++)
            sumDigits += int.Parse(num[i].ToString());
        return sumDigits;
    }

    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        string messageString = Console.ReadLine();
        List<char> message = new List<char>();
        for (int i = 0; i < messageString.Length; i++)
            message.Add(messageString[i]);

        for (int i = 0; i < numbers.Length; i++)
        {
            int sumDigits = GetSumDigits(numbers[i]);
            message = PrintAndRemoveTargetChar(message, sumDigits);
        }
    }
}