using System;

class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        decimal result = 0M;
        decimal preis = 0M;
        switch (type)
        {
            case "Premiere":
                preis = 12.00M;
                break;
            case "Normal":
                preis = 7.50M;
                break;
            case "Discount":
                preis = 5.00M;
                break;
            default:
                break;
        }
        result = row * col * preis;
        Console.WriteLine("{0:F2} leva",result);
    }
}