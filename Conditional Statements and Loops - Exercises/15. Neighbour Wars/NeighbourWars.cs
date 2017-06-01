using System;

class NeighbourWars
{
    static void Main()
    {
        var damagePesho = int.Parse(Console.ReadLine());
        var damageGosho = int.Parse(Console.ReadLine());
        var nameFirstPlayer = "Pesho";
        var nameSecondPlayer = "Gosho";
        var attacPesho = "Roundhouse kick";
        var attacGosho = "Thunderous fist";
        var healtPesho = 100;
        var healtGosho = 100;
        var count = 0;
        while (healtPesho > 0 && healtGosho > 0)
        {
            if (count % 3 == 0 && count > 0)
            {
                healtPesho += 10;
                healtGosho += 10;
            }
            count++;
            if (count % 2 == 1)
            {
                healtGosho -= damagePesho;
                if (healtGosho <= 0)
                {
                    break;
                }
                Console.WriteLine($"{nameFirstPlayer} used {attacPesho} and reduced {nameSecondPlayer} to {healtGosho} health.");
            }
            else
            {
                healtPesho -= damageGosho;
                if (healtPesho <= 0)
                {
                    break;
                }
                Console.WriteLine($"{nameSecondPlayer} used {attacGosho} and reduced {nameFirstPlayer} to {healtPesho} health.");
            }
        }
        var winner = string.Empty;
        if (healtPesho > healtGosho)
        {
            winner = nameFirstPlayer;
        }
        else
        {
            winner = nameSecondPlayer;
        }
        Console.WriteLine($"{winner} won in {count}th round.");
    }
}