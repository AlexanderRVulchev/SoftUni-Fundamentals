//Here comes the final and the most interesting part – the Final ranking of the candidate-interns.
//The final ranking is determined by the points of the interview tasks and from the exams in SoftUni.
//Here is your final task. You will receive some lines of input in the format "{contest}:{password for contest}", until you receive "end of contests".
//Save that data, because you will need it later. After that, you will receive another type of input in the format
//"{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions". Here is what you need to do:
//•	Check if the contest is valid(if you received it in the first type of input).
//•	Check if the password is correct for the given contest.
//•	Save the user with the contest they take part in (a user can take part in many contests) and the points the user has in the given contest.
//If you receive the same contest and the same user, update the points, only if the new ones are more than the older ones.
//In the end, you have to print the info for the user with the most points in the format "Best candidate is {user} with total {total points} points.".
//After that print all students ordered by their names. For each user print each contest with the points in descending order. See the examples.


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{

    static void Main()
    {
        Dictionary<string, string> contestPasswords = new Dictionary<string, string>();
        string input;
        while ((input = Console.ReadLine()) != "end of contests")
        {
            string[] commands = input.Split(':');
            contestPasswords.Add(commands[0], commands[1]);
        }

        SortedDictionary<string, Dictionary<string, int>> userInfo = new SortedDictionary<string, Dictionary<string, int>>();

        input = Console.ReadLine();
        while (input != "end of submissions")
        {
            string[] commands = input.Split(new string[] { "=>" }, StringSplitOptions.None);
            string contest = commands[0];
            string password = commands[1];
            string username = commands[2];
            int points = int.Parse(commands[3]);
            if (!contestPasswords.ContainsKey(contest))
            {
                input = Console.ReadLine(); 
                continue; 
            }
            
            if (contestPasswords[contest] != password) 
            { 
                input = Console.ReadLine(); 
                continue; 
            }

            if (userInfo.ContainsKey(username) && userInfo[username].ContainsKey(contest))
            {
                if (userInfo[username][contest] < points)
                    userInfo[username][contest] = points;
            }
            else if (userInfo.ContainsKey(username))
            {
                userInfo[username].Add(contest, points);
            }
            else
            {
                userInfo.Add(username, new Dictionary<string, int>());
                userInfo[username].Add(contest, points);
            }

            input = Console.ReadLine();
        }

        string bestUser = "";
        int bestSum = 0;

        foreach (var user in userInfo)
        {
            if (user.Value.Values.Sum() > bestSum)
            {
                bestSum = user.Value.Values.Sum();
                bestUser = user.Key;
            }
        }
        Console.WriteLine($"Best candidate is {bestUser} with total {bestSum} points.");
        Console.WriteLine("Ranking: ");
                
        foreach (var user in userInfo)
        {
            Console.WriteLine(user.Key);
            Console.WriteLine(String.Join("\n", user.Value
                                          .OrderByDescending(x => x.Value)
                                          .Select(y => $"#  {y.Key} -> {y.Value}")));            
        }

    }
}
