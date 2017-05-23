using System;
using System.Collections.Generic;

class BePositive
{
    static void Main()
    {
        var countSequences = long.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            var numbers = new List<decimal>();

            for (int j = 0; j < input.Length; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    var num = decimal.Parse(input[j]);
                    numbers.Add(num);
                }
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                var currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                else 
                {
                    if (j < numbers.Count - 1)
                    {
                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }

                        j++;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            Console.WriteLine();
        }
    }
}