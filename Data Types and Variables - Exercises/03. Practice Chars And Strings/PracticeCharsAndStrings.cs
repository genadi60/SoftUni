using System;

public class PracticeCharsAndStrings
{
    public static void Main()
    {
        var userInput = Console.ReadLine();
        while (userInput != string.Empty)
        {
            if (userInput.Length == 1)
            {
                char[] itemInUserInput = userInput.ToCharArray();
                char sign = itemInUserInput[0];
                Console.WriteLine(sign);
            }
            else
            {
                string characters = userInput;
                Console.WriteLine(characters);
            }
            userInput = Console.ReadLine();
        }
        
    }
}