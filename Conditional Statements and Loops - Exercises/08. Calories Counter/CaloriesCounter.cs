using System;

class CaloriesCounter
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var ingredient = string.Empty;
        var totalCaloriesAmount = 0;
        for (int i = 0; i < number; i++)
        {
            ingredient = Console.ReadLine().ToLower();
            switch (ingredient)
            {
                case "cheese":
                    totalCaloriesAmount += 500;
                    break;
                case "tomato sauce":
                    totalCaloriesAmount += 150;
                    break;
                case "salami":
                    totalCaloriesAmount += 600;
                    break;
                case "pepper":
                    totalCaloriesAmount += 50;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine($"Total calories: {totalCaloriesAmount}");
    }
}