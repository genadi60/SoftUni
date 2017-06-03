using System;

public class NumberChecker
{
    public static void Main()
    {
        string[] userInput = Console.ReadLine().Split('.');
        if (userInput.Length < 2)
        {
            Console.WriteLine("integer");
        }
        else
        {
            Console.WriteLine("floating-point");
        }
    }
}