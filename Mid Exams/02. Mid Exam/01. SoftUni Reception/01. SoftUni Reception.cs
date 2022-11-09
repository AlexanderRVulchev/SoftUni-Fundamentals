using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int firstEmployeeRate = int.Parse(Console.ReadLine());
        int secondEmployeeRate = int.Parse(Console.ReadLine());
        int thirdEmployeeRate = int.Parse(Console.ReadLine());

        int hourlyRate = firstEmployeeRate + secondEmployeeRate + thirdEmployeeRate;

        int students = int.Parse(Console.ReadLine());
        if (students == 0)
        {
            Console.WriteLine("Time needed: 0h.");
            return;
        }

        int totalHours = 0;
        
        while (true)
        {            
            totalHours++;
            if (totalHours % 4 == 0) continue; 
            students -= hourlyRate;
            if (students <= 0) break;
        }

        Console.WriteLine($"Time needed: {totalHours}h.");
    }
}