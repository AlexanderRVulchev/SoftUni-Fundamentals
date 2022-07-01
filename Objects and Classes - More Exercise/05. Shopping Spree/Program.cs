//Create two classes: class Person and class Product.
//Each person should have a name, money, and a bag of products.
//Each product should have a name and a cost. 
//Create a program, in which each command corresponds to a person buying a product.
//If the person can afford a product, add it to his bag.
//If a person doesn’t have enough money, print an appropriate message: "{Person} can't afford {Product}".
//On the first two lines, you are given all people and all products.
//After all, purchases, print every person in the order of appearance and all products that he has bought, also in order of appearance.
//If nothing was bought, print the name of the person followed by "Nothing bought". 


using System;
using System.Collections.Generic;
using System.Linq;


public class Product
{
    public string Name { get; set; }

    public double Cost { get; set; }

    public Product(string name, double cost)
    {
        Name = name;
        Cost = cost;
    }
}

public class Person
{
    public string Name { get; set; }

    public double Money { get; set; }

    public List<Product> Products { get; set; }

    public Person(string name, double money)
    {
        Products = new List<Product>();
        Name = name;
        Money = money;
    }
}

internal class Program
{
    static void Main()
    {
        // Reading people info and adding to list;
        List<Person> people = new List<Person>();
        string[] input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < input.Length; i++)
        {
            string[] nameAndMoney = input[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Person newPerson = new Person(nameAndMoney[0], double.Parse(nameAndMoney[1]));
            people.Add(newPerson);
        }

        //Reading products info and adding to list
        List<Product> products = new List<Product>();
        input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < input.Length; i++)
        {
            string[] nameAndCost = input[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            Product newProduct = new Product(nameAndCost[0], double.Parse(nameAndCost[1]));
            products.Add(newProduct);
        }


        // Taking user commands
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "END")
        {
            input = command.Split();
            string buyerName = input[0];
            string productToBuy = input[1];
            int indexPerson = people.FindIndex(x => x.Name == buyerName);
            int indexProduct = products.FindIndex(x => x.Name == productToBuy);
            if (products[indexProduct].Cost > people[indexPerson].Money)
            {
                Console.WriteLine($"{buyerName} can't afford {productToBuy}");
            }
            else
            {
                Console.WriteLine($"{buyerName} bought {productToBuy}");
                people[indexPerson].Money -= products[indexProduct].Cost;
                people[indexPerson].Products.Add(products[indexProduct]);
            }
        }

        // Printing result
        foreach (Person person in people)
        {
            if (person.Products.Count > 0)
                Console.WriteLine($"{person.Name} - {String.Join(", ", person.Products.Select(x => x.Name))}");
            else
                Console.WriteLine($"{person.Name} - Nothing bought");
        }
    }
}