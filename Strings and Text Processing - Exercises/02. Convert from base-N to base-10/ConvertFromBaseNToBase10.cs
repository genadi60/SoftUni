using System;
using System.Linq;
using System.Numerics;

public class ConvertFromBaseNToBase10
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var inputData = line
            .Split()
            .ToArray();
        var baseN = int.Parse(inputData[0]);
        var strNumber = inputData[1];
        var pow = strNumber.Length - 1;
        BigInteger outputNumber = 0;
        var digit = 0;

        foreach (var sign in strNumber)
        {

            BigInteger poweredBase = 1;
            for (int i = 0; i < pow; i++)
            {
                poweredBase *= baseN;
            }
            
            switch (sign)
            {
                case 'A':
                case 'a':
                    digit = 10;
                    outputNumber += digit * poweredBase;
                    break;
                case 'B':
                case 'b':
                    digit = 11;
                    outputNumber += digit * poweredBase;
                    break;
                case 'C':
                case 'c':
                    digit = 12;
                    outputNumber += digit * poweredBase;
                    break;
                case 'D':
                case 'd':
                    digit = 13;
                    outputNumber += digit * poweredBase;
                    break;
                case 'E':
                case 'e':
                    digit = 14;
                    outputNumber += digit * poweredBase;
                    break;
                case 'F':
                case 'f':
                    digit = 15;
                    outputNumber += digit * poweredBase;
                    break;
                default:
                    digit = int.Parse(sign.ToString());
                    outputNumber += digit * poweredBase;
                    break;
            }
            pow--;
        }
        Console.WriteLine(outputNumber);
    }
}