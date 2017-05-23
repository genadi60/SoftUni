using System;

class CubeProperties
{
    static void Main()
    {
        var side = double.Parse(Console.ReadLine());
        var parameter = Console.ReadLine();
        double result = 0.0;
        switch (parameter)
        {
            case "face":
                result = CubeFaceCalculate(side);
                break;
            case "space":
                result = CubeSpaceCalculate(side);
                break;
            case "volume":
                result = CubeVolumeCalculate(side);
                break;
            case "area":
                result = CubeAreaCalculate(side);
                break;
        }
        Console.WriteLine("{0:F2}", result);
    }

    static double CubeAreaCalculate(double side)
    {
        double result = side * side * 6;
        return result;
    }

    static double CubeVolumeCalculate(double side)
    {
        double result = side * side * side;
        return result;
    }

    static double CubeSpaceCalculate(double side)
    {
        double result = Math.Sqrt(side * side + CubeFaceCalculate(side) * CubeFaceCalculate(side));
        return result;
    }

    static double CubeFaceCalculate(double side)
    {
        double result = Math.Sqrt(2 * (side * side));

        return result;
    }
} 