//Create a program that sorts some students by their grade in descending order. Each student should have:
//•	First name(String)
//•	Last name(String)
//•	Grade(a floating - point number)
//Input
//•	On the first line, you will receive a number n - the count of all students
//•	On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}"
//Output
//•	Print out the information about each student in the following format: "{first name} {second name}: {grade}"


using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"{FirstName} {LastName}: {Grade:f2}");
    }

    public Student(string[] input)
    {
        FirstName = input[0];
        LastName = input[1];
        Grade = double.Parse(input[2]);
    }
}

internal class Program
{
    static void Main()
    {
        List<Student> studentsList = new List<Student>();
        int numberOfStudents = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfStudents; i++)
        {
            string[] input = Console.ReadLine().Split();
            Student newStudent = new Student(input);
            studentsList.Add(newStudent);
        }

        studentsList = studentsList.OrderByDescending(x => x.Grade).ToList();
        foreach (Student student in studentsList)
            student.PrintInfo();
    }
}