//On the first line of the standard input, you will receive an integer n –
//the number of pieces you will initially have.
//On the next n lines, the pieces themselves will follow with their composer and key,
//separated by "|" in the following format: "{piece}|{composer}|{key}".
//Then, you will be receiving different commands, each on a new line,
//separated by "|", until the "Stop" command is given:
//•	"Add|{piece}|{composer}|{key}":
//o You need to add the given piece with the information about it to the other pieces and print:
//"{piece} by {composer} in {key} added to the collection!"
//o If the piece is already in the collection, print:
//"{piece} is already in the collection!"
//•	"Remove|{piece}":
//o If the piece is in the collection, remove it and print:
//"Successfully removed {piece}!"
//o Otherwise, print:
//"Invalid operation! {piece} does not exist in the collection."
//•	"ChangeKey|{piece}|{new key}":
//o If the piece is in the collection, change its key with the given one and print:
//"Changed the key of {piece} to {new key}!"
//o Otherwise, print:
//"Invalid operation! {piece} does not exist in the collection."
//Upon receiving the "Stop" command, you need to print all pieces in your collection in the following format:
//"{Piece} -> Composer: {composer}, Key: {key}"
//Input / Constraints
//•	You will receive a single integer at first – the initial number of pieces in the collection
//•	For each piece, you will receive a single line of text with information about it.
//•	Then you will receive multiple commands in the way described above until the command "Stop".
//Output
//•	All the output messages with the appropriate formats are described in the problem description.

using System;
using System.Collections.Generic;
using System.Linq;

class Piece
{
    public string Name { get; set; }
    public string Composer { get; set; }
    public string Key { get; set; }

    public Piece(string name, string composer, string key)
    {
        this.Key = key;
        this.Name = name;
        this.Composer = composer;
    }
}

class Program
{
    static void Main()
    {
        List<Piece> pieces = new List<Piece>();
        int numberOfPieces = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPieces; i++)
        {
            string[] pieceInfo = Console.ReadLine().Split('|');
            pieces.Add(new Piece(pieceInfo[0], pieceInfo[1], pieceInfo[2]));
        }
        string input;
        while ((input = Console.ReadLine()) != "Stop")
        {
            string[] tokens = input.Split('|');
            switch (tokens[0])
            {
                case "Add":
                    Add(pieces, tokens); break;
                case "Remove":
                    Remove(pieces, tokens); break;
                case "ChangeKey":
                    ChangeKey(pieces, tokens); break;
            }
        }
        Console.WriteLine(String.Join("\n", pieces
            .Select(x => $"{x.Name} -> Composer: {x.Composer}, Key: {x.Key}")));
    }

    private static void ChangeKey(List<Piece> pieces, string[] tokens)
    {
        if (pieces.Any(x => x.Name == tokens[1]))
        {
            pieces.First(x => x.Name == tokens[1]).Key = tokens[2];
            Console.WriteLine($"Changed the key of {tokens[1]} to {tokens[2]}!");
        }
        else
            Console.WriteLine($"Invalid operation! {tokens[1]} does not exist in the collection.");
    }

    private static void Remove(List<Piece> pieces, string[] tokens)
    {
        if (pieces.Any(x => x.Name == tokens[1]))
        {
            Piece pieceToRemove = pieces.Find(x => x.Name == tokens[1]);
            Console.WriteLine($"Successfully removed {pieceToRemove.Name}!");
            pieces.Remove(pieceToRemove);
        }
        else
            Console.WriteLine($"Invalid operation! {tokens[1]} does not exist in the collection.");
    }

    private static void Add(List<Piece> pieces, string[] tokens)
    {
        if (pieces.Any(x => x.Name == tokens[1]))
            Console.WriteLine($"{tokens[1]} is already in the collection!");
        else
        {
            pieces.Add(new Piece(tokens[1], tokens[2], tokens[3]));
            Console.WriteLine($"{tokens[1]} by {tokens[2]} in {tokens[3]} added to the collection!");
        }
    }
}