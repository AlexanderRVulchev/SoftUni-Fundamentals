//Peter has finally become a junior developer and has received his first task.
//It’s about manipulating an array of integers.
//He is not quite happy about it, since he hates manipulating arrays.
//They are going to pay him a lot of money, though,
//and he is willing to give somebody half of it if to help him do his job.
//You, on the other hand, love arrays (and money) so you decide to try your luck.
//The array may be manipulated by one of the following commands
//•	exchange {index} – splits the array after the given index,
//and exchanges the places of the two resulting sub-arrays.
//E.g. [1, 2, 3, 4, 5] -> exchange 2->result: [4, 5, 1, 2, 3]
//o If the index is outside the boundaries of the array, print "Invalid index"
//•	max even/odd – returns the INDEX of the max even/odd element -> [1, 4, 8, 2, 3] -> max odd -> print 4
//•	min even/odd – returns the INDEX of the min even/odd element -> [1, 4, 8, 2, 3] -> min even > print 3
//o	If there are two or more equal min/max elements, return the index of the rightmost one
//o	If a min/max even/odd element cannot be found, print "No matches"
//•	first {count} even / odd – returns the first {count} elements-> [1, 8, 2, 3]->first 2 even->print[8, 2]
//•	last
//{ count}
//even / odd – returns the last {count} elements-> [1, 8, 2, 3]->last 2 odd->print[1, 3]
//o If the count is greater than the array length, print "Invalid count"
//o	If there are not enough elements to satisfy the count, print as many as you can.
//If there are zero even/odd elements, print an empty array “[]”
//•	end – stop taking input and print the final state of the array

using System;
using System.Linq;
using System.Text;

class Program
{
    static int[] Exchange(int[] arr, int position)
    {
        if (position >= arr.Length || position < 0)
        {
            Console.WriteLine("Invalid index");
            return arr;
        }

        int[] tempArray = new int[arr.Length];
        int newPosition = 0;
        for (int i = position + 1; i < arr.Length; i++)
        {
            tempArray[newPosition] = arr[i];
            newPosition++;
        }
        for (int i = 0; i <= position; i++)
        {
            tempArray[newPosition] = arr[i];
            newPosition++;
        }
        return tempArray;
    }

    static void MaxEven(int[] arr)
    {
        int maxEvenValue = int.MinValue;
        int maxEvenIndex = -1;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 0 && arr[i] >= maxEvenValue)
            {
                maxEvenIndex = i;
                maxEvenValue = arr[i];
            }
        if (maxEvenIndex == -1) Console.WriteLine("No matches");
        else Console.WriteLine(maxEvenIndex);
    }

    static void MaxOdd(int[] arr)
    {
        int maxOddValue = int.MinValue;
        int maxOddIndex = -1;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 1 && arr[i] >= maxOddValue)
            {
                maxOddIndex = i;
                maxOddValue = arr[i];
            }
        if (maxOddIndex == -1) Console.WriteLine("No matches");
        else Console.WriteLine(maxOddIndex);
    }

    static void MinEven(int[] arr)
    {
        int minEvenValue = int.MaxValue;
        int minEvenIndex = -1;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 0 && arr[i] <= minEvenValue)
            {
                minEvenIndex = i;
                minEvenValue = arr[i];
            }
        if (minEvenIndex == -1) Console.WriteLine("No matches");
        else Console.WriteLine(minEvenIndex);
    }

    static void MinOdd(int[] arr)
    {
        int minOddValue = int.MaxValue;
        int minOddIndex = -1;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 1 && arr[i] <= minOddValue)
            {
                minOddIndex = i;
                minOddValue = arr[i];
            }
        if (minOddIndex == -1) Console.WriteLine("No matches");
        else Console.WriteLine(minOddIndex);
    }

    static void FirstEven(int[] arr, int count)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                sb.Append(arr[i] + ", ");
                if (--count == 0) break;
            }
        }
        if (sb.Length > 1) sb.Remove(sb.Length - 2, 2);
        sb.Append("]");
        Console.WriteLine(sb.ToString());
    }

    static void FirstOdd(int[] arr, int count)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 1)
            {
                sb.Append(arr[i] + ", ");
                if (--count == 0) break;
            }
        }
        if (sb.Length > 1) sb.Remove(sb.Length - 2, 2);
        sb.Append("]");
        Console.WriteLine(sb.ToString());
    }

    static void LastEven(int[] arr, int count)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("]");
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] % 2 == 0)
            {
                sb.Insert(0, ", " + arr[i]);
                if (--count == 0) break;
            }
        }
        if (sb.Length > 1) sb.Remove(0, 2);
        sb.Insert(0, "[");
        Console.WriteLine(sb.ToString());
    }

    static void LastOdd(int[] arr, int count)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("]");
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] % 2 == 1)
            {
                sb.Insert(0, ", " + arr[i]);
                if (--count == 0) break;
            }
        }
        if (sb.Length > 1) sb.Remove(0, 2);
        sb.Insert(0, "[");
        Console.WriteLine(sb.ToString());
    }

    static void Main()
    {
        int[] mainArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split().ToArray();
            switch (command[0])
            {
                case "exchange":
                    mainArray = Exchange(mainArray, int.Parse(command[1]));
                    break;
                case "max":
                    if (command[1] == "even") MaxEven(mainArray);
                    else if (command[1] == "odd") MaxOdd(mainArray);
                    break;
                case "min":
                    if (command[1] == "even") MinEven(mainArray);
                    else if (command[1] == "odd") MinOdd(mainArray);
                    break;
                case "first":
                    if ((int.Parse(command[1]) > mainArray.Length)) Console.WriteLine("Invalid count");
                    else if (command[2] == "even") FirstEven(mainArray, int.Parse(command[1]));
                    else if (command[2] == "odd") FirstOdd(mainArray, int.Parse(command[1]));
                    break;
                case "last":
                    if ((int.Parse(command[1]) > mainArray.Length)) Console.WriteLine("Invalid count");
                    else if (command[2] == "even") LastEven(mainArray, int.Parse(command[1]));
                    else if (command[2] == "odd") LastOdd(mainArray, int.Parse(command[1]));
                    break;
            }
        }
        Console.Write("[");
        for (int i = 0; i < mainArray.Length - 1; i++)
        {
            Console.Write(mainArray[i] + ", ");
        }
        Console.WriteLine(mainArray[mainArray.Length - 1] + (string)"]");
    }
}