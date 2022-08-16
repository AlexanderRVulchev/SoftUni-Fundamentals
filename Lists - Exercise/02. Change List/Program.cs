//Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
//Your program may receive the following commands:
//•	Delete
//{ element} – delete all elements in the array, which are equal to the given element.
//•	Insert {element} { position} – insert the element at the given position.
//You should exit the program when you receive the "end" command.
//Print all numbers in the array separated by a single whitespace.

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split().ToArray();
            if (command[0] == "Delete") nums.RemoveAll(x => x == int.Parse(command[1]));
            else if (command[0] == "Insert") nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}