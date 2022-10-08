//SoftUni just got a new parking lot.It's so fancy, it even has online parking validation.
//Except the online service doesn't work. It can only receive users' data, but it doesn't know what to do with it.
//Good thing you're on the dev team and know how to fix it, right?
//Write a program, which validates a parking place for an online service.Users can register to park and unregister to leave.
//The program receives 2 commands:	
//•	"register {username} {licensePlateNumber}":
//o The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
//"ERROR: already registered with plate number {licensePlateNumber}"
//o If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
// "{username} registered {licensePlateNumber} successfully"
//•	"unregister {username}":
//o If the user is not present in the database, the system should print:
//"ERROR: user {username} not found"
//o If the aforementioned check passes successfully, the system should print:
//"{username} unregistered successfully"
//After you execute all of the commands, print all of the currently registered users and their license plates in the format: 
//•	c
//Input
//•	First line: n - number of commands – integer.
//•	Next n lines: commands in one of the two possible formats:
//o Register: "register {username} {licensePlateNumber}"
//o Unregister: "unregister {username}"
//The input will always be valid and you do not need to check it explicitly.


using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        Dictionary<string, string> registry = new Dictionary<string, string>();
        int numberCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberCommands; i++)
        {
            string[] input = Console.ReadLine().Split();
            if (input[0] == "register") Register(registry, input[1], input[2]);
            else if (input[0] == "unregister") Unregister(registry, input[1]);
        }
        PrintResult(registry);
    }

    private static void Unregister(Dictionary<string, string> registry, string user)
    {
        if (!registry.ContainsKey(user))
            Console.WriteLine($"ERROR: user {user} not found");
        else
        {
            registry.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
    }

    private static void Register(Dictionary<string, string> registry, string user, string plateNumber)
    {
        if (registry.ContainsKey(user))
            Console.WriteLine($"ERROR: already registered with plate number {registry[user]}");
        else
        {
            registry.Add(user, plateNumber);
            Console.WriteLine($"{user} registered {plateNumber} successfully");
        }
    }

    private static void PrintResult(Dictionary<string, string> registry)
    {
        foreach (var user in registry)
            Console.WriteLine($"{user.Key} => {user.Value}");
    }
}