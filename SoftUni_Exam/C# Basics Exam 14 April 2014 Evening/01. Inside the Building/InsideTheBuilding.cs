using System;

class InsideTheBuilding
{
    static void Main()
    {
        int blockSize = int.Parse(Console.ReadLine());
        string[] coordArea = new string[5];
        for (int i = 0; i < 5; i++)
        {
            int coordX = int.Parse(Console.ReadLine());
            int coordY = int.Parse(Console.ReadLine());
            if ((0 <= coordX && coordX <= 3 * blockSize && 0 <= coordY && coordY <= blockSize)
                || (blockSize <= coordX && coordX <= 2 * blockSize && blockSize <= coordY && coordY <= 4 * blockSize))
            {
                coordArea[i]= "inside";
            }
            else
            {
                coordArea[i] = "outside";
            }
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(coordArea[i]);
        }
    }
}