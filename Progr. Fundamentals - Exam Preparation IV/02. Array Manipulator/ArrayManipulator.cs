using System;
using System.Collections.Generic;

class ArrayManipulator
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(' ');
        List<int> elements = new List<int> {};
        for (int i = 0; i < array.Length; i++)
        {
            elements.Add(int.Parse(array[i]));
        }
        string[] command = Console.ReadLine().Split(' ');
        while (command[0] != "end")
        {
            switch (command[0])
            {
                case "max":
                    int index = MaxValueIndex(command, elements);
                    if (index != -1)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
                case "min":
                    index = MinValueIndex(command, elements);
                    if (index != -1)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
                case "first":
                    int len = int.Parse(command[1]);
                    if (len <= elements.Count && len >= 0)
                    {
                        int[] arrOut = new int[len];
                        int b = 0;
                        for (int i = 0; i < len; i++)
                        {
                            index = FirstElements(command, elements, b);
                            if (index != -1)
                            {
                                arrOut[i] = elements[index];
                                b = index + 1;
                            }
                            else
                            {
                                arrOut[i] = -1;
                            }
                        }
                        Console.Write('[');
                        for (int i = 0; i < arrOut.Length; i++)
                        {
                            if (arrOut[i] != -1)
                            {
                                Console.Write(arrOut[i]);
                                if (i < arrOut.Length - 1 && arrOut[i + 1] != -1)
                                {
                                    Console.Write(", ");
                                }
                            }
                        }
                        Console.Write(']');
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                    
                    break;
                case "last":
                    len = int.Parse(command[1]);
                    if (len <= elements.Count && len >= 0)
                    {
                        int[] arrOut = new int[len];
                        int b = elements.Count - 1;
                        for (int i = len -1; i >= 0; i--)
                        {
                            index = LastElements(command, elements, b);
                            if (index != -1)
                            {
                                arrOut[i] = elements[index];
                                b = index - 1;
                            }
                            else
                            {
                                arrOut[i] = -1;
                            }
                        }
                        Console.Write('[');
                        for (int i = 0; i < arrOut.Length; i++)
                        {
                            if (arrOut[i] != -1)
                            {
                                Console.Write(arrOut[i]);
                                if (i < arrOut.Length - 1 && arrOut[i + 1] != -1)
                                {
                                    Console.Write(", ");
                                }
                            }
                        }
                        Console.Write(']');
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }

                    break;
                case "exchange":
                    int splitIndex = int.Parse(command[1]);
                    if (splitIndex < elements.Count && splitIndex >= 0)
                    {
                        List<int> temp = new List<int> { };
                        temp = elements.GetRange(0, splitIndex + 1);
                        elements.RemoveRange(0, splitIndex + 1);
                        elements.AddRange(temp);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;
                default:
                    break;
            }
            command = Console.ReadLine().Split(' ');
        }
        Console.Write('[');
        for (int i = 0; i < elements.Count; i++)
        {
            Console.Write(elements[i]);
            if (i < elements.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write(']');
        Console.WriteLine();
    }

    private static int LastElements(string[] command, List<int> elements, int b)
    {
        int a = -1;
        if (command[2] == "even")
        {
            for (int i = b; i >= 0; i--)
            {
                if (elements[i] % 2 == 0)
                {
                    a = i;
                    return a;
                }
            }
        }
        else
        {
            for (int i = b; i >= 0; i--)
            {
                if (elements[i] % 2 != 0)
                {
                    a = i;
                    return a;
                }
            }
        }
        return a;
    }

    static int FirstElements(string[] command, List<int> elements, int b)
    {
        int a = -1;
        if (command[2] == "even")
        {
            for (int i = b; i < elements.Count; i++)
            {
                if (elements[i] % 2 == 0)
                {
                    a = i;
                    return a;
                }
            }
        }
        else
        {
            for (int i = b; i < elements.Count; i++)
            {
                if (elements[i] % 2 != 0)
                {
                    a = i;
                    return a;
                }
            }
        }
        return a;
    }

    static int MinValueIndex(string[] command, List<int> elements)
    {
        int a = -1;
        int minValue = 1000;
        if (command[1] == "even")
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 2 == 0 && minValue >= elements[i])
                {
                    minValue = elements[i];
                    a = i;
                }
            }
        }
        else
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 2 != 0 && minValue >= elements[i])
                {
                    minValue = elements[i];
                    a = i;
                }
            }
        }
        return a;
    }

    static int MaxValueIndex(string[] command, List<int> elements)
    {
        int a = -1;
        int maxValue = 0;
        if (command[1] == "even")
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 2 == 0 && maxValue <= elements[i])
                {
                    maxValue = elements[i];
                    a = i;
                }
            }
        }
        else
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 2 != 0 && maxValue <= elements[i])
                {
                    maxValue = elements[i];
                    a = i;
                }
            }
        }
        return a;
    }
}