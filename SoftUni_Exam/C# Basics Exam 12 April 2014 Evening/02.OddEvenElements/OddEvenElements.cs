using System;
using System.Collections.Generic;

class OddEvenElements
{
    static void Main()
    {
        string[] userInput = Console.ReadLine().Split(' ');
        if (userInput.Length > 1 && userInput[0] != "")
        {
            List<double> numbers = new List<double>();
            int cor = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                numbers.Add(double.Parse(userInput[i]));
            }
            double sumOdd = FindSum(numbers, cor);
            double sumEven = FindSum(numbers, ++cor);
            cor = 0;
            double oddMax = FindMax(numbers, cor);
            double evenMax = FindMax(numbers, ++cor);
            cor = 0;
            double oddMin = FindMin(numbers, cor);
            double evenMin = FindMin(numbers, ++cor);
            cor = 0;

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", sumOdd, oddMin, oddMax, sumEven, evenMin, evenMax);
        }
        else
        {
            if (userInput[0] == "")
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else
            {
                double one = Math.Round(double.Parse(userInput[0]), 2, MidpointRounding.AwayFromZero); ;
                Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=No, EvenMin=No, EvenMax=No", one);
            }
        }
    }
      
    static double FindMin(List<double> numbers, int cor)
    {
        double min = numbers[cor];
        for (int i = cor; i < numbers.Count; i += 2)
        {
            min = Math.Min(min, numbers[i]);
        }
        return Math.Round(min, 2, MidpointRounding.AwayFromZero);
       
    }

    static double FindMax(List<double> numbers, int cor)
    {
        double max = numbers[cor];
        for (int i = cor; i < numbers.Count; i+=2)
        {
            max = Math.Max(max, numbers[i]);
        }
        return Math.Round(max, 2, MidpointRounding.AwayFromZero);
    }

    static double FindSum(List<double> numbers, int cor)
    {
        double sum = 0;
        for (int i = cor; i < numbers.Count; i += 2)
        {
            sum += numbers[i];
        }
        return Math.Round(sum, 2, MidpointRounding.AwayFromZero);
    }
}