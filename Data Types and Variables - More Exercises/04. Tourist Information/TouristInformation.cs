using System;

public class TouristInformation
{
    public static void Main()
    {
        var imperialUnit = Console.ReadLine();
        var value = decimal.Parse(Console.ReadLine());
        switch (imperialUnit)
        {
            case "miles":
                Console.WriteLine($"{value} {imperialUnit} = {value * 1.6m:F2} kilometers");
                break;
            case "inches":
                Console.WriteLine($"{value} {imperialUnit} = {value * 2.54m:F2} centimeters");
                break;
            case "feet":
                Console.WriteLine($"{value} {imperialUnit} = {value * 30m:F2} centimeters");
                break;
            case "yards":
                Console.WriteLine($"{value} {imperialUnit} = {value * 0.91m:F2} meters");
                break;
            case "gallons":
                Console.WriteLine($"{value} {imperialUnit} = {value * 3.8m:F2} liters");
                break;
            default:
                break;
        }
    }
}
