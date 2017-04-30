using System;

class SumDigits
{
    static void Main()
    {
        string num = Console.ReadLine();
        int sum = 0;
        foreach(char a in num)
        {
            sum += a - '0';
        }
        Console.WriteLine(sum);
    }
}