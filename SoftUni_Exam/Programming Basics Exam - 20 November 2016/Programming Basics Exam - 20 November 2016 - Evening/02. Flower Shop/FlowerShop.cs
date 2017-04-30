using System;

class FlowerShop
{
    static void Main()
    {
        decimal tax = 0.05m;
        decimal[] prices = new decimal[] { 3.25m, 4.00m, 3.50m, 8.00m };
        decimal sum = 0.00m;
        for (int i = 0; i < 4; i++)
        {
            sum += prices[i] * int.Parse(Console.ReadLine());
        }
        decimal gifPrice = decimal.Parse(Console.ReadLine());
        sum -= sum * tax;
        if (sum >= gifPrice)
        {
            Console.WriteLine("She is left with {0} leva.", (int)(sum - gifPrice));
        }
        else
        {
            Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(gifPrice - sum));
        }
    }
}