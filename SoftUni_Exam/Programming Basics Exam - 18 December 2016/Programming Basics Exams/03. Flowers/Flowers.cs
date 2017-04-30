using System;

class Flowers
{
    static void Main()
    {
        int hriz = int.Parse(Console.ReadLine());
        int roz = int.Parse(Console.ReadLine());
        int lal = int.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();
        char day = (char)Console.Read();

        decimal[] summer = new decimal[] { 2.00m, 4.10m, 2.50m };
        decimal[] winter = new decimal[] { 3.75m, 4.50m, 4.15m };
        decimal price = 0.00m;

        if (hriz != 0 || roz != 0 || lal != 0)
        {
            if (day == 'Y' || day == 'y')
            {
                for (int i = 0; i < 3; i++)
                {
                    summer[i] *= 1.15m;
                    winter[i] *= 1.15m;
                }
            }

            if (season == "summer" || season == "spring")
            {
                if (season == "spring" && lal > 7)
                {
                    price += (summer[0] * hriz + summer[1] * roz + summer[2] * lal) * 0.95m;
                }
                else
                {
                    price += (summer[0] * hriz + summer[1] * roz + summer[2] * lal);
                }
            }
            else
            {
                if (season == "winter" && roz >= 10)
                {
                    price += (winter[0] * hriz + winter[1] * roz + winter[2] * lal) * 0.90m;
                }
                else
                {
                    price += (winter[0] * hriz + winter[1] * roz + winter[2] * lal);
                }
            }

            if ((hriz + roz + lal) > 20)
            {
                price *= 0.80m;
            }
        }

        price += 2.00m;

        Console.WriteLine("{0}", Math.Round(price, 2));
    }
}