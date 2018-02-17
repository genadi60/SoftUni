using System;
using System.Collections.Generic;
using System.Linq;

public class VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
    public static void Main()
    {
        var vehicles = new List<Vehicle>();
        while (true)
        {
            var line = Console.ReadLine();
            if (line.Equals("End"))
            {
                break;
            }
            var vehicleData = line
                .Split()
                .ToArray();
            var vehicleType = vehicleData[0];
            var vehicleModel = vehicleData[1];
            var vehicleColor = vehicleData[2];
            var vehicleHorsepower = int.Parse(vehicleData[3]);
            if (vehicleType.Length == 3 && !vehicleType.Equals("Car"))
            {
                vehicleType = "Car";
            }
            if (vehicleType.Length == 5 && !vehicleType.Equals("Truck"))
            {
                vehicleType = "Truck";
            }
            var vehicle = new Vehicle();
            vehicle.Type = vehicleType;
            vehicle.Model = vehicleModel;
            vehicle.Color = vehicleColor;
            vehicle.Horsepower = vehicleHorsepower;
            vehicles.Add(vehicle);
        }
        var models = new List<string>();
        while (true)
        {
            var line = Console.ReadLine();
            if (line.Equals("Close the Catalogue"))
            {
                break;
            }
            models.Add(line);
        }
        var trucksPower = new List<int>();
        var carsPower = new List<int>();
        foreach (var model in models)
        {
            foreach (var vehicle in vehicles.Where(x => x.Model.Equals(model)))
            {
                Console.WriteLine($"Type: {vehicle.Type}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
            }
        }
        foreach (var vehicle in vehicles)
        {
            if (vehicle.Type.ToLower().Equals("truck"))
            {
                trucksPower.Add(vehicle.Horsepower);
            }
            else
            {
                carsPower.Add(vehicle.Horsepower);
            }
        }
        if (trucksPower.Count == 0)
        {
            trucksPower.Add(0);
        }
        if (carsPower.Count == 0)
        {
            carsPower.Add(0);
        }
        var trucksAverage = trucksPower.Average();
        var carsAverage = carsPower.Average();
        Console.WriteLine($"Cars have average horsepower of: {carsAverage:F2}.");
        Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:F2}.");
    }
}