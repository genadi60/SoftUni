using System;

public class VowelOrDigit
{
    public static void Main()
    {
        var userInput = Console.ReadLine().ToLower();
        int sign;
        if (int.TryParse(userInput, out sign))
        {
            Console.WriteLine("digit");
        }
        else
        {
            switch (userInput)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}