using System;
using System.Linq;
using System.Collections.Generic;

public class PracticeFloatingPoints
{
    public static void Main()
    {
        var userInput = Console.ReadLine();
        List<string> separatedString = userInput.Split('.').ToList();
        while (userInput != string.Empty)
        {
            float number3;
            if (float.TryParse(userInput, out number3) && separatedString[1].Length < 8)
            {
                Console.WriteLine(number3);
            }
            else
            {
                double number2;
                if (double.TryParse(userInput, out number2) && separatedString[1].Length < 16)
                {
                    Console.WriteLine(number2);
                }
                else
                {
                    var number1 = decimal.Parse(userInput);
                    Console.WriteLine(number1);
                }
             }
            separatedString.Clear();
            userInput = Console.ReadLine();
            separatedString = userInput.Split('.').ToList();
        }
    }
}