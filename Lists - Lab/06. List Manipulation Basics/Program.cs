//Write a program that reads a list of integers. Then until you receive "end", you will receive different commands:
//Add
//{ number}: add a number to the end of the list.
//Remove {number}: remove a number from the list.
//RemoveAt {index}: remove a number at a given index.
//Insert {number} { index}: insert a number at a given index.
//Note: All the indices will be valid!
//When you receive the "end" command, print the final state of the list (separated by spaces).

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split().ToArray();
            switch (command[0])
            {
                case "Add":
                    list.Add(int.Parse(command[1])); break;
                case "Remove":
                    list.Remove(int.Parse(command[1])); break;
                case "RemoveAt":
                    list.RemoveAt(int.Parse(command[1])); break;
                case "Insert":
                    list.Insert(int.Parse(command[2]), int.Parse(command[1])); break;
            }
        }
        foreach (int item in list)
            Console.Write(item + " ");
    }
}