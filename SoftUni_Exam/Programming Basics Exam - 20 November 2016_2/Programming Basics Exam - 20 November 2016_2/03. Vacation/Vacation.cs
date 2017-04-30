using System;

class Vacation
{
    static void Main()
    {
        int adults = int.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        int night = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine().ToLower();
        string[] trans = new string[] { "train", "bus", "boat", "airplane" };
        decimal[] adultPrice = new decimal[] { 24.99m, 32.50m, 42.99m, 70.00m };
        decimal[] studentPrice = new decimal[] { 14.99m, 28.50m, 39.99m, 50.00m };
        decimal spendNight = 82.99m;
        decimal transportPrice = 0.00m;
        int index = Array.IndexOf(trans, transport);
        transportPrice = (adults * adultPrice[index] + students * studentPrice[index]) * 2;
        if (adults + students >= 50 && transport == "train")
        {
            transportPrice /= 2.00m;
        }
        decimal hotelPrice = night * spendNight;
        decimal commission = (hotelPrice + transportPrice) / 10.00m;
        decimal totalPrice = hotelPrice + transportPrice + commission;
        Console.WriteLine("{0:F2}", totalPrice);
    }
}