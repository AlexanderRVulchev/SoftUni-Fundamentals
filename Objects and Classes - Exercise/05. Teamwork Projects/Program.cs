//It 's time for the teamwork projects and you are responsible for gathering the teams.
//First, you will receive an integer - the count of the teams you will have to register.
//You will be given a user and a team, separated with "-".  The user is the creator of the team. For every newly created team you should print a message: 
//"Team {teamName} has been created by {user}!".
//Next, you will receive а user with a team, separated with "->", which means that the user wants to join that team.
//Upon receiving the command: "end of assignment", you should print every team, ordered by the count of its members (descending) and then by name (ascending).
//For each team, you have to print its members sorted by name (ascending). However, there are several rules:
//•	If а user tries to create a team more than once, a message should be displayed: 
//-"Team {teamName} was already created!"
//•	A creator of a team cannot create another team – the following message should be thrown: 
//-"{user} cannot create another team!"
//•	If а user tries to join a non-existent team, a message should be displayed: 
//-"Team {teamName} does not exist!"
//•	A member of a team cannot join another team – the following message should be thrown:
//-"Member {user} cannot join team {team Name}!"
//•	In the end, teams with zero members (with only a creator) should disband and you have to print them ordered by name in ascending order. 
//•	 Every valid team should be printed ordered by name (ascending) in the following format:
//"{teamName}
//- { creator}
//-- { member}…"


using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < teamsCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split('-').ToArray();
                List<string> membersList = new List<string>();
                Team team = new Team();
                team.TeamName = newTeam[1];
                team.CreatorName = newTeam[0];
                team.Members = membersList;
                if (!teams.Select(x => x.TeamName).Contains(team.TeamName))
                {
                    if (!teams.Select(x => x.CreatorName).Contains(team.CreatorName))
                    {
                        teams.Add(team);
                        Console.WriteLine("Team {0} has been created by {1}!", newTeam[1], newTeam[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} cannot create another team!", team.CreatorName);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} was already created!", team.TeamName);
                }
            }

            string teamRegistration = Console.ReadLine();

            while (!teamRegistration.Equals("end of assignment"))
            {
                var split = teamRegistration.Split(new char[] { '-', '>' }).ToArray();
                string newUser = split[0];
                string teamName = split[2];
                if (!teams.Select(x => x.TeamName).Contains(teamName))
                {
                    Console.WriteLine("Team {0} does not exist!", teamName);
                }
                else if (teams.Select(x => x.Members).Any(x => x.Contains(newUser)) || teams.Select(x => x.CreatorName).Contains(newUser))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", newUser, teamName);
                }
                else
                {
                    int teamToJoinIndex = teams.FindIndex(x => x.TeamName == teamName);
                    teams[teamToJoinIndex].Members.Add(newUser);
                }

                teamRegistration = Console.ReadLine();
            }

            var teamsToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0);
            var fullTeams = teams.
            OrderByDescending(x => x.Members.Count).
            ThenBy(x => x.TeamName).
            Where(x => x.Members.Count > 0);

            foreach (var team in fullTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsToDisband)
            {
                Console.WriteLine(item.TeamName);
            }

        }
    }

}