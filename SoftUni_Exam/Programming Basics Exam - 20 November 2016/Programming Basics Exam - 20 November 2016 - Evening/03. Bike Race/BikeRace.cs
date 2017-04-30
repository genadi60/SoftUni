using System;

class BikeRace
{
    static void Main()
    {
        int numJuniors = int.Parse(Console.ReadLine());
        int numSeniors = int.Parse(Console.ReadLine());
        string typeTrace = Console.ReadLine();
        string[] trace = new string[] { "trail", "cross-country", "downhill", "road" };
        double[] juniors = new double[] { 5.50, 8.00, 12.25, 20.00 };
        double[] seniors = new double[] { 7.00, 9.50, 13.75, 21.50 };
        int index = Array.IndexOf(trace, typeTrace);
        double junPrice = juniors[index];
        double senPrice = seniors[index];
        if ((numJuniors + numSeniors) >= 50 && index == 1)
        {
            junPrice = juniors[index] - juniors[index] * 25 / 100;
            senPrice = seniors[index] - seniors[index] * 25 / 100;
        }
        double sum = numJuniors * junPrice  + numSeniors * senPrice;
        sum = sum - sum * 5 / 100;
        Console.WriteLine("{0:F2}", sum);
    }
}