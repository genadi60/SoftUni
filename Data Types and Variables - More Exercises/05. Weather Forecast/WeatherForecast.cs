using System;

public class WeatherForecast
{
    public static void Main()
    {
        var numberOfNumerology = Console.ReadLine();
        var result = string.Empty;
        try
        {
            var number = long.Parse(numberOfNumerology);
            if (number <= sbyte.MaxValue && number >= sbyte.MinValue)
            {
                result = "Sunny";
            }
            else if (number <= int.MaxValue && number >= int.MinValue)
            {
                result = "Cloudy";
            }
            else
            {
                result = "Windy";
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Rainy");
        }
        Console.WriteLine(result);
    }
}