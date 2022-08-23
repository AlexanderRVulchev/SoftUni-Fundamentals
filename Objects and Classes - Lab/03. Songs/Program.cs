//Define a class called Song that will hold the following information about some songs:
//•	Type List
//•	Name
//•	Time
//Input / Constraints
//•	On the first line, you will receive the number of songs - N.
//•	On the next N lines, you will be receiving data in the following format:  "{typeList}_{name}_{time}".
//•	On the last line, you will receive Type List or "all".
//Output
//If you receive Type List as an input on the last line, print out only the names of the songs, which are from that Type List.
//If you receive the "all" command, print out the names of all the songs.

using System;
using System.Collections.Generic;

public class Song
{
    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}

internal class Program
{
    static void Main()
    {
        int numSongs = int.Parse(Console.ReadLine());

        List<Song> songs = new List<Song>();

        for (int i = 0; i < numSongs; i++)
        {
            Song song = new Song();
            string[] input = Console.ReadLine().Split('_');
            song.TypeList = input[0];
            song.Name = input[1];
            song.Time = input[2];
            songs.Add(song);
        }

        string typeList = Console.ReadLine();
        if (typeList == "all")
        {
            foreach (Song song in songs)            
                Console.WriteLine(song.Name);
            return;
        }

        foreach (Song song in songs)        
            if (song.TypeList == typeList) Console.WriteLine(song.Name);        
    }
}