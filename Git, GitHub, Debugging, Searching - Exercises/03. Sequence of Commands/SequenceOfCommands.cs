using System;
using System.Linq;

class SequenceOfCommands
{
    private const char ArgumentsDelimiter = ' ';
    static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine().Split(ArgumentsDelimiter).Select(long.Parse).ToArray();

        string[] line = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();
        string command = line[0].ToLower();

        while (!command.Equals("stop"))
        {
            int[] args = new int[2];

            if (command.Equals("add") || command.Equals("subtract") || command.Equals("multiply"))
            {
                args[0] = int.Parse(line[1]);
                args[1] = int.Parse(line[2]);
            }

            PerformAction(array, command, args);

            PrintArray(array);
            Console.WriteLine();

            line = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();
            command = line[0].ToLower();
        }
}
    static void PerformAction(long[] array, string action, int[] args)
    {
        int pos = args[0] -1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long temp = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long temp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = temp;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}