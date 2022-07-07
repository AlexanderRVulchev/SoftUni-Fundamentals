//Snow White loves her dwarfs, but there are so many and she doesn't know how to order them. Does she order them by name?
//Or by the color of their hat? Or by physics? She can't decide, so it's up to you to write a program that does it for her.
//You will be receiving several input lines which contain data about dwarfs in the following format:
//"{dwarfName} <:> {dwarfHatColor} <:> {dwarfPhysics}"
//The dwarfName and the dwarfHatColor are strings. The dwarfPhysics is an integer.
//You must store the dwarfs in your program. There are several rules though:
//•	If 2 dwarfs have the same name but different colors, they should be considered different dwarfs, and you should store both of them.
//•	If 2 dwarfs have the same name and the same color, store the one with the higher physics.
//When you receive the command "Once upon a time", the input ends.
//You must order the dwarfs by physics in descending order and then by the total count of dwarfs with the same hat color in descending order. 
//Then you must print them all. 
//Input
//•	The input will consist of several input lines, containing dwarf data in the format, specified above.
//•	The input ends when you receive the command "Once upon a time". 
//Output
//•	As output, you must print the dwarfs, ordered in the way, specified above.
//•	The output format is: "({hatColor}) {name} <-> {physics}"


using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    class Dwarf
    {
        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physics { get; set; }

        public Dwarf(string name, string hat, int physics)
        {
            Name = name;
            HatColor = hat;
            Physics = physics;
        }
    }

    static void Main()
    {
        List<Dwarf> dwarves = new List<Dwarf>();
        Dictionary<string, int> hats = new Dictionary<string, int>();
        string input;
        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            string[] tokens = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
            string name = tokens[0];
            string hat = tokens[1];
            int physics = int.Parse(tokens[2]);

            if (!dwarves.Any(x => x.HatColor == hat && x.Name == name))
            {
                dwarves.Add(new Dwarf(name, hat, physics));
                if (!hats.ContainsKey(hat))
                    hats.Add(hat, 0);
                hats[hat]++;
            }

            int hatIndex = dwarves.FindIndex(x => x.HatColor == hat && x.Name == name);

            if (dwarves[hatIndex].Name == name)
            {
                if (dwarves[hatIndex].Physics < physics)
                    dwarves[hatIndex].Physics = physics;
            }
        }

        foreach (Dwarf dwarf in dwarves
            .OrderByDescending(x => x.Physics)
            .ThenByDescending(x => hats[x.HatColor]))
            Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
    }
}