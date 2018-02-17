using System;
using System.Linq;

public class PlayCatch
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var arr = line
            .Split()
            .Select(int.Parse)
            .ToArray();
        var catchCount = 0;
        while (catchCount < 3)
        {
            var input = Console.ReadLine();
            var commands = input
                .Split()
                .ToArray();
            var command = commands[0];
            switch (command)
            {
                case "Replace":
                    try
                    {
                        var index = int.Parse(commands[1]);
                        var value = int.Parse(commands[2]);
                        try
                        {
                            arr[index] = value;
                        }
                        catch (Exception)
                        {
                            catchCount++;
                            Console.WriteLine("The index does not exist!");
                            break;
                        }
                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        catchCount++;
                    }
                    break;

                case "Show":
                    try
                    {
                        var index = int.Parse(commands[1]);
                        try
                        {
                            Console.WriteLine(arr[index]);
                        }
                        catch (Exception)
                        {
                            catchCount++;
                            Console.WriteLine("The index does not exist!");
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        catchCount++;
                        Console.WriteLine("The variable is not in the correct format!");
                    }
                    
                    break;
                case "Print":
                    try
                    {
                        var startIndex = int.Parse(commands[1]);
                        var endIndex = int.Parse(commands[2]);
                        try
                        {
                            bool isFirst = false;
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                var a = arr[startIndex];
                                var b = arr[endIndex];
                                if (isFirst)
                                {
                                    Console.Write(", ");
                                }
                                Console.Write(arr[i]);
                                isFirst = true;
                            }
                            Console.WriteLine();
                        }
                        catch (Exception)
                        {
                            catchCount++;
                            Console.WriteLine("The index does not exist!");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        catchCount++;
                    }
                    
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(String.Join(", ", arr));
    }
}