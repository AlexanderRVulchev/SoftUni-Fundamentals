//Create a program that generates random fake advertisement messages to advertise a product.
//The messages must consist of 4 parts: phrase + event + author + city. Use the following predefined parts:
//•	Phrases – { "Excellent product.", "Such a great product.", "I always use that product.",
//"Best product of its category.", "Exceptional product.", "I can’t live without this product."}
//•	Events – { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
//"I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
//•	Authors – { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
//•	Cities – { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
//The format of the output message is the following: "{phrase} {event} {author} – {city}."
//You will receive the number of messages to be generated. Print each random message at a separate line.


using System;
using System.Collections.Generic;
using System.Linq;

public class Ad
{
    string Phrase { get; set; }

    string Event { get; set; }

    string Author { get; set; }

    string City { get; set; }

    public void PrintAd()
    {
        string[] phrases = {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product." };
        string[] events = {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!" };
        string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        Random rnd = new Random();
        int phraseIndex = rnd.Next(phrases.Length);
        int eventIndex = rnd.Next(events.Length);
        int authorIndex = rnd.Next(author.Length);
        int cityIndex = rnd.Next(city.Length);
        Phrase = phrases[phraseIndex];
        Event = events[eventIndex];
        Author = author[authorIndex];
        City = city[cityIndex];
        Console.WriteLine($"{Phrase} {Event} {Author} - {City}.");
    }
}


internal class Program
{
    static void Main()
    {
        int numberOfAds = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfAds; i++)
        {
            Ad newAd = new Ad();
            newAd.PrintAd();
        }
    }
}