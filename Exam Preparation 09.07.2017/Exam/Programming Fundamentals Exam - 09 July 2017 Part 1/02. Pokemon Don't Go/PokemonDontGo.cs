using System;
using System.Linq;
using System.Numerics;

public class PokemonDontGo
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .Select(BigInteger.Parse)
            .ToList();
        BigInteger sumRemoved = 0;
        while (numbers.Count > 0)
        {
            bool numbersLastelement = false;
            var index = int.Parse(Console.ReadLine());
            BigInteger copied = 0;
            bool minIndex = false;
            if (index < 0)
            {
                copied = numbers[numbers.Count - 1];
                index = 0;
                minIndex = true;
            }
            if (index >= numbers.Count)
            {
                index = numbers.Count - 1;
                numbersLastelement = true;
            }

            if (numbersLastelement)
            {
                numbers.Add(numbers[0]);
                numbersLastelement = false;
            }

            if (numbers.Count > 0 && index < numbers.Count)
            {
                var removedelement = numbers[index];
                sumRemoved += removedelement;
                numbers.RemoveAt(index);
                if (minIndex)
                {
                   numbers.Insert(0, copied);
                    minIndex = false;
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= removedelement)
                    {
                        numbers[i] += removedelement;
                    }
                    else
                    {
                        numbers[i] -= removedelement;
                    }

                }
            }

        }
        Console.WriteLine(sumRemoved);
    }
}