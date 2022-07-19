//Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p persons.
//The input holds two lines: the number of people n and the capacity p of the elevator.

using System;


class Program
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());
        int courses = people / capacity;
        if (people % capacity != 0) courses++;
        Console.WriteLine(courses);
    }
}