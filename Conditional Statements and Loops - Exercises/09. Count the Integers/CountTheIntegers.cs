using System;

class CountTheIntegers
{
    static void Main()
    {
        var userInput = Console.ReadLine();
        int count = 0;
        bool isNumber = true;
        while (isNumber)
        {
            try
            {
                var number = long.Parse(userInput);
            }
            catch (Exception)
            {
                isNumber = false;
                break;
            }

            count++;
            userInput = Console.ReadLine();
        }
        Console.WriteLine(count);
    }
}