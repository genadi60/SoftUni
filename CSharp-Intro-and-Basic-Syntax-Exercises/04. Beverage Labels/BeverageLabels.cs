using System;

class BeverageLabels
{
    static void Main()
    {
        var name = Console.ReadLine();
        var volume = int.Parse(Console.ReadLine());
        var energy = int.Parse(Console.ReadLine());
        var sugar = int.Parse(Console.ReadLine());
        double energyContent = volume / 100.0 * energy;
        double sugarContent = volume / 100.0 * sugar;

        Console.WriteLine("{0}ml {1}:", volume, name);
        Console.WriteLine("{0}kcal, {1}g sugars", energyContent, sugarContent);
    }
}