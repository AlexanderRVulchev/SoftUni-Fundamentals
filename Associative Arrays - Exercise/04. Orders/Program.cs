//Create a program that keeps the information about products and their prices. Each product has a name, a price and a quantity.
//If the product doesn't exist yet, add it with its starting quantity.
//If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different, replace the price as well.
//You will receive products' names, prices and quantities on new lines. Until you receive the command "buy", keep adding items.
//When you do receive the command "buy", print the items with their names and the total price of all the products with that name.
//Input
//•	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
//•	The product data is always delimited by a single space.
//Output
//•	Print information about each product in the following format: 
//"{productName} -> {totalPrice}"
//•	Format the average grade to the 2nd digit after the decimal separator.

using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double GetTotalPrice() => Price * Quantity;        
    }

    static void Main()
    {
        List<Product> allProducts = new List<Product>();
        string input;
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] inputTokens = input.Split();

            string newName = inputTokens[0];
            double newPrice = double.Parse(inputTokens[1]);
            int newQuantity = int.Parse(inputTokens[2]);
            Product newEntry = new Product(newName, newPrice, newQuantity);

            if (!(allProducts.Select(x => x.Name).Contains(newEntry.Name)))
                allProducts.Add(newEntry);
            else
            {
                foreach (Product v in allProducts.Where(v => v.Name == newEntry.Name))
                {
                    v.Price = newPrice;
                    v.Quantity += newQuantity;
                }
            }
        }

        foreach (Product v in allProducts)
            Console.WriteLine($"{v.Name} -> {v.GetTotalPrice():f2}");
    }
}