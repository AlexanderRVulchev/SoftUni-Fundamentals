using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        List<string> list = Console.ReadLine().Split(new string[] { "!" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        string input;
        while ((input = Console.ReadLine()) != "Go Shopping!")
        {
            string[] cmd = input.Split();
            switch (cmd[0])
            {
                case "Urgent":
                    Urgent(list, cmd[1]); break;
                case "Unnecessary":
                    Unnecessary(list, cmd[1]); break;
                case "Correct":
                    Correct(list, cmd[1], cmd[2]); break;
                case "Rearrange":
                    Rearrange(list, cmd[1]); break;                
            }
        }
        Console.WriteLine(string.Join(", ", list));
    }

    private static void Rearrange(List<string> list, string item)
    {
        if (!list.Contains(item)) return;
        list.Remove(item);
        list.Add(item);
    }

    private static void Correct(List<string> list, string oldItem, string newItem)
    {
        if (!list.Contains(oldItem)) return;
        int index = list.IndexOf(oldItem);
        list.RemoveAt(index);
        list.Insert(index, newItem);
    }

    private static void Unnecessary(List<string> list, string item)
    {
        list.Remove(item);
    }

    private static void Urgent(List<string> list, string item)
    {
        if (!list.Contains(item)) list.Insert(0, item);
    }
}