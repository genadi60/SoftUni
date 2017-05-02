using System;

class RefactorSpecialNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sumOfDigits = 0;
        int temp = 0;
        bool condition = false;
        for (int i = 1; i <= number; i++)
        {

            temp = i;
            while (temp > 0)
            {
                sumOfDigits += temp % 10;
                temp = temp / 10;
            }
            condition = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
            Console.WriteLine($"{i} -> {condition}");
            sumOfDigits = 0;
        }
    }
}