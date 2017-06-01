using System;

public class SMSTyping
{
    public static void Main()
    {
        var numberOfWords = int.Parse(Console.ReadLine());
        var pressedDigit = string.Empty;
        var digit = 0;
        var index = 0;
        var message = string.Empty;
        var toWrite = ' ';
        for (int i = 0; i < numberOfWords; i++)
        {
            pressedDigit = Console.ReadLine();
            digit = int.Parse(pressedDigit[0].ToString());
            if (digit > 1)
            {
                if (digit < 8)
                {
                    index = (digit * 3 - 6) + pressedDigit.Length;
                }
                else
                {
                    index = (digit * 3 - 5) + pressedDigit.Length;
                }
                toWrite = (char)(96 + index);
            }
            else
            {
                toWrite = (char)(32);
            }
            message += toWrite;
        }

        Console.WriteLine(message);
    }
}