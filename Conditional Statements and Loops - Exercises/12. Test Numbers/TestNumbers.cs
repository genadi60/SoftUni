using System;

class TestNumbers
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        var sumMax = int.Parse(Console.ReadLine());
        int sum = 0;
        int count = 0;
        bool sumIsLess = true;
        for (int i = firstNumber; i > 0; i--)
        {
            for (int j = 1; j <= secondNumber; j++)
            {
                sum = sum + 3 * i * j;
                if (sum < sumMax)
                {
                    count++;
                }
                else
                {
                    sumIsLess = false;
                    count++;
                    break;
                }
            }
            if (!sumIsLess)
            {
                break;
            }
        }
        Console.WriteLine($"{count} combinations");
        if (sumIsLess)
        {
            Console.WriteLine($"Sum: {sum}");
        }
        else
        {
            Console.WriteLine($"Sum: {sum} >= {sumMax}");
        }
    }
}