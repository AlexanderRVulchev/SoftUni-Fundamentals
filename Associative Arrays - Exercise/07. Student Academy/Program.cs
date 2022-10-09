//Create a program that keeps the information about students and their grades. 
//You will receive n pair of rows. First, you will receive the student's name, after that, you will receive their grade.
//Check if the student already exists and if not, add him. Keep track of all grades for each student.
//When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
//Print the students and their average grade in the following format:
//"{name} –> {averageGrade}"
//Format the average grade to the 2nd decimal place.

using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Dictionary<string, List<double>> studentGradesPair = new Dictionary<string, List<double>>();
        int rowPairs = int.Parse(Console.ReadLine());
        for (int i = 0; i < rowPairs; i++)
        {
            string studentName = Console.ReadLine();
            double studentGrade = double.Parse(Console.ReadLine());
            if (!studentGradesPair.ContainsKey(studentName))
                studentGradesPair.Add(studentName, new List<double>());
            studentGradesPair[studentName].Add(studentGrade);
        }

        foreach (var kvp in studentGradesPair.Where(x => x.Value.Sum() / x.Value.Count >= 4.50))        
            Console.WriteLine($"{kvp.Key} -> {kvp.Value.Sum() / kvp.Value.Count:f2}");        
    }
}
