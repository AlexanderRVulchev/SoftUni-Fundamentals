//The first input line will hold a list of integers.
//Until we receive the "End" command, we will be given operations we have to apply to the list.
//The possible commands are:
//•	Add
//{ number} – add the given number to the end of the list
//•	Insert {number} { index} – insert the number at the given index
//•	Remove {index} – remove the number at the given index
//•	Shift left {count} – first number becomes last. This has to be repeated the specified number of times
//•	Shift right {count} – last number becomes first. To be repeated the specified number of times
//Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static bool IsIndexInListRange(List<int> list, int index)
    {
        if (index < 0 || index >= list.Count)
        {
            Console.WriteLine("Invalid index");
            return false;
        }
        else return true;
    }

    static List<int> Add(List<int> list, int number)
    {
        list.Add(number);
        return list;
    }

    static List<int> Insert(List<int> list, int number, int index)
    {
        if (!IsIndexInListRange(list, index)) return list;
        list.Insert(index, number);
        return list;
    }

    static List<int> Remove(List<int> list, int index)
    {
        if (!IsIndexInListRange(list, index)) return list;
        list.RemoveAt(index);
        return list;
    }

    static List<int> ShiftLeft(List<int> list, int count)
    {
        for (int i = 0; i < count; i++)
        {
            int temp = list[0];
            list.RemoveAt(0);
            list.Add(temp);
        }
        return list;
    }

    static List<int> ShiftRight(List<int> list, int count)
    {
        for (int i = 0; i < count; i++)
        {
            int temp = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            list.Insert(0, temp);
        }
        return list;
    }

    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] command = input.Split().ToArray();
            if (command[0] == "Add") Add(list, int.Parse(command[1]));
            else if (command[0] == "Insert") Insert(list, int.Parse(command[1]), int.Parse(command[2]));
            else if (command[0] == "Remove") Remove(list, int.Parse(command[1]));
            else if (command[0] == "Shift")
            {
                if (command[1] == "left") ShiftLeft(list, int.Parse(command[2]));
                else ShiftRight(list, int.Parse(command[2]));
            }
        }
        Console.WriteLine(String.Join(" ", list));
    }
}