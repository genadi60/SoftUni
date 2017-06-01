using System;

class RestaurantDiscount
{
    static void Main()
    {
        var people = int.Parse(Console.ReadLine());
        var package = Console.ReadLine();
        if (people > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }
        else
        {
            decimal discount = 1.00m;
            decimal price = 0.00m;
            switch (package)
            {
                case "Normal":
                    price = 500.00m;
                    discount = 0.95m;
                    break;
                case "Gold":
                    price = 750.00m;
                    discount = 0.90m;
                    break;
                case "Platinum":
                    price = 1000.00m;
                    discount = 0.85m;
                    break;
                default:
                    break;
            }
            decimal hallPrice = 0.00m;
            var hallName = string.Empty;
            if (people <= 50)
            {
                hallName = "Small Hall";
                hallPrice = 2500.00m;
            }
            else if (people > 50 && people <= 100)
            {
                hallName = "Terrace";
                hallPrice = 5000.00m;
            }
            else
            {
                hallName = "Great Hall";
                hallPrice = 7500.00m;
            }
            decimal totalPrice = (hallPrice + price) * discount;
            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {totalPrice / (decimal)people :F2}$");
        }
    }
}