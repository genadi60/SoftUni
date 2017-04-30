using System;

class BitwiseOperators
{
    static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());
        int[] array = new int[countOfNumbers];
        for (int i = 0; i < countOfNumbers; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            string binary = Convert.ToString(array[i], 2);
            string reverse = string.Empty;
            for (int j = 0; j < binary.Length; j++)
            {
                reverse = binary[j].ToString() + reverse;
            }
            Console.WriteLine(Convert.ToUInt32(reverse,2));
        }
    }
}