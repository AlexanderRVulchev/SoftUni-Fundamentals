//Until the "Sail" command is given, you will be receiving:
//•	You and your crew have targeted cities, with their population and gold, separated by "||".
//•	If you receive a city that has already been received, you have to increase the population and gold with the given values.
//After the "Sail" command, you will start receiving lines of text representing events until the "End" command is given. 
//Events will be in the following format:
//•	"Plunder=>{town}=>{people}=>{gold}"
//o You have successfully attacked and plundered the town, killing the given number of people and stealing the respective amount of gold. 
//o	For every town you attack print this message: "{town} plundered! {gold} gold stolen, {people} citizens killed."
//o If any of those two values (population or gold) reaches zero, the town is disbanded.
//	You need to remove it from your collection of targeted cities and print the following message: "{town} has been wiped off the map!"
//o There will be no case of receiving more people or gold than there is in the city.
//•	"Prosper=>{town}=>{gold}"
//o	There has been dramatic economic growth in the given city, increasing its treasury by the given amount of gold.
//o	The gold amount can be a negative number, so be careful. If a negative amount of gold is given, print:
//"Gold added cannot be a negative number!" and ignore the command.
//o	If the given gold is a valid amount, increase the town's gold reserves by the respective amount and print the following message: 
//"{gold added} gold added to the city treasury. {town} now has {total gold} gold."
//Input
//•	On the first lines, until the "Sail" command, you will be receiving strings representing the cities with their gold and population, separated by "||"
//•	On the following lines, until the "End" command, you will be receiving strings representing the actions described above, separated by "=>"
//Output
//•	After receiving the "End" command, if there are any existing settlements on your list of targets, you need to print all of them, in the following format:
//"Ahoy, Captain! There are {count} wealthy settlements to go to:
//{ town1} -> Population: { people}
//citizens, Gold: { gold}
//kg
//{ town2} -> Population: { people}
//citizens, Gold: { gold}
//kg
//   …
//{ town…n} -> Population: { people}
//citizens, Gold: { gold}
//kg "
//•	If there are no settlements left to plunder, print:
//"Ahoy, Captain! All targets have been plundered and destroyed!"
//Constraints
//•	The initial population and gold of the settlements will be valid 32-bit integers, never negative, or exceed the respective limits.
//•	The town names in the events will always be valid towns that should be on your list.

using System;
using System.Collections.Generic;
using System.Linq;

class Town
{
    public string Name { get; set; }
    public int People { get; set; }
    public int Gold { get; set; }

    public Town(string name, int people, int gold)
    {
        this.Name = name;
        this.People = people;
        this.Gold = gold;
    }
}

class Program
{
    public static List<Town> towns = new List<Town>();

    static void Main()
    {
        ReadInputTownInfo();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] cmd = input.Split("=>");
            if (cmd[0] == "Plunder") Plunder(cmd);
            else if (cmd[0] == "Prosper") Prosper(cmd);
        }
        if (towns.Count > 0)
        {
            Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
            Console.WriteLine(String.Join("\n", towns
                .Select(x => $"{x.Name} -> Population: {x.People} citizens, Gold: {x.Gold} kg")));
        }
        else
            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
    }

    private static void ReadInputTownInfo()
    {
        string input;
        while ((input = Console.ReadLine()) != "Sail")
        {
            string[] tokens = input.Split("||");
            string name = tokens[0];
            int people = int.Parse(tokens[1]);
            int gold = int.Parse(tokens[2]);
            if (!towns.Any(x => x.Name == name))
                towns.Add(new Town(name, people, gold));
            else
            {
                Town town = towns.Find(x => x.Name == name);
                town.People += people;
                town.Gold += gold;
            }
        }
    }

    private static void Plunder(string[] cmd)
    {
        Town town = towns.Find(x => x.Name == cmd[1]);
        int plunderPeople = int.Parse(cmd[2]);
        int plunderGold = int.Parse(cmd[3]);
        town.People -= plunderPeople;
        town.Gold -= plunderGold;
        Console.WriteLine($"{town.Name} plundered! {plunderGold} gold stolen, {plunderPeople} citizens killed.");
        if (town.People <= 0 || town.Gold <= 0)
        {
            Console.WriteLine($"{town.Name} has been wiped off the map!");
            towns.Remove(town);
        }
    }

    private static void Prosper(string[] cmd)
    {
        Town town = towns.Find(x => x.Name == cmd[1]);
        int goldIncrease = int.Parse(cmd[2]);
        if (goldIncrease < 0)
            Console.WriteLine("Gold added cannot be a negative number!");
        else
        {
            town.Gold += goldIncrease;
            Console.WriteLine($"{goldIncrease} gold added to the city treasury. {town.Name} now has {town.Gold} gold.");
        }
    }
}