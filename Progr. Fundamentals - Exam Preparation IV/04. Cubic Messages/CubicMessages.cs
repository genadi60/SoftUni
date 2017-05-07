using System;
using System.Collections.Generic;

class CubicMessages
{
    static void Main()
    {
        string encriptedMessage = Console.ReadLine();
        
        while (!encriptedMessage.Equals("Over!"))
        {
            int lengthMessage = int.Parse(Console.ReadLine());
            char[] message = new char[lengthMessage];
            List<int> verifCode = new List<int> { };
            int count = 0;
            bool legallCode = true;
            foreach (char a in encriptedMessage)
            {
                
                if (a >= '0' && a <= '9' && count == 0)
                {
                    verifCode.Add(a - '0');
                }
                else
                {
                    if ((a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z') && count < lengthMessage)
                    {
                        message[count] = a;
                        count++;
                    }
                    else
                    {
                        if (count != lengthMessage)
                        {
                            legallCode = false;
                            break;
                        }
                        else
                        {
                            if (a >= 'a' && a <= 'z' || a >= 'A' && a <= 'Z')
                            {
                                legallCode = false;
                                break;
                            }
                            else
                            {
                                verifCode.Add(a - '0');
                            }
                        }
                    }
                }
            }
            if (legallCode)
            {
                string messageText = string.Empty;
                for (int i = 0; i < message.Length; i++)
                {
                    messageText = messageText + message[i];
                }
                string verifCodeText = string.Empty;
                for (int i = 0; i < verifCode.Count; i++)
                {
                    if (verifCode[i] >= 0 && verifCode[i] < message.Length)
                    {
                        verifCodeText = verifCodeText + message[verifCode[i]];
                    }
                    else
                    {
                        verifCodeText = verifCodeText + " ";
                    }
                }
                Console.WriteLine($"{messageText} == {verifCodeText}");
            }
            encriptedMessage = Console.ReadLine();
        }
    }
}