using System;
using System.Collections.Generic;

class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int count = 0;
        List<char> elements = new List<char> { 'a', 'b', 'c', 'd', 'e' };
        List<int> value = new List<int> { 5, -12, 47, 7, -32 };

        for (int i = 0; i < elements.Count; i++)
        {
            for (int j = 0; j < elements.Count; j++)
            {
                for (int k = 0; k < elements.Count; k++)
                {
                    for (int l = 0; l < elements.Count; l++)
                    {
                        for (int m = 0; m < elements.Count; m++)
                        {
                            int n = 2;
                            int weight = value[i];
                            if(value[i] != value[j])
                            {
                                weight += n*value[j];
                                n++;
                            }
                            if(value[i] != value[k] && value[j] != value[k])
                            {
                                weight += n * value[k];
                                n++;
                            }
                            if(value[i] != value[l] && value[j] != value[l] && value[k] != value[l])
                            {
                                weight += n * value[l];
                                n++;
                            }
                            if(value[i] != value[m] && value[j] != value[m] && value[k] != value[m] && value[l] != value[m])
                            {
                                weight += n * value[m];
                                n++;
                            }
                            if(start <= weight && end >= weight)
                            {
                                if(count != 0)
                                {
                                    Console.Write(' ');
                                }
                                Console.Write(elements[i]);
                                Console.Write(elements[j]);
                                Console.Write(elements[k]);
                                Console.Write(elements[l]);
                                Console.Write(elements[m]);
                                count++;
                            }
                        }
                    }
                }
            }
        }
        if(count == 0)
        {
            Console.Write("No");
        }
        Console.WriteLine();
    }
}