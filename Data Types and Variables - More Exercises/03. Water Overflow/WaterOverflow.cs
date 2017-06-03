using System;

public class WaterOverflow
{
    public static void Main()
    {
        var tankCapacity = 255.0;
        var quantitiInTank = 0.0;
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var litersToPour = double.Parse(Console.ReadLine());
            if ((quantitiInTank + litersToPour) <= tankCapacity )
            {
                quantitiInTank += litersToPour;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }
        Console.WriteLine(quantitiInTank);
    }
} 