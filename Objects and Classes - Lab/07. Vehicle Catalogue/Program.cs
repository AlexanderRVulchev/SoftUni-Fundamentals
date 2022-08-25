//Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
//Define a class Truck with the following properties: Brand, Model, and Weight.
//Define a class Car with the following properties: Brand, Model, and Horse Power.
//Define a class Catalog with the following properties: Collections of Trucks and Cars.
//You must read the input, until you receive the "end" command. It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
//In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
//"Cars:
//{ Brand}: { Model}
//- { Horse Power}
//hp
//Trucks:
//{ Brand}: { Model}
//- { Weight}
//kg "

using System;
using System.Collections.Generic;
using System.Linq;

public class Truck
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public int Weight { get; set; }    
}

public class Car
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public int HorsePower { get; set; }
}

public class Catalog
{
    public List<Truck> Trucks { get; set; }

    public List<Car> Cars { get; set; }

    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }
}

internal class Program
{
    static Catalog SetCarInfo(Catalog catalog, string[] carChunks)
    {
        Car newCar = new Car();
        newCar.Brand = carChunks[1];
        newCar.Model = carChunks[2];
        newCar.HorsePower = int.Parse(carChunks[3]);
        catalog.Cars.Add(newCar);
        return catalog;
    }

    static Catalog SetTruckInfo(Catalog catalog, string[] truckChunks)
    {
        Truck newTruck = new Truck();
        newTruck.Brand = truckChunks[1];
        newTruck.Model = truckChunks[2];
        newTruck.Weight = int.Parse(truckChunks[3]);
        catalog.Trucks.Add(newTruck);
        return catalog;
    }

    static void Main(string[] args)
    {
        Catalog catalog = new Catalog();
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] chunks = input.Split('/').ToArray();
            if (chunks[0] == "Car") catalog = SetCarInfo(catalog, chunks);
            else catalog = SetTruckInfo(catalog, chunks);
        }
        catalog.Trucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();
        catalog.Cars = catalog.Cars.OrderBy(x => x.Brand).ToList();

        if (catalog.Cars.Count != 0)
        {
            Console.WriteLine("Cars:");
            foreach (Car car in catalog.Cars)
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        }
        if (catalog.Trucks.Count != 0)
        {

            Console.WriteLine("Trucks:");
            foreach (Truck truck in catalog.Trucks)
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }
    }
}

