using System;

public class BalancedBrackets
{
    public static void Main()
    {
        var numberOfsymbols = int.Parse(Console.ReadLine());
        var numberClosing = 0;
        var numberOpening = 0;
        for (int i = 0; i < numberOfsymbols; i++)
        {
            var symbol = Console.ReadLine();
            if (symbol.Equals(")"))
            {
                if (numberOpening == 0 || numberOpening == numberClosing)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                else
                {
                    numberClosing++;
                }
            }
            if (symbol.Equals("("))
            {
                numberOpening++;
            }
        }
        if (numberOpening == numberClosing)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}