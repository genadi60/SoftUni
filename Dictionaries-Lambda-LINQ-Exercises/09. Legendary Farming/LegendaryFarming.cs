using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    public static void Main()
    {
        var materialsQuantity = new SortedDictionary<string, int>();
        var specialMaterialsQuantity = new Dictionary<string, int>();
        
        var quantity = new List<int>();
        var materials = new List<string>();
        var winner = string.Empty;
        bool obtained = false;
        var line = Console.ReadLine();
        while (!line.Equals(string.Empty))
        {
            var quantityMaterials = line
                .ToLower()
                .Split()
                .ToList();
            for (int i = 0; i < quantityMaterials.Count; i++)
            {
                if (i % 2 == 0)
                {
                    quantity.Add(int.Parse(quantityMaterials[i]));
                }
                else
                {
                    materials.Add(quantityMaterials[i]);
                }
            }
            for (int i = 0; i < materials.Count; i++)
            {
                if (obtained)
                {
                    break;
                }
                var material = materials[i];
                var units = quantity[i];
                if (material == "shards" || material == "fragments" || material == "motes")
                {
                    if (!specialMaterialsQuantity.ContainsKey(material))
                    {
                        specialMaterialsQuantity["shards"] = 0;
                        specialMaterialsQuantity["fragments"] = 0;
                        specialMaterialsQuantity["motes"] = 0;
                    }
                    specialMaterialsQuantity[material] += units;
                    if (specialMaterialsQuantity[material] >= 250)
                    {
                        if (material == "shards")
                        {
                            winner = "Shadowmourne";
                        }
                        else if (material == "fragments")
                        {
                            winner = "Valanyr";
                        }
                        else
                        {
                            winner = "Dragonwrath";
                        }
                        specialMaterialsQuantity[material] -= 250;
                        obtained = true;
                        break;
                    }
                }
                else
                {
                    if (!materialsQuantity.ContainsKey(material))
                    {
                        materialsQuantity[material] = 0;
                    }
                    materialsQuantity[material] += units;
                }
            }
            quantityMaterials.Clear();
            quantity.Clear();
            materials.Clear();
            if (obtained)
            {
                break;
            }
            line = Console.ReadLine();
        }
        Console.WriteLine($"{winner} obtained!");
        
        foreach (var kvp in specialMaterialsQuantity.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            var mat = kvp.Key;
            var num = kvp.Value;
            Console.WriteLine($"{mat}: {num}");
        }

        foreach (var kvp in materialsQuantity)
        {
            var mat = kvp.Key;
            var num = kvp.Value;
            Console.WriteLine($"{mat}: {num}");
        }
    }
}