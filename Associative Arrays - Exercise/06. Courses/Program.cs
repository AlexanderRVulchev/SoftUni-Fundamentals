//Create a program that keeps the information about courses. Each course has a name and registered students.
//You will be receiving a course name and a student name, until you receive the command "end".
//Check if such a course already exists, and if not, add the course. Register the user into the course.
//When you receive the command "end", print the courses with their names and total registered users.
//For each contest print the registered users.
//Input
//•	Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
//•	The product data is always delimited by " : ".
//Output
//•	Print the information about each course in the following the format: 
//"{courseName}: {registeredStudents}"
//•	Print the information about each student in the following the format:
//"-- {studentName}"

using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
        string input;
        while ((input = Console.ReadLine())!= "end")
        {
            string[] commands = input.Split(new string[] { " : " }, StringSplitOptions.None);
            string course = commands[0];
            string student = commands[1];
            if (!courses.ContainsKey(course))
                courses.Add(course, new List<string>());
            courses[course].Add(student);
        }

        foreach (KeyValuePair<string, List<string>> course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");
            course.Value.ForEach(x => Console.WriteLine($"-- {x}"));
        }
    }
}