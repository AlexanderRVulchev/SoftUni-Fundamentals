using System;
using System.Linq;


internal class Program
{
    static void Main()
    {
        int numStudents = int.Parse(Console.ReadLine());
        int numLectures = int.Parse(Console.ReadLine());
        int additionalBonus = int.Parse(Console.ReadLine());
        int[] studentAttendance = new int[numStudents];
        for (int i = 0; i < numStudents; i++)
        {
            studentAttendance[i] = int.Parse(Console.ReadLine());
        }

        int bestStudentLectures = 0;
        if (studentAttendance.Length > 0)
            bestStudentLectures = studentAttendance.Max();

        double maxBonus = 0;
        if (numLectures != 0)
            maxBonus = (double)bestStudentLectures / (double)numLectures * (5 + additionalBonus);
        maxBonus = Math.Ceiling(maxBonus);

        Console.WriteLine($"Max Bonus: {maxBonus}.");
        Console.WriteLine($"The student has attended {bestStudentLectures} lectures.");
    }
}