//You have now returned from your world tour. On your way, you have discovered some new plants,
//and you want to gather some information about them and create an exhibition to see which plant is highest rated.
//On the first line, you will receive a number n. On the next n lines,
//you will be given some information about the plants that you have discovered in the format:
//"{plant}<->{rarity}".Store that information because you will need it later.
//If you receive a plant more than once, update its rarity.
//After that, until you receive the command "Exhibition", you will be given some of these commands:
//•	"Rate: {plant} - {rating}" – add the given rating to the plant (store all ratings)
//•	"Update: {plant} - {new_rarity}" – update the rarity of the plant with the new one
//•	"Reset: {plant}" – remove all the ratings of the given plant
//Note: If any given plant name is invalid, print "error"
//After the command "Exhibition", print the information that you have about the plants in the following format:
//"Plants for the exhibition:
//- { plant_name1}; Rarity: { rarity}; Rating: { average_rating}
//- { plant_name2}; Rarity: { rarity}; Rating: { average_rating}
//…
//- { plant_nameN}; Rarity: { rarity}; Rating: { average_rating}
//"
//The average rating should be formatted to the second decimal place.
//Input / Constraints
//•	You will receive the input as described above
//•	JavaScript: you will receive a list of strings
//Output
//•	Print the information about all plants as described above

using System;
using System.Collections.Generic;
using System.Linq;

class Plant
{
    public string Name { get; set; }
    public string Rarity { get; set; }
    public List<double> Rating { get; set; }

    public Plant(string name, string rarity)
    {
        this.Name = name;
        this.Rarity = rarity;
        this.Rating = new List<double>();
    }
}

class Program
{
    static void Main()
    {
        List<Plant> plants = new List<Plant>();
        ReadInitialPlantEntries(plants);
        string input;
        while ((input = Console.ReadLine()) != "Exhibition")
        {
            string[] cmd = input.Split(new string[] { ": ", " - " }, StringSplitOptions.None);
            if (!plants.Any(x => x.Name == cmd[1]))
            {
                Console.WriteLine("error");
                continue;
            }
            Plant currentPlant = plants.Find(x => x.Name == cmd[1]);
            switch (cmd[0])
            {
                case "Rate":
                    currentPlant.Rating.Add(double.Parse(cmd[2])); break;
                case "Update":
                    currentPlant.Rarity = cmd[2]; break;
                case "Reset":
                    currentPlant.Rating.Clear(); break;
            }
        }
        Console.WriteLine("Plants for the exhibition:");
        foreach (Plant plant in plants)
        {
            double rating = plant.Rating.Count > 0 ? plant.Rating.Average() : 0;
            Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {rating:f2}");
        }
    }

    private static void ReadInitialPlantEntries(List<Plant> plants)
    {
        int numberOfEntries = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfEntries; i++)
        {
            string[] input = Console.ReadLine().Split("<->");
            string plantName = input[0];
            string plantRarity = input[1];

            if (plants.Any(x => x.Name == plantName))
            {
                Plant plantToUpdate = plants.Find(x => x.Name == plantName);
                plantToUpdate.Rarity = plantRarity;
            }
            else
                plants.Add(new Plant(plantName, plantRarity));
        }
    }
}