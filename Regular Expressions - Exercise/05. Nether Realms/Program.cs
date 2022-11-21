using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;


public class Demon
{
    public string Name { get; set; }

    public int Health { get; set; }

    public double Damage { get; set; }

    public Demon(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    => $"{this.Name} - {this.Health} health, {this.Damage:f2} damage";
}


internal class Program
{
    static void Main()
    {
        List<Demon> demons = GetDemonNames();
        for (int i = 0; i < demons.Count; i++)
        {
            demons[i].Health = GetDemonsHealth(demons[i].Name);
            demons[i].Damage = GetDemonsDamage(demons[i].Name);
        }
        Console.WriteLine(String.Join(Environment.NewLine, demons.OrderBy(x => x.Name)));
    }

    private static List<Demon> GetDemonNames()
    {
        string[] names = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<Demon> demons = new List<Demon>();
        foreach (string name in names)
            demons.Add(new Demon(name));
        return demons;
    }

    private static int GetDemonsHealth(string name)
    {
        MatchCollection matchHealth = Regex.Matches(name, @"[^\d+\-\/*\.]");
        string healthText = String.Join("", matchHealth);
        return healthText.Sum(x => (int)x);
    }

    private static double GetDemonsDamage(string name)
    {
        MatchCollection matchDamageSum = Regex.Matches(name, @"[-]?\d*[.]?[\d]+");
        MatchCollection matchDamageMultiplier = Regex.Matches(name, @"[*]");
        MatchCollection matchDamageDivision = Regex.Matches(name, @"[\/]");

        double damage = matchDamageSum.Select(x => double.Parse(x.Value)).Sum();

        damage *= Math.Pow(2, matchDamageMultiplier.Count);
        damage /= Math.Pow(2, matchDamageDivision.Count);

        return damage;
    }
}