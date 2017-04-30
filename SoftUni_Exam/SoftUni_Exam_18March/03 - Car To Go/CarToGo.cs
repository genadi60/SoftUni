using System;

class CarToGo
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string carType = string.Empty;
        string carClass = string.Empty;
        decimal price = 0.00m;
        if (budget <= 100.00m)
        {
            carClass = "Economy class";
            if (season == "Summer")
            {
                carType = "Cabrio";
                price = budget * 0.35m;
            }
            else
            {
                carType = "Jeep";
                price = budget * 0.65m;
            }
        }
        else if (budget <= 500.00m)
        {
            carClass = "Compact class";
            if (season == "Summer")
            {
                carType = "Cabrio";
                price = budget * 0.45m;
            }
            else
            {
                carType = "Jeep";
                price = budget * 0.80m;
            }
        }
        else
        {
            carClass = "Luxury class";
            carType = "Jeep";
            price = budget * 0.90m;
        }
        Console.WriteLine(carClass);
        Console.WriteLine("{0} - {1:F2}", carType, price);
    }
}