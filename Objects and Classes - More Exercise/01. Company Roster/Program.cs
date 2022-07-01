//Define a class Employee that holds the following information: a name, a salary, and a department. 
//Your task is to write a program, which takes N lines of employees from the console, calculates the department with the highest average salary,
//and prints for each employee in that department his name and salary – sorted by salary in descending order.
//The salary should be rounded to two digits after the decimal separator.


using System;
using System.Collections.Generic;
using System.Linq;


public class Employee
{
    public string Name { get; set; }

    public double Salary { get; set; }
}

public class Department
{
    public string Name { get; set; }

    public List<Employee> Employees { get; set; }

    public double AverageSalary { get; set; }

    public void CalculateAverageAndSort()
    {
        double salarySum = 0;
        foreach (var employee in Employees)
        {
            salarySum += employee.Salary;
        }
        AverageSalary = salarySum / Employees.Count;
        Employees = Employees.OrderByDescending(x => x.Salary).ToList();
    }

    public Department()
    {
        Employees = new List<Employee>();
    }
}

internal class Program
{
    static List<Department> AddNewEmployee(List<Department> departments)
    {
        string[] employeeData = Console.ReadLine().Split();
        Employee newEmployee = new Employee();
        string newName = employeeData[0];
        double newSalary = double.Parse(employeeData[1]);
        string newDepartment = employeeData[2];
        newEmployee.Name = newName;
        newEmployee.Salary = newSalary;
        if (!departments.Any(x => x.Name == newDepartment))
        {
            Department departmentToAdd = new Department();
            departmentToAdd.Name = newDepartment;
            departments.Add(departmentToAdd);
        }

        for (int i = 0; i < departments.Count; i++)
            if (departments[i].Name == newDepartment)
                departments[i].Employees.Add(newEmployee);

        return departments;
    }


    static void Main()
    {
        List<Department> departments = new List<Department>();
        int numberOfEmployees = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfEmployees; i++)
            AddNewEmployee(departments);

        string bestPaidDepartment = String.Empty;
        double highestAverageSalary = 0;
        int bestIndex = 0;
        for (int i = 0; i < departments.Count; i++)
        {
            departments[i].CalculateAverageAndSort();
            if (departments[i].AverageSalary > highestAverageSalary)
            {
                highestAverageSalary = departments[i].AverageSalary;
                bestPaidDepartment = departments[i].Name;
                bestIndex = i;
            }
        }

        Console.WriteLine($"Highest Average Salary: {bestPaidDepartment}");
        for (int i = 0; i < departments[bestIndex].Employees.Count; i++)
            Console.WriteLine($"{departments[bestIndex].Employees[i].Name} {departments[bestIndex].Employees[i].Salary:f2}");
    }
}

