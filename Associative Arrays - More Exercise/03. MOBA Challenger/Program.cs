//Peter is a pro - MOBA player, he is struggling to become а master of the Challenger tier.
//So he watches carefully the statistics in the tier.
//You will receive several input lines in one of the following formats:
//"{player} -> {position} -> {skill}"
//"{player} vs {player}"
//The player and position are strings, the given skill will be an integer number. You need to keep track of every player. 
//When you receive a player and their position and skill, add them to the player pool, if they aren't present,
//else add their position and skill or update their skill, only if the current position skill is lower than the new value.
//If you receive "{player} vs {player}" and both players exist in the tier, they duel with the following rules:
//Compare their positions, if they have at least one in common, the player with better total skill points wins and the other is demoted from the tier -> remove him/her.
//If they have the same total skill points, the duel is a tie and they both continue in the season.
//If they don't have positions in common, the duel isn't happening and both continue in the Season.
//You should end your program when you receive the command "Season end". At that point, you should print the players, ordered by total skill in descending order,
//then ordered by player name in ascending order. Foreach player print their position and skill, ordered descending by skill, then ordered by position name in ascending order.
//Input / Constraints
//•	The input comes in the form of commands in one of the formats specified above.
//•	Player and position will always be one-word string, containing no whitespaces.
//•	Skill will be an integer in the range [0…1000].
//•	There will be no invalid input lines.
//•	The programm ends when you receive the command "Season end".
//Output
//•	The output format for each player is:
//"{player}: {totalSkill} skill"
//"- {position} <::> {skill}"


using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
        string input;
        while ((input = Console.ReadLine()) != "Season end")
        {
            string[] tokens = input.Split(new string[] { " -> ", " vs " }, StringSplitOptions.None);
            if (tokens.Length == 3) AddPlayerInfo(players, tokens[0], tokens[1], int.Parse(tokens[2]));
            else if (tokens.Length == 2) PlayOutDuel(players, tokens[0], tokens[1]);  
        }
        DisplayResults(players);
    }


    private static void AddPlayerInfo(Dictionary<string, Dictionary<string, int>> players, string playerName, string position, int skill)
    {
        if (!players.ContainsKey(playerName))
            players.Add(playerName, new Dictionary<string, int>());
        if (!players[playerName].ContainsKey(position))
            players[playerName].Add(position, skill);
        if (players[playerName][position] < skill)
            players[playerName][position] = skill;
    }


    private static void PlayOutDuel(Dictionary<string, Dictionary<string, int>> players, string player1Name, string player2Name)
    {
        if (!players.ContainsKey(player1Name) || !players.ContainsKey(player2Name)) return;
        bool toRemovePlayer1 = false;
        bool toRemovePlayer2 = false;
        foreach (var kvp in players[player1Name])
            if (players[player2Name].ContainsKey(kvp.Key))
            {
                if (players[player1Name].Values.Sum() > players[player2Name].Values.Sum())
                    toRemovePlayer2 = true;
                    
                else if (players[player1Name].Values.Sum() < players[player2Name].Values.Sum())
                    toRemovePlayer1 = true;
                    
                else break;
            }
        if (toRemovePlayer1) players.Remove(player1Name);
        else if (toRemovePlayer2) players.Remove(player2Name);
    }


    private static void DisplayResults(Dictionary<string, Dictionary<string, int>> players)
    {
        foreach (var player in players
                 .OrderByDescending(x => x.Value.Values.Sum())
                 .ThenBy(x => x.Key))
        {
            Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
            Console.WriteLine(String.Join("\n", player.Value
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => $"- {x.Key} <::> {x.Value}")));
        }
    }
}
