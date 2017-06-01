using System;

class GameOfNumbers
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        var magicNumber = int.Parse(Console.ReadLine());
        int sum = 0;
        int count = 0;
        int firstDigit = 0;
        int secondDigit = 0;
        bool sumIsLess = false;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            for (int j = firstNumber; j <= secondNumber; j++)
            {
                sum = i + j;
                count++;
                if (sum == magicNumber)
                {
                    firstDigit = i;
                    secondDigit = j;
                    sumIsLess = true;
                }
            }
        }
        
        if (sumIsLess)
        {
            Console.WriteLine($"Number found! {firstDigit} + {secondDigit} = {magicNumber}");
        }
        else
        {
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}