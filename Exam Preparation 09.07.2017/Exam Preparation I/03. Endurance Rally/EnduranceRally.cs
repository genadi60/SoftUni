using System;
using System.Linq;

public class EnduranceRally
{
    public static void Main()
    {
        var names = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        var fuelVolume = new Decimal[names.Length];
        for (int i = 0; i < names.Length; i++)
        {
            char first = names[i].First();
            fuelVolume[i] = first; 
        }
        decimal[] fuelZones = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();
        int[] checkPoints = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        for (int i = 0; i < fuelVolume.Length; i++)
        {
            for (int j = 0; j < fuelZones.Length; j++)
            {
                if (checkPoints.Contains(j))
                {
                    fuelVolume[i] += fuelZones[j];
                }
                else
                {
                    fuelVolume[i] -= fuelZones[j];
                    if (fuelVolume[i] <= 0)
                    {
                        
                        Console.WriteLine($"{names[i]} - reached {j}");
                        break;
                    }
                }
            }
            if (fuelVolume[i] > 0)
            {
                var fuel = decimal.Parse(String.Join("", fuelVolume[i]));
                Console.WriteLine($"{names[i]} - fuel left {fuel:F2}");
            }
        }
    }
}