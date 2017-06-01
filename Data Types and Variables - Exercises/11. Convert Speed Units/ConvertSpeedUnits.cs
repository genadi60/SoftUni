using System;

public class ConvertSpeedUnits
{
    public static void Main()
    {
        var distanceInMeters = float.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var seconds = int.Parse(Console.ReadLine());
        var timeInSeconds = hours * 3600.0f + minutes * 60.0f + seconds;
        var timeInHours = seconds / 3600.0f + minutes / 60.0f + hours;
        var distanceInKilometers = distanceInMeters / 1000.0f;
        var distanceInMiles = distanceInMeters / 1609.0f;
        var speedInMeterPS = distanceInMeters / timeInSeconds;
        var speedInKilometerPH = distanceInKilometers / timeInHours;
        var speedInMilesPH = distanceInMiles / timeInHours;

        Console.WriteLine(speedInMeterPS);
        Console.WriteLine(speedInKilometerPH);
        Console.WriteLine(speedInMilesPH);
    }
}