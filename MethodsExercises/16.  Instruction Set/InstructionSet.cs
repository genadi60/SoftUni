using System;

class InstructionSet
{
    static void Main()
    {
        
        string[] codeArgs = Console.ReadLine().ToUpper().Split(' ');

        while (codeArgs[0] != "END")
        {
            var operandOne = long.Parse(codeArgs[1]);
            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        result = operandOne + 1;
                        break;
                    }
                case "DEC":
                    {
                        result = operandOne - 1;
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