using System;

class CakeIngredients
{
    static void Main()
    {
        var ingredient = Console.ReadLine();
        var count = 0;
        while (!ingredient.Equals("Bake!"))
        {
            Console.WriteLine($"Adding ingredient {ingredient}.");
            count++;
            ingredient = Console.ReadLine();
        }
        Console.WriteLine($"Preparing cake with {count} ingredients.");
    }
}