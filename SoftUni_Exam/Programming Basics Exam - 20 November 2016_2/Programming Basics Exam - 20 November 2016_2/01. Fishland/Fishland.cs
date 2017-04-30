using System;

class Fishland
{
    static void Main()
    {
        decimal skumPrice = decimal.Parse(Console.ReadLine());
        decimal zazaPrice = decimal.Parse(Console.ReadLine());
        decimal palamud = decimal.Parse(Console.ReadLine());
        decimal safrid = decimal.Parse(Console.ReadLine());
        int midi = int.Parse(Console.ReadLine());
        decimal midiPrice = 7.50m;
        decimal palmudPrice = skumPrice * 1.60m;
        decimal safridPrice = zazaPrice * 1.80m;
        decimal totalPrice = palamud * palmudPrice + safrid * safridPrice + midi * midiPrice;
        Console.WriteLine("{0:F2}", totalPrice);
    }
}