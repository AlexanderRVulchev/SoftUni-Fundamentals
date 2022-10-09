//Create a program that keeps information about companies and their employees. 
//You will be receiving a company name and an employee's id, until you receive the command "End" command. Add each employee to the given company.
//Keep in mind that a company cannot have two employees with the same id.
//When you finish reading the data and print the company name and each employee's id in the following format:
//{companyName}
//-- { id1}
//-- { id2}
//-- { idN}
//Input / Constraints
//•	Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
//•	The input always will be valid.


using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> companyData = new Dictionary<string, List<string>>();
        string input;
        while ((input = Console.ReadLine())!= "End")
        {
            string[] commands = input.Split(new string[] { " -> " }, StringSplitOptions.None);
            string company = commands[0];
            string employee = commands[1];
            if (!companyData.ContainsKey(company))
                companyData.Add(company, new List<string>());
            if (!companyData[company].Contains(employee))
                companyData[company].Add(employee);
        }

        foreach (KeyValuePair<string, List<string>> company in companyData)
        {
            Console.WriteLine(company.Key);
            foreach (string employee in company.Value)
            {
                Console.WriteLine($"-- {employee}");
            }
        }
    }
}