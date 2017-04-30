using System;
using System.Collections.Generic;


class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        double quantity1 = double.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        double quantity2 = double.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        double quantity3 = double.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();
        double pBanana = 1.8;
        double pCucumber = 2.75;
        double pTomato = 3.2;
        double pOrange = 1.6;
        double pApple = 0.86;
        int index = 0;
        double result = 0.0;
        List<double> quantity = new List<double> { quantity1, quantity2, quantity3 };
        List<string> product = new List<string> { product1, product2, product3 };

        switch (dayOfWeek)
        {
            case "Sunday":
                pBanana *= 0.95;
                pCucumber *= 0.95;
                pTomato *= 0.95;
                pOrange *= 0.95;
                pApple *= 0.95;
                break;
            case "Tuesday":
                pBanana *= 0.8;
                pOrange *= 0.8;
                pApple *= 0.8;
                break;
            case "Wednesday":
                pCucumber *= 0.9;
                pTomato *= 0.9;
                break;
            case "Thursday":
                pBanana *= 0.7;
                break;
            case "Friday":
                pBanana *= 0.9;
                pCucumber *= 0.9;
                pTomato *= 0.9;
                pOrange *= 0.9;
                pApple *= 0.9;
                break;
            default:
                break;
        }
        for (index = 0; index < product.Count; index++)
        {
            double preis = 0.0;
            switch (product[index])
            {
                case "banana":
                    preis = pBanana * quantity[index];
                    break;
                case "cucumber":
                    preis = pCucumber * quantity[index];
                    break;
                case "tomato":
                    preis = pTomato * quantity[index];
                    break;
                case "orange":
                    preis = pOrange * quantity[index];
                    break;
                case "apple":
                    preis = pApple * quantity[index];
                    break;
                default:
                    break;
            }
            result += preis;
        }
        Console.WriteLine("{0:F2}",result);
    }
}