//On the first line of the standard input, you will receive an integer n – the number of cars that you can obtain.
//On the next n lines, the cars themselves will follow with their mileage and fuel available,
//separated by "|" in the following format:
//"{car}|{mileage}|{fuel}"
//Then, you will be receiving different commands, each on a new line, separated by " : ",
//until the "Stop" command is given:
//•	"Drive : {car} : {distance} : {fuel}":
//o You need to drive the given distance, and you will need the given fuel to do that.
//If the car doesn't have enough fuel, print: "Not enough fuel to make that ride"
//o	If the car has the required fuel available in the tank,
//increase its mileage with the given distance, decrease its fuel with the given fuel, and print: 
//"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed."
//o You like driving new cars only, so if a car's mileage reaches 100 000 km,
//remove it from the collection(s) and print: "Time to sell the {car}!"
//•	"Refuel : {car} : {fuel}":
//o Refill the tank of your car. 
//o	Each tank can hold a maximum of 75 liters of fuel, so if the given amount of fuel
//is more than you can fit in the tank, take only what is required to fill it up. 
//o	Print a message in the following format: "{car} refueled with {fuel} liters"
//•	"Revert : {car} : {kilometers}":
//o Decrease the mileage of the given car with the given kilometers and print the kilometers
//you have decreased it with in the following format:
//"{car} mileage decreased by {amount reverted} kilometers"
//o If the mileage becomes less than 10 000km after it is decreased, just set it to 10 000km and 
//DO NOT print anything.
//Upon receiving the "Stop" command, you need to print all cars in your possession in the following format:
//"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."
//Input / Constraints
//•	The mileage and fuel of the cars will be valid, 32-bit integers, and will never be negative.
//•	The fuel and distance amounts in the commands will never be negative.
//•	The car names in the commands will always be valid cars in your possession.
//Output
//•	All the output messages with the appropriate formats are described in the problem description.

using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public string Model { get; set; }
    public int Mileage { get; set; }
    public int Fuel { get; set; }

    public Car(string model, int mileage, int fuel)
    {
        this.Model = model;
        this.Mileage = mileage;
        this.Fuel = fuel;
    }

    public bool Drive(int distance, int fuelSpent)
    {
        if (this.Fuel < fuelSpent)
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }
        else
        {
            this.Mileage += distance;
            this.Fuel -= fuelSpent;
            Console.WriteLine($"{this.Model} driven for {distance} kilometers. {fuelSpent} liters of fuel consumed.");
        }
        if (this.Mileage >= 100000)
        {
            Console.WriteLine($"Time to sell the {this.Model}!");
            return true;
        }
        return false;
    }

    public void Refuel(int fuelToFill)
    {
        int actualFuel = Math.Min(fuelToFill, 75 - this.Fuel);
        Console.WriteLine($"{this.Model} refueled with {actualFuel} liters");
        this.Fuel = this.Fuel + actualFuel;
    }

    public void Revert(int revertKm)
    {
        if (this.Mileage - revertKm >= 10000)
        {
            Console.WriteLine($"{this.Model} mileage decreased by {revertKm} kilometers");
        }
        this.Mileage = Math.Max(this.Mileage - revertKm, 10000);
    }

    public override string ToString() =>
        $"{this.Model} -> Mileage: {this.Mileage} kms, Fuel in the tank: {this.Fuel} lt.";
}


internal class Program
{
    static void Main()
    {
        List<Car> cars = GetAllCarsInfo();
        string input;
        while ((input = Console.ReadLine()) != "Stop")
        {
            string[] tokens = input.Split(" : ");
            string command = tokens[0];
            Car thisCar = cars.Find(x => x.Model == tokens[1]);
            if (command == "Drive")
            {
                bool needToSellCar = thisCar.Drive(int.Parse(tokens[2]), int.Parse(tokens[3]));
                if (needToSellCar)
                    cars.Remove(thisCar);
            }
            else if (command == "Refuel")
            {
                thisCar.Refuel(int.Parse(tokens[2]));
            }
            else if (command == "Revert")
            {
                thisCar.Revert(int.Parse(tokens[2]));
            }
        }
        Console.WriteLine(String.Join("\n", cars));
    }

    private static List<Car> GetAllCarsInfo()
    {
        int numberOfCars = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < numberOfCars; i++)
        {
            string[] carInfo = Console.ReadLine().Split('|');
            string model = carInfo[0];
            int mileage = int.Parse(carInfo[1]);
            int fuel = int.Parse(carInfo[2]);
            cars.Add(new Car(model, mileage, fuel));
        }
        return cars;
    }
}