//Next, we are going to implement more complicated list commands, extending the previous task.
//Again, read a list and keep reading commands until you receive "end":
//Contains
//{ number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
//PrintEven – print all the even numbers, separated by a space.
//PrintOdd – print all the odd numbers, separated by a space.
//GetSum – print the sum of all the numbers.
//Filter {condition} { number} – print all the numbers that fulfill the given condition.
//The condition will be either '<', '>', ">=", "<=".
//After the end command, print the list only if you have made some changes to the original list.
//Changes are made only from the commands from the previous task.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void FilterList(List<int> list, string condition, int number)
    {
        switch (condition)
        {
            case "<":
                Console.WriteLine(string.Join(" ", list.Where(x => x < number)));
                break;
            case ">":
                Console.WriteLine(string.Join(" ", list.Where(x => x > number)));
                break;
            case "<=":
                Console.WriteLine(string.Join(" ", list.Where(x => x <= number)));
                break;
            case ">=":
                Console.WriteLine(string.Join(" ", list.Where(x => x >= number)));
                break;
        }
    }

    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input;
        bool changesMade = false;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split().ToArray();
            switch (command[0])
            {
                case "Add":
                    list.Add(int.Parse(command[1]));
                    changesMade = true;
                    break;
                case "Remove":
                    list.Remove(int.Parse(command[1]));
                    changesMade = true;
                    break;
                case "RemoveAt":
                    list.RemoveAt(int.Parse(command[1]));
                    changesMade = true;
                    break;
                case "Insert":
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    changesMade = true;
                    break;
                case "Contains":
                    if (list.Contains(int.Parse(command[1])))
                        Console.WriteLine("Yes");
                    else Console.WriteLine("No such number");
                    break;
                case "PrintEven":
                    Console.WriteLine(String.Join(" ", list.Where(x => x % 2 == 0)));
                    break;
                case "PrintOdd":
                    Console.WriteLine(String.Join(" ", list.Where(x => x % 2 == 1)));
                    break;
                case "GetSum":
                    Console.WriteLine(list.Sum());
                    break;
                case "Filter":
                    FilterList(list, command[1], int.Parse(command[2]));
                    break;
                default: break;
            }
        }
        if (changesMade) Console.WriteLine(String.Join(" ", list));
    }
}