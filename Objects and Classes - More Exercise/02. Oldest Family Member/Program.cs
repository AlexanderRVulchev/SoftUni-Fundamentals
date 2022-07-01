//Create two classes – Family and Person. The Person class should have Name and Age properties.
//The Family class should have a list of people, a method for adding members (void AddMember(Person member)),
//and a method, which returns the oldest family member (Person GetOldestMember()).
//Write a program that reads the names and ages of N people and adds them to the family. Then print the name and age of the oldest member.

using System;
using System.Collections.Generic;
using System.Linq;


public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person()
    {
        this.Name = "No Name";
        this.Age = 0;
    }


    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}

public class Family
{
    List<Person> People { get; set; }

    public void AddMember(string name, int age)
    {
        Person newMember = new Person(name, age);
        People.Add(newMember);
    }

    public Person GetOldestMember()
    {
        return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
    }

    public Family()
    {
        this.People = new List<Person>();
    }
}

internal class Program
{
    static void Main()
    {
        Family thisFamily = new Family();
        int numberOfMembers = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfMembers; i++)
        {
            string[] input = Console.ReadLine().Split();
            thisFamily.AddMember(input[0], int.Parse(input[1]));
        }
        Person oldestMember = thisFamily.GetOldestMember();
        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}