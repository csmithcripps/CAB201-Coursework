using System;
using System.Reflection;

class CommandLineArguments
{
    public static void Main(string[] args)
    {   
        if (args.Length == 0)
        {
            Console.WriteLine("WARNING: No command line arguments provided.");
        }
        else if (args[0][0] != '-')
        {
            Console.WriteLine("WARNING: Parameters must be provided after options.");
        }
        else
        {
            for (int argumentNum = 0; argumentNum < args.Length; argumentNum++)
            {
                if (args[argumentNum][0] == '-')
                {
                    Console.Write(args[argumentNum]);

                    int paramPointer = argumentNum + 1;

                    if (paramPointer == args.Length)
                    {
                        paramPointer = argumentNum;
                    }

                    while (args[paramPointer][0] != '-')
                    {
                        if (paramPointer == argumentNum + 1)
                        {
                            Console.Write(": { ");
                        }
                        else
                        {
                            Console.Write(", ");
                        }
                        Console.Write(args[paramPointer]);

                        paramPointer++;
                        if (paramPointer >= args.Length) break;
                    }
                    if (paramPointer > argumentNum + 1)
                    {
                        Console.Write(" }");
                    }
                    Console.Write("\n");
                }            
            }
        }
    }
}