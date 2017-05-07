using System;

class SweetDessert
{
    static void Main()
    {
        decimal cashIvancho = decimal.Parse(Console.ReadLine());
        int guests = int.Parse(Console.ReadLine());
        decimal priceOfBananas = decimal.Parse(Console.ReadLine());
        decimal priceOfEggs = decimal.Parse(Console.ReadLine());
        decimal priceOfBerries = decimal.Parse(Console.ReadLine());
        int portions = 6;
        decimal priceOfPortions = 2 * priceOfBananas + 4 * priceOfEggs + 0.2M * priceOfBerries;
        int add = 0;
        if(guests % portions != 0)
        {
            add = 1;
        }
        int neededPortions = guests / portions + add;
        if (neededPortions * priceOfPortions <= cashIvancho)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", neededPortions * priceOfPortions);
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", (neededPortions * priceOfPortions - cashIvancho));
        }
    }
}