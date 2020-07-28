using System;

namespace Wksheet2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string salesCode = "";
            double discount = 0.0;
            Console.Write(" Enter Sales Code : ");
            salesCode = Console.ReadLine();
            if ((salesCode != "A") && (salesCode != "B"))
            {
                discount = 0.10;
            }
            Console.WriteLine("\n Discount applied is {0:F2}\n", discount);
            Console.WriteLine(" Press enter to exit :");
            Console.ReadLine();
        }
    }
}
