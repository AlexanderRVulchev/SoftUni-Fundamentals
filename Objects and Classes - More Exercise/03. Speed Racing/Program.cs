//Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars.
//Define a class Car that keeps a track of a car’s model, fuel amount, fuel consumption per kilometer, and traveled distance.
//A Car’s model is unique - there will never be 2 cars with the same model.
// On the first line of the input, you will receive a number N – the number of cars you need to track.
// On each of the next N lines you will receive information about cars in the following format "<Model> <FuelAmount> <FuelConsumptionFor1km>".
// All cars start at 0 kilometers traveled.
//After the N lines, until the command "End" is received, you will receive commands in the following format "Drive <CarModel> <amountOfKm>".
//Implement a method in the Car class to calculate whether or not a car can move that distance.
//If it can, the car’s fuel amount should be reduced by the amount of used fuel and its traveled distance should be increased by the number of the traveled kilometers.
//Otherwise, the car should not move (its fuel amount and the traveled distance should stay the same) and you should print on the console "Insufficient fuel for the drive".
//After the "End" command is received, print each car, its current fuel amount and the traveled distance in the format "<Model> <fuelAmount> <distanceTraveled>".
//Print the fuel amount rounded to two digits after the decimal separator.


using System;
using System.Collections.Generic;
using System.Linq;


public class Car
{
    public string Model { get; set; }

    public double Fuel { get; set; }

    public double Consumption { get; set; }

    public int TraveledDistance { get; set; }

    public Car(string model, double fuel, double consumption)
    {
        Model = model;
        Fuel = fuel;
        Consumption = consumption;
        TraveledDistance = 0;
    }

    public void Drive(int distance)
    {
        double fuelToSpend = Consumption * distance;
        if (fuelToSpend > Fuel)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            Fuel -= fuelToSpend;
            TraveledDistance += distance;
        }
    }

    public void PrintStatus()
    {
        Console.WriteLine($"{Model} {Fuel:f2} {TraveledDistance}");
    }

}

internal class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        int numberOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCars; i++)
        {
            string[] userCommands = Console.ReadLine().Split();
            string model = userCommands[0];
            double fuel = double.Parse(userCommands[1]);
            double consumption = double.Parse(userCommands[2]);
            Car newCar = new Car(model, fuel, consumption);
            cars.Add(newCar);
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] userCommands = input.Split();
            if (userCommands[0] == "Drive")
            {
                string model = userCommands[1];
                int distance = int.Parse(userCommands[2]);
                int index = cars.FindIndex(x => x.Model == model);
                cars[index].Drive(distance);
            }
        }

        foreach (Car car in cars) car.PrintStatus();
    }
}