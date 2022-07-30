//The clone factory in Kamino got another order to clone troops.
//But this time you are tasked to find the best DNA sequence to use in the production. 
//You will receive the DNA length and until you receive the command "Clone them!"
//you will be receiving a DNA sequence of ones and zeroes, split by "!" (one or several).
//You should select the sequence with the longest subsequence of ones.
//If there are several sequences with the same length of the subsequence of ones,
//print the one with the leftmost starting index,
//if there are several sequences with the same length and starting index,
//select the sequence with the greater sum of its elements.
//After you receive the last command "Clone them!" you should print the collected information in the following format:
//"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
//"{DNA sequence, joined by space}"
//Input / Constraints
//•	The first line holds the length of the sequences – integer in the range [1…100];
//•	On the next lines until you receive "Clone them!" you will be receiving sequences
//(at least one) of ones and zeroes, split by "!" (one or several).
// Output
//The output should be printed on the console and consists of two lines in the following format:
//"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
//"{DNA sequence, joined by space}"

using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] bestArray = new int[n];
        int bestIndex = 0;
        int bestLeng = 0;
        int bestSum = 0;
        int counter = 0;
        int bestCounter = 0;
        string input = Console.ReadLine();
        char[] charSeparators = new char[] { '!' };

        while (input != "Clone them!")
        {
            counter++;
            int[] currentArray = new int[n];
            currentArray = input.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int currentIndex = 0;
            int currentLeng = 0;
            int currentSum = currentArray[n - 1];
            int index = 0;
            int leng = 0;

            for (int i = 0; i < n - 1; i++)
            {
                currentSum += currentArray[i];
                if (currentArray[i] == currentArray[i + 1])
                {
                    if (leng == 0) index = i;
                    leng++;
                }
                else leng = 0;

                if (leng > currentLeng)
                {
                    currentLeng = leng;
                    currentIndex = index;
                }
            }

            if ((currentLeng > bestLeng) ||
                (currentLeng == bestLeng && currentIndex < bestIndex) ||
                (currentLeng == bestLeng && currentIndex == bestIndex && currentSum > bestSum))
            {
                bestArray = currentArray;
                bestLeng = currentLeng;
                bestIndex = currentIndex;
                bestSum = currentSum;
                bestCounter = counter;
            }
            input = Console.ReadLine();
        }

        Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
        for (int i = 0; i < n; i++)
        {
            Console.Write(bestArray[i] + " ");
        }
        Console.WriteLine();
    }
}