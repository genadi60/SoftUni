using System;

class InstructionSet_broken
{
    static void Main()
    {
        string[] codeArgs = Console.ReadLine().ToUpper().Split(' ');

        while (codeArgs[0] != "END")
        {
            long result = 0;
            var operandOne = long.Parse(codeArgs[1]);
            
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        result = ++operandOne;
                        break;
                    }
                case "DEC":
                    {
                        result = --operandOne;
                        break;
                    }
                case "ADD":
                    {
                        var operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        var operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }

            Console.WriteLine(result);
            codeArgs = Console.ReadLine().ToUpper().Split(' ');
        }
    }
}