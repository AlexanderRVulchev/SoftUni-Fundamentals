//Define a class Item, which contains these properties: Name and Price.
//Define a class Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
//Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
//The Price of one box has to be calculated: itemQuantity* itemPrice.
//Print all the boxes ordered descending by price for a box, in the following format: 
//{ boxSerialNumber}
//-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
//-- ${ boxPrice}
//The price should be formatted to the 2nd digit after the decimal separator.


using System;
using System.Collections.Generic;
using System.Linq;

public class Item
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}

public class Box
{
    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public decimal PriceBox { get; set; }

    public Box()
    {
        Item = new Item();
    }

    public void CalculatePriceBox()
    {
        PriceBox = ItemQuantity * Item.Price;
    }
}

internal class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] boxInfo = input.Split().ToArray();
            Box newBox = new Box();
            newBox.SerialNumber = boxInfo[0];
            newBox.Item.Name = boxInfo[1];
            newBox.ItemQuantity = int.Parse(boxInfo[2]);
            newBox.Item.Price = decimal.Parse(boxInfo[3]);
            newBox.CalculatePriceBox();
            boxes.Add(newBox);
        }
        boxes = boxes.OrderByDescending(box => box.PriceBox).ToList();
                
        foreach (Box box in boxes)
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.PriceBox:f2}");
        }
    }
}