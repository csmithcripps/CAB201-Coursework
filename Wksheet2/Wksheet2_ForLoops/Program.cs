using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    static void Main(string[] args)
    {
        for (int i = 0; i <= 6; i++)
        {
            WeekDay day = (WeekDay)i;
            Console.WriteLine($"The Enum value of {day} is {(int)day}");
        }
        Console.ReadLine();
    }
}