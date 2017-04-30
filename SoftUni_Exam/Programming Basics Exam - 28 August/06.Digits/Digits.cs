using System;

class Digits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int firstDigit = (number / 100) % 10;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number % 10;
        int row = firstDigit + secondDigit;
        int col = firstDigit + thirdDigit;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (number % 5 == 0)
                {
                    number -= firstDigit;
                }
                else if (number % 3 == 0)
                {
                    number -= secondDigit;
                }
                else
                {
                    number += thirdDigit;
                }

                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }
    }
}