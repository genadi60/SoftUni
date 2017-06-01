using System;
using System.Numerics;

public class PracticeIntegers
{
    public static void Main()
    {
        var userInput = Console.ReadLine();
        while (userInput != string.Empty)
        {
            ulong number;
            if (ulong.TryParse(userInput,out number))
            {
                long number1;
                if (long.TryParse(userInput,out number1))
                {
                    uint number2;
                    if (uint.TryParse(userInput,out number2))
                    {
                        int number3;
                        if (int.TryParse(userInput,out number3))
                        {
                            ushort number4;
                            if (ushort.TryParse(userInput,out number4))
                            {
                                short number5;
                                if (short.TryParse(userInput,out number5))
                                {
                                    byte number6;
                                    if (byte.TryParse(userInput,out number6))
                                    {
                                        sbyte number7;
                                        if (sbyte.TryParse(userInput,out number7))
                                        {
                                            Console.WriteLine(number7);
                                        }
                                        else
                                        {
                                            number6 = byte.Parse(userInput);
                                            Console.WriteLine(number6);
                                        }
                                    }
                                    else
                                    {
                                        number5 = short.Parse(userInput);
                                        Console.WriteLine(number5);
                                    }
                                }
                                else
                                {
                                    number4 = ushort.Parse(userInput);
                                    Console.WriteLine(number4);
                                }
                            }
                            else
                            {
                                number3 = int.Parse(userInput);
                                Console.WriteLine(number3);
                            }
                        }
                        else
                        {
                            number2 = uint.Parse(userInput);
                            Console.WriteLine(number2);
                        }
                    }
                    else
                    {
                        number1 = long.Parse(userInput);
                        Console.WriteLine(number1);
                    }
                }
                else
                {
                    number = ulong.Parse(userInput);
                    Console.WriteLine(number);
                }
            }
            else
            {
                var number8 = BigInteger.Parse(userInput);
                Console.WriteLine(number8);
            }
            userInput = Console.ReadLine();
        }
    }
}