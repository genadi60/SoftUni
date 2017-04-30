using System;

class OddEvenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal? maxOdd = null;
        decimal sumOdd = 0.0m;
        decimal? minOdd = null;
        decimal? maxEven = null;
        decimal sumEven = 0.0m;
        decimal? minEven = null;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                decimal userInput = decimal.Parse(Console.ReadLine());
                if (!maxOdd.HasValue)
                {
                    maxOdd = userInput;
                }
                if (!minOdd.HasValue)
                {
                    minOdd = userInput;
                }
                sumOdd += userInput;
                if(maxOdd < userInput)
                {
                    maxOdd = userInput;
                }
                else if(minOdd > userInput)
                {
                    minOdd = userInput;
                }
            }
            else
            {
                decimal userInput = decimal.Parse(Console.ReadLine());
                if (!maxEven.HasValue)
                {
                    maxEven = userInput;
                }
                if (!minEven.HasValue)
                {
                    minEven = userInput;
                }
                sumEven += userInput;
                if (maxEven < userInput)
                {
                    maxEven = userInput;
                }
                else if (minEven > userInput)
                {
                    minEven = userInput;
                }
            }
        }
        string no = "No";
        string minO = "OddMin={0},";
        string maxO = "OddMax={0},";
        string minE = "EvenMin={0},";
        string maxE = "EvenMax={0}";

        Console.WriteLine("OddSum={0},", sumOdd.ToString().TrimEnd('0').TrimEnd('.'));
        HasOrNoValue(minOdd, no, minO);
        HasOrNoValue(maxOdd, no, maxO);
        Console.WriteLine("EvenSum={0},", sumEven.ToString().TrimEnd('0').TrimEnd('.'));
        HasOrNoValue(minEven, no, minE);
        HasOrNoValue(maxEven, no, maxE);
    }

    private static void HasOrNoValue(decimal? a, string no, string m)
    {
        if (a.HasValue)
        {
            Console.WriteLine(m, a.ToString().TrimEnd('0').TrimEnd('.'));
        }
        else
        {
            Console.WriteLine(m, no);
        }
    }
}