//Read a number n and n lines of products. Print a numbered list of all the products ordered by name.

using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();

        for (int i = 0; i < n; i++)
            list.Add(Console.ReadLine());

        //Sorting words the hard way:

        for (int i = 0; i < list.Count; i++)
            for (int j = 0; j < list.Count - 1; j++)
            {
                int shorterWordLength = Math.Min(list[j].Length, list[j + 1].Length);
                bool equalLetters = true;
                for (int symbol = 0; symbol < shorterWordLength; symbol++)
                {
                    char letter1 = list[j][symbol].ToString().ToLower().First();
                    char letter2 = list[j + 1][symbol].ToString().ToLower().First();
                    if (letter1 < letter2)
                    {
                        equalLetters = false;
                        break;
                    }
                    else if (letter1 > letter2)
                    {
                        string swap = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = swap;
                        equalLetters = false;
                        break;
                    }
                    else if (list[j][symbol] < list[j + 1][symbol])
                    {
                        string swap = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = swap;
                        equalLetters = false;
                        break;
                    }

                }
                if (equalLetters && list[j].Length > list[j + 1].Length)
                {
                    string swap = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = swap;
                }
            }
        for (int i = 0; i < list.Count; i++)
            Console.WriteLine($"{i + 1}.{list[i]}");
    }
}