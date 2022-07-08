//You know the judge system, right? Your job is to create a program similar to the Judge system. 
//You will receive several input lines in one of the following formats:
//"{username} -> {contest} -> {points}"
//The constestName and username are strings, the given points will be an integer number.
//You need to keep track of every contest and individual statistics of every user.
//You should check if such a contest already exists and if not, add it, otherwise, check if the current user is participating in the contest.
//If they are participating, take the higher score, otherwise, just add it. 
//Also, you need to keep individual statistics for each user - the total points of all contests. 
//You should end your program when you receive the command "no more time".
//At that point, you should print each contest in order of input, for each contest print the participants ordered by points in descending order,
//then ordered by name in ascending order. After that, you should print individual statistics for every participant,
//ordered by total points in descending order, and then by alphabetical order.
//Input / Constraints
//•	The input comes in the form of commands in one of the formats specified above.
//•	Username and contest name always will be one word.
//•	Points will be an integer in the range [0…1000].
//•	There will be no invalid input lines.
//•	If all sorting criteria fail, the order should be by order of input.
//•	The input ends when you receive the command "no more time".
//Output
//•	The output format for the contests is:
//"{constestName}: {participants.Count} participants"
//"{position}. {username} <::> {points}"
//•	After you print all contests, print the individual statistics for every participant.
//•	The output format is:
//"Individual standings:"
//"{position}. {username} -> {totalPoints}"


using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> allContests = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, Dictionary <string, int>> allParticipants = new Dictionary<string, Dictionary<string, int>>();

        string input;
        while ((input = Console.ReadLine()) != "no more time")
        {
            string[] command = input.Split(new string[] { " -> " }, StringSplitOptions.None);
            string username = command[0];
            string contest = command[1];
            int points = int.Parse(command[2]);

            if (!allContests.ContainsKey(contest))
                allContests.Add(contest, new Dictionary<string, int>());
            if (!allContests[contest].ContainsKey(username))
                allContests[contest].Add(username, points);

            if (!allParticipants.ContainsKey(username))
                allParticipants.Add(username, new Dictionary<string, int>());
            if (!allParticipants[username].ContainsKey(contest))
                allParticipants[username].Add(contest, points);          

                                    
            if (allContests[contest][username] < points)
            {
                allContests[contest][username] = points;                
                allParticipants[username][contest] = points;
            }
        }

        foreach (var contest in allContests)
        {
            int numContests = 1;
            Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
            Console.WriteLine(String.Join("\n", contest.Value
                                          .OrderByDescending(x => x.Value)
                                          .ThenBy(y => y.Key)
                                          .Select(y => $"{numContests++}. {y.Key} <::> {y.Value}")));
        }
        Console.WriteLine("Individual standings:");
        
        int numParticipants = 1;
        Console.WriteLine(String.Join("\n", allParticipants.OrderByDescending(x => x.Value.Values.Sum())
            .ThenBy(y => y.Key)
            .Select(y => $"{numParticipants++}. {y.Key} -> {y.Value.Values.Sum()}")));
    }
}
