using System;

class TradeComissions
{
    static void Main()
    {
        decimal[] sofia = new decimal[] { 0.05m, 0.07m, 0.08m, 0.12m };
        decimal[] varna = new decimal[] { 0.045m, 0.075m, 0.10m, 0.13m };
        decimal[] plovdiv = new decimal[] { 0.055m, 0.08m, 0.12m, 0.145m };
        int index = -1;
        decimal commision = 0.0m;
        string town = Console.ReadLine().ToLower();
        decimal sales = decimal.Parse(Console.ReadLine());
        if (sales >= 0 && sales <= 500)
        {
            index = 0;
        }
        else   if (sales >= 500 && sales <= 1000)
        {
            index = 1;
        }
        else if (sales >= 1000 && sales <= 10000)
        {
            index = 2;
        }
        else if (sales > 10000)
        {
            index = 3;
        }
        if (index != -1)
        {
            switch (town)
            {
                case "sofia":
                    commision = sofia[index];
                    break;
                case "varna":
                    commision = varna[index];
                    break;
                case "plovdiv":
                    commision = plovdiv[index];
                    break;
                default:
                    index = -1;
                    break;
            }
        }
            
        if (index != -1)
        {
            Console.WriteLine("{0:F2}", sales * commision);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}