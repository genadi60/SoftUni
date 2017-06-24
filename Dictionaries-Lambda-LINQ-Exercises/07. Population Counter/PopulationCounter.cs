using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main()
    {
        var countryCityPopulation = new Dictionary<string, Dictionary<string, int>>();
        var countryPopulation = new Dictionary<string, long>();
        var cityPopulation = new Dictionary<string, int>();

        var userInput = Console.ReadLine();
        while (!userInput.Equals("report"))
        {
            var countryPopulationData = userInput
                .Split('|')
                .ToArray();
            var cityName = countryPopulationData[0];
            var countryName = countryPopulationData[1];
            var population = int.Parse(countryPopulationData[2]);
            if (!countryCityPopulation.ContainsKey(countryName))
            {
                cityPopulation = new Dictionary<string, int>();
                cityPopulation[cityName] = 0;
                countryCityPopulation[countryName] = new Dictionary<string, int>();
                countryPopulation[countryName] = 0;
            }
            cityPopulation = countryCityPopulation[countryName];
            cityPopulation[cityName] = population;
            countryCityPopulation[countryName] = cityPopulation;
            countryPopulation[countryName] += population;
            userInput = Console.ReadLine();
        }
        foreach (var kvp in countryPopulation.OrderByDescending(x => x.Value))
        {
            var country = kvp.Key;
            var totalPopulation = kvp.Value;

            Console.WriteLine($"{country} (total population: {totalPopulation})");
            foreach (var kvp2 in countryCityPopulation[country].OrderByDescending(x => x.Value))
            {
                var city = kvp2.Key;
                var citizens = kvp2.Value;
                Console.WriteLine($"=>{city}: {citizens}");
            }
        }
    }
}