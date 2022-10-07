//You 've done all the work and the last thing left to accomplish is to own a legendary item.
//However, it's a tedious process and it requires quite a bit of farming.
//Anyway, you are not too pretentious - any legendary item will do. The possible items are:
//•	Shadowmourne - requires 250 Shards;
//•	Valanyr - requires 250 Fragments;
//•	Dragonwrath - requires 250 Motes;
//Shards, Fragments and Motes are the key materials and everything else is junk. You will be given lines of input, in the format: "2 motes 3 ores 15 stones"
//Keep track of the key materials – the first one that reaches the 250 marks, wins the race.
//At that point, you have to print that the corresponding legendary item is obtained.
//Then print the remaining shards, fragments, motes, each on a new line.Finally, print the collected junk items.


using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        Dictionary<string, int> materialQtyPairs = new Dictionary<string, int>();
        bool legendaryAquired = false;
        while (!IsFarmingComplete(materialQtyPairs))
        {
            string[] input = Console.ReadLine().Split();

            List<int> quantities = new List<int>();
            List<string> materials = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0) quantities.Add(int.Parse(input[i]));
                else materials.Add(input[i].ToLower());
            }

            for (int i = 0; i < materials.Count; i++)
            {
                if (!materialQtyPairs.ContainsKey(materials[i]))
                    materialQtyPairs.Add(materials[i], quantities[i]);
                else materialQtyPairs[materials[i]] += quantities[i];
                if (IsFarmingComplete(materialQtyPairs))
                {
                    legendaryAquired = true;
                    break;
                }
            }
            if (legendaryAquired) break;
        }
        PrintResultMaterials(materialQtyPairs);
    }

    static bool IsFarmingComplete(Dictionary<string, int> pairs)
    {
        if (pairs.ContainsKey("motes") && pairs["motes"] >= 250)
        {
            Console.WriteLine("Dragonwrath obtained!");
            pairs["motes"] -= 250;
            return true;
        }
        else if (pairs.ContainsKey("fragments") && pairs["fragments"] >= 250)
        {
            Console.WriteLine("Valanyr obtained!");
            pairs["fragments"] -= 250;
            return true;
        }
        else if (pairs.ContainsKey("shards") && pairs["shards"] >= 250)
        {
            Console.WriteLine("Shadowmourne obtained!");
            pairs["shards"] -= 250;
            return true;
        }
        return false;
    }

    static void PrintResultMaterials(Dictionary<string, int> pairs)
    {
        foreach (KeyValuePair<string, int> pair in pairs)            
            if (pair.Key == "motes" || pair.Key == "fragments" || pair.Key == "shards")
            Console.WriteLine($"{pair.Key}: {pair.Value}");

        foreach (KeyValuePair<string, int> pair in pairs)
            if (!(pair.Key == "motes" || pair.Key == "fragments" || pair.Key == "shards"))
                Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
}

