using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Weather
{
    public class WeatherInformation
    {
        public double AverageTemperature { get; set; }
        public string Weather { get; set; }
    }
    public static void Main()
    {
        var wheatherByCityes = new Dictionary<string, WeatherInformation>();
        var pattern = @"(?<cityName>[A-Z]{2})(?<temperatureValue>[0-9]+\.[0-9]+)(?<weatherWide>[a-zA-Z]+)\|";
        var regex = new Regex(pattern);
        var temperature = 0.0;
        var weather = string.Empty;
        
        while (true)
        {
            var line = Console.ReadLine();
            if (line == "end")
            {
                break;
            }
            
            var cittyesInformation = regex.Match(line);
            if (cittyesInformation.Success)
            {
                
                temperature = double.Parse(cittyesInformation.Groups["temperatureValue"].Value);
                weather = cittyesInformation.Groups["weatherWide"].Value.ToString();
                var temperatureInformation = new WeatherInformation()
                {
                    AverageTemperature = temperature,
                    Weather = weather
                };
                var city = cittyesInformation.Groups["cityName"].Value;
                wheatherByCityes[city] = temperatureInformation;
            }
        }
        foreach (var kvp in wheatherByCityes.OrderBy(x => x.Value.AverageTemperature))
        {
            var city = kvp.Key;
            var weatherValue = kvp.Value.Weather;
            var averageTemperature = kvp.Value.AverageTemperature;
            Console.WriteLine($"{city} => {averageTemperature:F2} => {weatherValue}");
        }
    }
}
