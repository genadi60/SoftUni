using System;
using System.Collections.Generic;
using System.Linq;

public class DragonArmy
{
    public static void Main()
    {
        var armyOfDragons = new Dictionary<string, SortedDictionary<string, List<int>>>();
        var dragons = new List<string[]>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var dragon = Console.ReadLine()
                .Split()
                .ToArray();
            dragons.Add(dragon);
        }
       
        foreach (var dragon in dragons)
        {
            var dragonType = dragon[0];
            var dragonName = dragon[1];
            var dragonDamage = 45;
            var dragonHealt = 250;
            var dragonArmor = 10;
            var dragonCondition = new List<int>();
            if (!dragon[2].Equals("null"))
            {
                dragonDamage = int.Parse(dragon[2]);
            }
            dragonCondition.Add(dragonDamage);
            if (!dragon[3].Equals("null"))
            {
                dragonHealt = int.Parse(dragon[3]);
            }
            dragonCondition.Add(dragonHealt);
            if (!dragon[4].Equals("null"))
            {
                dragonArmor = int.Parse(dragon[4]);
            }
            dragonCondition.Add(dragonArmor);
            if (!armyOfDragons.ContainsKey(dragonType))
            {
                armyOfDragons[dragonType] = new SortedDictionary<string, List<int>>();
            }
            if (!armyOfDragons[dragonType].ContainsKey(dragonName))
            {
                armyOfDragons[dragonType][dragonName] = new List<int>();
            }
            armyOfDragons[dragonType][dragonName] = dragonCondition;
        }
        foreach (var kvp in armyOfDragons)
        {
            var type = kvp.Key;
            var dragonsOfType = kvp.Value;
            var totalDamage = new List<int>();
            var totalHealt = new List<int>();
            var totalArmor = new List<int>();
            var name = string.Empty;
            var damage = 0;
            var healt = 0;
            var armor = 0;
            foreach (var kvp2 in dragonsOfType)
            {
                name = kvp2.Key;
                var status = kvp2.Value;
                damage = status[0];
                totalDamage.Add(damage);
                healt = status[1];
                totalHealt.Add(healt);
                armor = status[2];
                totalArmor.Add(armor);
            }
            var damageAverage = totalDamage.Average();
            var healtAverage = totalHealt.Average();
            var armorAverage = totalArmor.Average();
            Console.WriteLine($"{type}::({damageAverage:F2}/{healtAverage:F2}/{armorAverage:F2})");
            foreach (var kvp2 in dragonsOfType)
            {
                name = kvp2.Key;
                var status = kvp2.Value;
                damage = status[0];
                healt = status[1];
                armor = status[2];
                Console.WriteLine($"-{name} -> damage: {damage}, health: {healt}, armor: {armor}");
            }
        }
    }
}