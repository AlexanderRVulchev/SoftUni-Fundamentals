//Define a class called Student, which will hold the following information about some students: 
//•	first name
//•	last name
//•	age
//•	home town
//Input / Constraints
//Read information about some students, until you receive the "end" command. After that, you will receive a city name.
//Output
//Print the students who are from the given city in the following format: "{firstName} {lastName} is {age} years old."

using System;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string City { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            Student student = new Student();
            string[] studentInfo = input.Split();
            student.FirstName = studentInfo[0];
            student.LastName = studentInfo[1];
            student.Age = int.Parse(studentInfo[2]);
            student.City = studentInfo[3];

            students.Add(student);
        }
        string inputCity = Console.ReadLine();
        foreach (Student student in students)        
            if (student.City == inputCity) 
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");        
    }
}