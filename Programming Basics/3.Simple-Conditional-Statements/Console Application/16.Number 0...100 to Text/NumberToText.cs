using System;

class NumberToText
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        string d = string.Empty;
        string e = string.Empty;
        string[] numbers1 = new string[] {"zero", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine"}; 
        string[] numbers2 = new string[] {"ten", "eleven", "twelve", "thirteen",
            "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        string[] d1 = new string[] {"twenty", "thirty", "fourty", "fifty", "sixty",
            "seventy", "eighty", "ninety"};
        if(number >= 0 && number <= 100)
        {
            if (number / 10 == 0)
            {
                Console.WriteLine(numbers1[number % 10]);
            }
            else if (number / 10 == 1)
            {
                Console.WriteLine(numbers2[number % 10]);
            }
            else if (number / 10 > 1 && number % 10 == 0 && number < 100)
            {
                Console.WriteLine(d1[number / 10 - 2]);
            }
            else if (number / 10 == 10)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine(d1[number / 10 - 2] + " " + numbers1[number % 10]);
            }
        }
        else
        {
            Console.WriteLine("invalid number");
        }
    }
}