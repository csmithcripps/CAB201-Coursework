using System;

namespace Wksheet2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter temperature in degrees Celsius : ");
            int celsius = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The equivalent temperature in degrees Fahrenheit is " +
            (celsius / 5 * 9 + 32));

        }
    }
}
