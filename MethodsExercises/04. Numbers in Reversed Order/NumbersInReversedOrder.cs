using System;

class NumbersInReversedOrder
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        decimal number;
        if (decimal.TryParse(userInput, out number))
        {
            Console.WriteLine(ReversOrderInNumber(userInput));
        }
    }

    static string ReversOrderInNumber(string userInput)
    {
        string reversOrder = string.Empty;
        foreach (char a in userInput)
        {
            reversOrder = a + reversOrder;
        }
        return reversOrder;
    }
}