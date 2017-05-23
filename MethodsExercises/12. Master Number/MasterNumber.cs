using System;
using System.Collections.Generic;

class MasterNumber
{
    static void Main()
    {
        var range = long.Parse(Console.ReadLine());
        List<string> containsEvenAndSum = ContainsEvenDigitAndSumOfDigits(range);
        IsPalindrome(containsEvenAndSum);
    }
 
    static void IsPalindrome(List<string> list)
    {
        foreach (string item in list)
        {
            var counter = 0;
            for (int i = 0; i < item.Length / 2; i++)
            {
                if (item[i] == item[item.Length - 1 - i])
                {
                    counter++;
                }
            }
            if (counter == item.Length / 2)
            {
                Console.WriteLine(item);
            }
        }
    }

    static List<string> ContainsEvenDigitAndSumOfDigits(long range)
    {
        List<string> containsEven = new List<string>();
        var sum = 0;
        bool even = false;
        for (long i = 1; i <= range; i++)
        {
            foreach (char a in i.ToString())
            {
                sum += a - '0';
                if ((a - '0') % 2 == 0 && !even)
                {
                    even = true;
                }
            }
            if (sum % 7 == 0 && even)
            {
                containsEven.Add(i.ToString());
            }
            else
            {
                even = false;
                sum = 0;
            }
        }
        return containsEven;
    }
}