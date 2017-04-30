using System;

class BonusScore
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        double bonus = 0.0;
        if (number <= 100)
        {
            bonus += 5;
        }
        else if (number <= 1000 && number > 100)
        {
            bonus += number * 2.0 / 10;
        }
        else
        {
            bonus += number / 10.0;
        }
        if (number % 2 == 0)
        {
            bonus++;
        }
        if (number % 10 == 5)
        {
            bonus += 2;
        }
        Console.WriteLine(bonus);
        Console.WriteLine(number + bonus);
    }
}