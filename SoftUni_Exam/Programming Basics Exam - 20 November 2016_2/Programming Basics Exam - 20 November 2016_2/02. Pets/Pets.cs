using System;

class Pets
{
    static void Main()
    {
        //o	“{килограма остатък} kilos of food left.”
        //o	“{килограма недостигат} more kilos of food are needed.”
        int days = int.Parse(Console.ReadLine());
        int foodLeft = int.Parse(Console.ReadLine());
        decimal dogFood = decimal.Parse(Console.ReadLine());
        decimal catFood = decimal.Parse(Console.ReadLine());
        decimal turtFood = decimal.Parse(Console.ReadLine());
        turtFood /= 1000.00m;
        decimal needFood = days * (dogFood + catFood + turtFood);
        if (foodLeft >= needFood)
        {
            Console.WriteLine("{0} kilos of food left.", (int)(foodLeft - needFood));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(needFood - foodLeft));
        }
    }
}