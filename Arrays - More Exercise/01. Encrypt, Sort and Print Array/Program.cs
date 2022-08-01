//Write a program that reads a sequence of strings from the console. Encrypt every string by summing:
//•	The code of each vowel multiplied by the string length
//•	The code of each consonant divided by the string length
//Sort the number sequence in ascending order and print it on the console.
//On the first line, you will always receive the number of strings you have to read.

using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        string[] textArray = new string[arraySize];
        int[] numArray = new int[arraySize];

        // Reading words and converting them into integer values
        for (int wordIndex = 0; wordIndex < textArray.Length; wordIndex++)
        {
            textArray[wordIndex] = Console.ReadLine();
            for (int letterIndex = 0; letterIndex < textArray[wordIndex].Length; letterIndex++)
            {
                int symbol = (int)textArray[wordIndex][letterIndex];

                switch (symbol)
                {
                    case 65:
                    case 69:
                    case 73:
                    case 79:
                    case 85:
                    case 97:
                    case 101:
                    case 105:
                    case 111:
                    case 117: // vowel
                        numArray[wordIndex] += symbol * textArray[wordIndex].Length;
                        break;
                    default: // consonant
                        numArray[wordIndex] += symbol / textArray[wordIndex].Length;
                        break;
                }
            }
        }

        // Sorting the numbers in the numeric array
        for (int numIndex = 0; numIndex < arraySize - 1; numIndex++)
        {
            for (int i = numIndex + 1; i < arraySize; i++)
            {
                if (numArray[numIndex] > numArray[i]) // Swapping the numbers when needed
                {
                    int temporary = numArray[numIndex];
                    numArray[numIndex] = numArray[i];
                    numArray[i] = temporary;
                }
            }
        }

        // Output
        for (int i = 0; i < arraySize; i++) Console.WriteLine(numArray[i] + " ");
    }
}