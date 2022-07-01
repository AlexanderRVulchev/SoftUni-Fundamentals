//You are the owner of a courier company and you want to make a system for tracking your cars and their cargo.
//Define a class Car that holds a piece of information about the model, engine, and cargo.
//The Engine and Cargo should be separate classes.
//Create a constructor that receives all of the information about the Car and creates and initializes its inner components (engine and cargo).
//On the first line of input, you will receive a number N – the number of cars you have.
//On each of the next N lines, you will receive the following information about a car: "<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>",
//where the speed, power and weight are all integers. 
//After the N lines, you will receive a single line with one of 2 commands: "fragile" or "flamable".
//If the command is "fragile" print all cars, whose Cargo Type is "fragile" with cargo, whose weight  < 1000.
//If the command is "flamable" print all of the cars whose Cargo Type is "flamable" and has Engine Power > 250.
//The cars should be printed in order of appearing in the input.


using System;
using System.Collections.Generic;
using System.Linq;


public class Engine
{
    public int Speed { get; set; }

    public int Power { get; set; }

    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }
}

public class Cargo
{
    public int Weight { get; set; }

    public string Type { get; set; }

    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }
}

public class Car
{
    public string Model { get; set; }

    public Engine Engine { get; set; }

    public Cargo Cargo { get; set; }

    public Car(string[] carData)
    {
        Model = carData[0];
        Engine = new Engine(int.Parse(carData[1]), int.Parse(carData[2]));
        Cargo = new Cargo(int.Parse(carData[3]), carData[4]);
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
            Car newCar = new Car(Console.ReadLine().Split());
            cars.Add(newCar);
        }

        string command = Console.ReadLine();
        if (command == "fragile")
        {
            Car[] selectedCars = cars.FindAll(x => x.Cargo.Weight < 1000).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, selectedCars.Select(x => x.Model)));
        }
        else if (command == "flamable")
        {
            Car[] selectedCars = cars.FindAll(x => x.Engine.Power > 250).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, selectedCars.Select(x => x.Model)));
        }
    }
}