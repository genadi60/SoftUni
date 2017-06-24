using System;
using System.Collections.Generic;
using System.Linq;

public class ParkingValidation
{
    public static void Main()
    {
        var registeredPlate = new Dictionary<string, string>();
        
        var action = int.Parse(Console.ReadLine());
        for (int i = 0; i < action; i++)
        {
            var registration = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var command = registration[0];
            var name = registration[1];
            if (command.Equals("register"))
            {
                var plate = registration[2];
                if (registeredPlate.ContainsKey(name))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {registeredPlate[name]}");
                }
                else
                {
                    if (LicensePlateValidation(plate))
                    {
                        if (registeredPlate.ContainsValue(plate))
                        {
                            Console.WriteLine($"ERROR: license plate {plate} is busy");
                        }
                        else
                        {
                            registeredPlate[name] = plate;
                            Console.WriteLine($"{name} registered {plate} successfully");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                    }
                }
            }
            else if(command.Equals("unregister"))
            {
                if (registeredPlate.ContainsKey(name))
                {
                    registeredPlate.Remove(name);
                    Console.WriteLine($"user {name} unregistered successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: user {name} not found");
                }
            }
        }
        foreach (var kvp in registeredPlate)
        {
            var name = kvp.Key;
            var plate = kvp.Value;
            Console.WriteLine($"{name} => {plate}");
        }
        
    }

    
    static bool LicensePlateValidation(string plate)
    {
        bool isValid = true;
        if (plate.Length == 8)
        {
            var startEnd = plate.Substring(0, 2) + plate.Substring(6);
            var middle = plate.Substring(2, 4);
            foreach (var item in startEnd)
            {
                if (item < 'A' || item > 'Z')
                {
                    isValid = false;
                    return isValid;
                }
            }
            foreach (var item in middle)
            {
                if (item < '0' || item > '9')
                {
                    isValid = false;
                    return isValid;
                }
            }
        }
        else
        {
            isValid = false;
            return isValid;
        }
        return isValid;
    }
}