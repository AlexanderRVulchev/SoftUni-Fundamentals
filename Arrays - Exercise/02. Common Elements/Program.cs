//Create a program that prints out all common elements in two arrays.
//You have to compare the elements of the second array to the elements of the first.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] array1 = Console.ReadLine().Split().ToArray();
        string[] array2 = Console.ReadLine().Split().ToArray();
        for (int i = 0; i < array2.Length; i++)
        {
            for (int j = 0; j < array1.Length; j++)
            {
                if (array2[i] == array1[j]) Console.Write(array2[i] + " ");
            }
        }
    }
}