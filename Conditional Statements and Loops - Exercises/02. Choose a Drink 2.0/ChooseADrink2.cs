using System;

class ChooseADrink2
{
    static void Main()
    {
        var profession = Console.ReadLine();
        var quantity = int.Parse(Console.ReadLine());
        double price = 0.0;
        var professionToLower = profession.ToLower();
        var drink = string.Empty;
        switch (professionToLower)
        {
            case "athlete":
                drink = "Water";
                price = 0.70;
                break;
            case "softuni student":
                drink = "Beer";
                price = 1.70;
                break;
            case "businessman":
            case "businesswoman":
                drink = "Coffee";
                price = 1.00;
                break;
            default:
                drink = "Tea";
                price = 1.20;
                break;
        }
        Console.WriteLine($"The {profession} has to pay {price * quantity :F2}.");
    }
}