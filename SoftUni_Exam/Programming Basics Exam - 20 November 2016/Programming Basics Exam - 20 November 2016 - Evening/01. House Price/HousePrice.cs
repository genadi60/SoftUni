using System;

class HousePrice
{
    static void Main()
    {
        double smallestRoom = double.Parse(Console.ReadLine());
        double kitchen = double.Parse(Console.ReadLine());
        double ppU = double.Parse(Console.ReadLine());
        double bathroom = smallestRoom / 2.0;
        double secondRoom = smallestRoom * 1.1;
        double thirdRoom = secondRoom * 1.1;
        double totalArea = bathroom + smallestRoom + secondRoom + thirdRoom + kitchen;
        totalArea += totalArea * 0.05;
        double price = totalArea * ppU;
        Console.WriteLine("{0:F2}", price);
    }
}