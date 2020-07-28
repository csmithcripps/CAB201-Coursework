using System;
using System.ComponentModel;

namespace Wksheet2_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 InputInt = -1;

            while(InputInt == -1)
            {
                Console.WriteLine("Enter a positive integer");
                string InputString = Console.ReadLine();

                bool isParsable = Int32.TryParse(InputString, out InputInt);
                if (InputInt < 0 || !isParsable)
                {
                    InputInt = -1;
                    Console.WriteLine("INVALID INPUT (Be Better)");
                    continue;
                }
            }
            Console.WriteLine("That's a positive number GOOD JOBBBB");
            if (InputInt%2 == 0)
            {
                Console.WriteLine($"{InputInt} is Even");
            }
            else
            {
                Console.WriteLine($"{InputInt} is Odd");
            }

            double sqrtInput = Math.Sqrt((double)InputInt);
            if (sqrtInput%1 == 0)
            {
                Console.WriteLine($"{InputInt} is Square");
            }

            double triangular = Math.Sqrt((double)(8*InputInt+1));
            if (triangular % 1 == 0)
            {
                Console.WriteLine($"{InputInt} is Triangular");
            }

            if (InputInt == 0 || InputInt == 1)
            {
                Console.WriteLine(InputInt + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= InputInt / 2; a++)
                {
                    if (InputInt % a == 0)
                    {
                        Console.WriteLine(InputInt + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(InputInt + " is a prime number");
                Console.ReadLine();
            }

        }
    }
}

