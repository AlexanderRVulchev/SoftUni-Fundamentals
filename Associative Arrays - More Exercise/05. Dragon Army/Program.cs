//Heroes III is the best game ever. Everyone loves it and everyone plays it all the time.
//Stamat is no exclusion to this rule. His favorite units in the game are all types of dragons – black, red, gold, azure, etc.
//He likes them so much that he gives them names and keeps logs of their stats: damage, health and armor.
//The process of aggregating all the data is quite tedious, so he would like to have a program doing it. Since he is no programmer, it's your task to help him.
//You need to categorize dragons by their type. For each dragon, identified by name, keep information about his stats.
//Type is preserved as in the order of input, but dragons are sorted alphabetically by name.
//For each type you should also print the average damage, health and armor of the dragons. For each dragon print his stats. 
//There may be missing stats in the input, though. If a stat is missing, you should assign its default values.
//Default values are as follows: health 250, damage 45 and armor 10. Missing stat will be marked by null.
//The input is in the following format "{type} {name} {damage} {health} {armor}". Any of the integers may be assigned null value.
//See the examples below for better understanding of your task.
//If the same dragon is added a second time, the new stats should overwrite the previous ones.
//Two dragons are considered equal if they match by both name and type.
//Input
//•	On the first line, you are given number N -> the number of dragons to follow.
//•	On the next N lines, you are given input in the above-described format. There will be a single space separating each element.
//Output
//•	Print the aggregated data on the console.
//•	For each type print average stats of its dragons in format "{Type}::({damage}/{health}/{armor})".
//•	Damage, health and armor should be rounded to two digits after the decimal separator.
//•	For each dragon, print its stats in format "-{Name} -> damage: {damage}, health: {health}, armor: {armor}".
//Constraints
//•	N is in the range [1…100].
//•	The dragon's type and name are each one word only, starting with a capital letter.
//•	Damage health and armor are integers in the range [0…100000] or null.


using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    class Dragon
    {
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }

        public Dragon()
        {
            Damage = 45;
            Health = 250;
            Armor = 10;
        }
    }

    static void Main()
    {
        var dragonRooster = new Dictionary<string, SortedDictionary<string, Dragon>>();
        int numberOfDragons = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfDragons; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            string type = tokens[0];
            string name = tokens[1];
            string damage = tokens[2];
            string health = tokens[3];
            string armor = tokens[4];

            if (!dragonRooster.ContainsKey(type))
                dragonRooster.Add(type, new SortedDictionary<string, Dragon>());

            if (dragonRooster[type].ContainsKey(name))
                OverwriteStats(dragonRooster, tokens);
            else
            {
                dragonRooster[type].Add(name, new Dragon());
                if (damage != "null") 
                    dragonRooster[type][name].Damage = double.Parse(damage);
                if (health != "null") 
                    dragonRooster[type][name].Health = double.Parse(health);
                if (armor != "null") 
                    dragonRooster[type][name].Armor = double.Parse(armor);
            }

        }
        PrintResults(dragonRooster);
    }


    private static void OverwriteStats(Dictionary<string, SortedDictionary<string, Dragon>> dragonRooster, string[] tokens)
    {
        string type = tokens[0];
        string name = tokens[1];
        string damage = tokens[2];
        string health = tokens[3];
        string armor = tokens[4];

        if (damage != "null")
            dragonRooster[type][name].Damage = double.Parse(damage);
        else 
            dragonRooster[type][name].Damage = 45;

        if (health != "null")
            dragonRooster[type][name].Health = double.Parse(health);
        else 
            dragonRooster[type][name].Health = 250;

        if (armor != "null")
            dragonRooster[type][name].Armor = double.Parse(armor);
        else 
            dragonRooster[type][name].Armor = 10;
    }


    private static void PrintResults(Dictionary<string, SortedDictionary<string, Dragon>> dragonRooster)
    {
        foreach (var dragonType in dragonRooster)
        {
            double damage = dragonType.Value.Sum(x => x.Value.Damage) / dragonType.Value.Count();
            double health = dragonType.Value.Sum(x => x.Value.Health) / dragonType.Value.Count();
            double armor = dragonType.Value.Sum(x => x.Value.Armor) / dragonType.Value.Count();

            Console.WriteLine($"{dragonType.Key}::({damage:f2}/{health:f2}/{armor:f2})");

            Console.WriteLine(String.Join("\n", dragonType.Value
                .Select(x => $"-{x.Key} -> damage: {x.Value.Damage}, health: {x.Value.Health}, armor: {x.Value.Armor}")));
        }
    }
}

