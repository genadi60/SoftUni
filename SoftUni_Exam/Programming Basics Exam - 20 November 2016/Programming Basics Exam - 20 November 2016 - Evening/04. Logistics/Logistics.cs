using System;

class Logistics
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        decimal sum = 0.00m;
        int micWare = 0;
        int truckWare = 0;
        int trainWare = 0;
        for (int i = 0; i < num; i++)
        {
            int ware = int.Parse(Console.ReadLine());
            sum += ware;
            if (ware <= 3)
            {
                micWare += ware;
            }
            else if (ware <= 11)
            {
                truckWare += ware;
            }
            else
            {
                trainWare += ware;
            }
        }
        decimal averagePrice = (micWare * 200.00m + truckWare * 175.00m + trainWare * 120.00m) / sum;
        decimal mic = micWare / sum * 100.00m;
        decimal truck = truckWare / sum * 100.00m;
        decimal train = trainWare / sum * 100.00m;
        Console.WriteLine("{0:F2}", averagePrice);
        Console.WriteLine("{0:F2}%", mic);
        Console.WriteLine("{0:F2}%", truck);
        Console.WriteLine("{0:F2}%", train);
    }
}