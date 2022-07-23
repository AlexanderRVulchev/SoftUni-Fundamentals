//On the first line of the standard input, you will receive an integer n – the number of heroes that you can choose for your party.
//On the next n lines, the heroes themselves will follow with their hit points and mana points separated by a single space in the following format: 
//"{hero name} {HP} {MP}"
//- HP stands for hit points and MP for mana points
//-a hero can have a maximum of 100 HP and 200 MP
//After you have successfully picked your heroes, you can start playing the game.
//You will be receiving different commands, each on a new line, separated by " – ", until the "End" command is given.
//There are several actions that the heroes can perform:
//"CastSpell – {hero name} – {MP needed} – {spell name}"
//•	If the hero has the required MP, he casts the spell, thus reducing his MP.Print this message: 
//o   "{hero name} has successfully cast {spell name} and now has {mana points left} MP!"
//•	If the hero is unable to cast the spell print:
//o   "{hero name} does not have enough MP to cast {spell name}!"
//"TakeDamage – {hero name} – {damage} – {attacker}"
//•	Reduce the hero HP by the given damage amount.
//If the hero is still alive (his HP is greater than 0) print:
//        o   "{hero name} was hit for {damage} HP by {attacker} and now has {current HP} HP left!"
//•	If the hero has died, remove him from your party and print:
//o "{hero name} has been killed by {attacker}!"
//"Recharge – {hero name} – {amount}"
//•	The hero increases his MP. If it brings the MP of the hero above the maximum value (200),
//MP is increased to 200. (the MP can't go over the maximum value).
//•	 Print the following message:
//o   "{hero name} recharged for {amount recovered} MP!"
//"Heal – {hero name} – {amount}"
//•	The hero increases his HP.If a command is given that would bring the HP of the hero
//above the maximum value(100), HP is increased to 100(the HP can't go over the maximum value).
//•	 Print the following message:
//o   "{hero name} healed for {amount recovered} HP!"
//Input
//•	On the first line of the standard input, you will receive an integer n
//•	On the following n lines, the heroes themselves will follow with their
//hit points and mana points separated by a space in the following format
//•	You will be receiving different commands, each on a new line, separated by " – ", until the "End" command is given
//Output
//•	Print all members of your party who are still alive, in the following
//format(their HP / MP need to be indented 2 spaces):
//"{hero name}
//  HP: { current HP}
//MP: { current MP}
//"
//Constraints
//•	The starting HP/MP of the heroes will be valid, 32-bit integers will never be negative or exceed the respective limits.
//•	The HP/MP amounts in the commands will never be negative.
//•	The hero names in the commands will always be valid members of your party. No need to check that explicitly.

using System;
using System.Collections.Generic;

class Hero
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int MP { get; set; }

    public Hero(string name, int hp, int mp)
    {
        this.Name = name;
        this.HP = hp;
        this.MP = mp;
    }
}

class Program
{
    static List<Hero> heroes = new List<Hero>();

    static void Main()
    {
        GetHeroesInfo();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] cmd = input.Split(" - ");
            Hero hero = heroes.Find(x => x.Name == cmd[1]);
            switch (cmd[0])
            {
                case "CastSpell": CastSpell(cmd, hero); break;
                case "TakeDamage": TakeDamage(cmd, hero); break;
                case "Recharge": Recharge(cmd, hero); break;
                case "Heal": Heal(cmd, hero); break;
            }
        }
        foreach (Hero hero in heroes)
        {
            Console.WriteLine(hero.Name);
            Console.WriteLine($"  HP: {hero.HP}");
            Console.WriteLine($"  MP: {hero.MP}");
        }
    }


    private static void GetHeroesInfo()
    {
        int numberOfHeroes = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfHeroes; i++)
        {
            string[] entryInfo = Console.ReadLine().Split();
            string name = entryInfo[0];
            int hp = int.Parse(entryInfo[1]);
            int mp = int.Parse(entryInfo[2]);
            heroes.Add(new Hero(name, hp, mp));
        }
    }

    private static void TakeDamage(string[] cmd, Hero hero)
    {
        int damage = int.Parse(cmd[2]);
        string attacker = cmd[3];
        hero.HP -= damage;
        if (hero.HP > 0)
            Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.HP} HP left!");
        else
        {
            Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
            heroes.Remove(hero);
        }
    }


    private static void CastSpell(string[] cmd, Hero hero)
    {
        int mpNeeded = int.Parse(cmd[2]);
        string spellName = cmd[3];
        if (hero.MP >= mpNeeded)
        {
            hero.MP -= mpNeeded;
            Console.WriteLine($"{hero.Name} has successfully cast {spellName} and now has {hero.MP} MP!");
        }
        else
            Console.WriteLine($"{hero.Name} does not have enough MP to cast {spellName}!");
    }

    private static void Recharge(string[] cmd, Hero hero)
    {
        int amount = int.Parse(cmd[2]);
        int rechargedFor = Math.Min(amount, 200 - hero.MP);
        hero.MP += rechargedFor;
        Console.WriteLine($"{hero.Name} recharged for {rechargedFor} MP!");
    }

    private static void Heal(string[] cmd, Hero hero)
    {
        int amount = int.Parse(cmd[2]);
        int healedFor = Math.Min(amount, 100 - hero.HP);
        hero.HP += healedFor;
        Console.WriteLine($"{hero.Name} healed for {healedFor} HP!");
    }
}