using System;

class TransportTax
{
    static void Main()
    {
        var distance = int.Parse(Console.ReadLine());
        var period = Console.ReadLine();
        decimal tax = 0;
        if(distance < 20)
        {
            if(period == "day")
            {
                tax += distance * 0.79M + 0.70M;
            }
            else
            {
                tax += distance * 0.90M + 0.70M;
            }
        }
        else
        {
            if(distance < 100)
            {
                tax += distance * 0.09M;
            }
            else
            {
                tax += distance * 0.06M;
            }
        }
        Console.WriteLine(Convert.ToString(tax).TrimEnd('0').TrimEnd('.'));
    }
}