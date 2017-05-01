using System;
using System.Collections.Generic;

class BePositive
{
    static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());
        string[] input = new string[countSequences];

        for (int i = 0; i < countSequences; i++)
        {
            input[i] = Console.ReadLine();
        }

        for (int i = 0; i < countSequences; i++)
        {
            string[] template = input[i].Trim().Split(' ');
            var numbers = new List<int>();

            for (int j = 0; j < template.Length; j++)
            {
                if (!template[j].Equals(string.Empty))
                {
                    int num = int.Parse(template[j]);
                    numbers.Add(num);
                }
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];
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
                        j++;
                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(currentNum);
                            found = true;
                        }
                    }
                }
            }
        
            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}