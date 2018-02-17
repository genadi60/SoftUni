using System;
using System.Linq;
using System.Numerics;
using System.Text;

public class ConvertFromBase10ToBaseN
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var inputData = line
            .Split()
            .ToArray();
        var baseN = int.Parse(inputData[0]);
        var inputNumber = BigInteger.Parse(inputData[1]);
        StringBuilder output = new StringBuilder();
        while (inputNumber > 0)
        {
            var digit = (int)(inputNumber % baseN);
            var digitInOutput = digit.ToString();
            switch (digit)
            {
                case 10:
                    digitInOutput = "A";
                    break;
                case 11:
                    digitInOutput = "B";
                    break;
                case 12:
                    digitInOutput = "C";
                    break;
                case 13:
                    digitInOutput = "D";
                    break;
                case 14:
                    digitInOutput = "E";
                    break;
                case 15:
                    digitInOutput = "F";
                    break;
            }
            output.Insert(0, digitInOutput);
            inputNumber /= baseN;
        }
        Console.WriteLine(output);
    }
}