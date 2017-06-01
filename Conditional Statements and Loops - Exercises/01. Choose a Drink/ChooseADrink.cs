using System;

class ChooseADrink
{
    static void Main()
    {
        var profession = Console.ReadLine().ToLower();
        var drink = string.Empty;
        switch (profession)
        {
            case "athlete":
                drink = "Water";
                break;
            case "softuni student":
                drink = "Beer";
                break;
            case "businessman":
            case "businesswoman":
                drink = "Coffee";
                break;
            default:
                drink = "Tea";
                break;
        }
        Console.WriteLine(drink);
    }
}