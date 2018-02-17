using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonEvolution
{
    class Evol
    {
        public string Name { get; set; }
        public int Index { get; set; }
    }

    public static void Main()
    {
        var dict = new Dictionary<string, List<Evol>>();
        var evolList = new List<Evol>();
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "wubbalubbadubdub")
            {
                break;
            }
            var pokemon = new Evol();
            if (input.Contains("->"))
            {
                var data = input
                    .Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                if (data.Length < 3)
                {
                    continue;
                }
                var pokemonName = data[0];
                var evolutionType = data[1];
                var evolIndex = int.Parse(data[2]);
                if (!dict.ContainsKey(pokemonName))
                {
                    dict[pokemonName] = new List<Evol>();
                }
                pokemon = new Evol()
                {
                    Name = evolutionType,
                    Index = evolIndex
                };
                dict[pokemonName].Add(pokemon);
            }
            else
            {
                if (input != "")
                {
                    if (dict.ContainsKey(input))
                    {
                        Console.WriteLine($"# {input}");
                        foreach (var e in dict[input])
                        {
                            Console.WriteLine($"{e.Name} <-> {e.Index}");
                        }
                    }
                }
            }
        }
        foreach (var kvp in dict)
        {
            var pokNam = kvp.Key;
            var evolutions = kvp.Value;
            Console.WriteLine($"# {pokNam}");
            foreach (var evol in evolutions.OrderByDescending(x => x.Index))
            {
                Console.WriteLine($"{evol.Name} <-> {evol.Index}");
            }
        }
    }
}
