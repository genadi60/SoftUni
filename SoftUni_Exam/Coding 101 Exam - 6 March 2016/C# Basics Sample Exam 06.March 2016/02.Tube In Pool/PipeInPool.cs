using System;

class PipeInPool
{
    static void Main()
    {
        var volumeOfPool = int.Parse(Console.ReadLine());
        var pipe1Flow = int.Parse(Console.ReadLine());
        var pipe2Flow = int.Parse(Console.ReadLine());
        var missing = double.Parse(Console.ReadLine());
        var poolFull = (missing * (pipe1Flow + pipe2Flow) / (volumeOfPool / 100.0));
        if (missing * (pipe1Flow + pipe2Flow) > volumeOfPool)
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", missing, missing * (pipe1Flow + pipe2Flow) - volumeOfPool);
        }
        else
        {
            var pipe1Percent = pipe1Flow * 100 / (pipe1Flow + pipe2Flow);
            var pipe2Percent = pipe2Flow * 100 / (pipe1Flow + pipe2Flow);
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (int)poolFull, pipe1Percent, pipe2Percent);
        }


    }
}
