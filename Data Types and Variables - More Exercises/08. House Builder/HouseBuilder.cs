using System;

public class HouseBuilder
{
    public static void Main()
    {
        var firstPrice = int.Parse(Console.ReadLine());
        var secondPrice = int.Parse(Console.ReadLine());
        var totalPrice = 0L;
        if (firstPrice <= sbyte.MaxValue && firstPrice >= sbyte.MinValue)
        {
            totalPrice = firstPrice * 4 + secondPrice * 10L;
        }
        else
        {
            totalPrice = firstPrice * 10L + secondPrice * 4;
        }
        Console.WriteLine(totalPrice);
    }
}