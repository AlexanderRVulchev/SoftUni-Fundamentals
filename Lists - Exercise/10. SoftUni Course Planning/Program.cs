//You are tasked to help with the planning of the next Technology Fundamentals course by keeping track of the lessons,
//that are going to be included in the course, as well as all the exercises for the lessons. 
//On the first line you will receive the initial schedule of the lessons and
//the exercises that are going to be a part of the next course, separated by comma and space ", ".
//But before the course starts, some changes should be made.
//Until you receive "course start" you will be given some commands to modify the course schedule.
//The possible commands are: 
//Add: { lessonTitle} – add the lesson to the end of the schedule, if it does not exist.
//Insert:{ lessonTitle}:{ index} – insert the lesson to the given index, if it does not exist.
//Remove:{ lessonTitle} – remove the lesson, if it exists.
//Swap:{ lessonTitle}:{ lessonTitle} – change the place of the two lessons, if they exist.
//Exercise:{ lessonTitle} – add Exercise in the schedule right after the lesson index,
//if the lesson exists and there is no exercise already,
//in the following format "{lessonTitle}-Exercise".
//If the lesson doesn`t exist, add the lesson in the end of the course schedule, followed by the Exercise.
//Each time you Swap or Remove a lesson, you should do the same with the Exercises,
//if there are any, which follow the lessons.
//Input / Constraints
//•	first line – the initial schedule lessons – strings, separated by comma and space ", "
//•	until "course start" you will receive commands in the format described above
//Output
//•	Print the whole course schedule, each lesson on a new line with its number(index) in the schedule: 
//"{lesson index}.{lessonTitle}"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static List<string> Add(List<string> list, string title)
    {
        list.Add(title);
        return list;
    }

    static List<string> Insert(List<string> list, string title, int index)
    {
        if (list.Contains(title)) return list;

        list.Insert(index, title);
        return list;
    }

    static List<string> Remove(List<string> list, string title)
    {
        if (!list.Contains(title)) return list;

        list.Remove(title);
        return list;

    }

    static List<string> Swap(List<string> list, string firstTitle, string secondtitle)
    {
        if (list.Contains(firstTitle) && list.Contains(secondtitle))
        {
            int firstIndex = -1;
            int secondIndex = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == firstTitle) firstIndex = i;
                else if (list[i] == secondtitle) secondIndex = i;
            }
            string temp;
            temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
        return list;
    }

    static List<string> Exercise(List<string> list, string title)
    {
        if (!list.Contains(title)) list.Add(title);
        if (list.Contains(title + "-Exercise")) return list;
        int titleIndex = -1;
        for (int i = 0; i < list.Count; i++)
            if (list[i] == title) titleIndex = i;

        list.Insert(titleIndex + 1, title + "-Exercise");
        return list;
    }

    static List<string> RearrangeExercises(List<string> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
            if (list[i + 1].Contains("-Exercise") && list[i + 1] != list[i] + "-Exercise")
                for (int j = 0; j < list.Count; j++)
                    if (list[i + 1] == list[j] + "-Exercise")
                    {
                        string temp = list[i + 1];
                        list.RemoveAt(i + 1);
                        list.Insert(j + 1, temp);
                    }
        return list;
    }

    static void Main()
    {
        List<string> list = Console.ReadLine().Split(',').ToList();

        // Clearing spaces in the strings
        for (int i = 1; i < list.Count; i++)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(list[i]);
            sb.Remove(0, 1);
            list[i] = sb.ToString();
        }
        string input;

        while ((input = Console.ReadLine()) != "course start")
        {
            string[] command = input.Split(':').ToArray();
            if (command[0] == "Add") list = Add(list, command[1]);
            else if (command[0] == "Insert") list = Insert(list, command[1], int.Parse(command[2]));
            else if (command[0] == "Remove") list = Remove(list, command[1]);
            else if (command[0] == "Swap") list = Swap(list, command[1], command[2]);
            else if (command[0] == "Exercise") list = Exercise(list, command[1]);
            list = RearrangeExercises(list);
        }

        for (int i = 1; i <= list.Count; i++)
            Console.WriteLine($"{i}.{list[i - 1]}");
    }
}
