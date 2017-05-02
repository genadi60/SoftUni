using System;

class SpecialNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            foreach(char a in i.ToString())
            {
                sum += a - '0';
            }
            if (sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }
            sum = 0;
        }
    }
}