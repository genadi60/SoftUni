using System;

class TheatrePromotion
{
    static void Main()
    {

        var day = Console.ReadLine().ToLower();
        var age = int.Parse(Console.ReadLine());
        var result = string.Empty;
        switch (day)
        {
            case "weekday":
                if ((age >=0 && age <= 18) || (age > 64 && age <= 122))
                {
                    result = "12$";
                }
                else if (age > 18 && age <= 64)
                {
                    result = "18$";
                }
                else
                {
                    result = "Error!";
                }
                break;
            case "weekend":
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    result = "15$";
                }
                else if (age > 18 && age <= 64)
                {
                    result = "20$";
                }
                else
                {
                    result = "Error!";
                }
                break;
            case "holiday":
                if (age >= 0 && age <= 18)
                {
                    result = "5$";
                }
                else if (age > 18 && age <= 64)
                {
                    result = "12$";
                }
                else if (age > 64 && age <= 122)
                {
                    result = "10$";
                }
                else
                {
                    result = "Error!";
                }
                break;
            default:
                break;
        }
        Console.WriteLine(result);
    }
}