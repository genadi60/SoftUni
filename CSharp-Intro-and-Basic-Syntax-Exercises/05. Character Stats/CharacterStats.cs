using System;

class CharacterStats
{
    static void Main()
    {
        var name = Console.ReadLine();
        var currentHealth = int.Parse(Console.ReadLine());
        var maxHealth = int.Parse(Console.ReadLine());
        var currentEnergy = int.Parse(Console.ReadLine());
        var maxEnergy = int.Parse(Console.ReadLine());
        char current = '|';
        char empty = '.';
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: |{0}{1}|", new string(current, currentHealth), new string(empty, maxHealth - currentHealth));
        Console.WriteLine("Energy: |{0}{1}|", new string(current, currentEnergy), new string(empty, maxEnergy - currentEnergy));
    }
}