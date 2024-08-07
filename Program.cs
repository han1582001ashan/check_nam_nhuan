using System;
namespace CheckLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter a year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    Console.WriteLine(year + " is a leap year");
                }
                else
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a leap year");
                    }
                    else
                    {
                        Console.WriteLine(year + " is NOT a leap year");
                    }
                }

            }
            else
            {
                Console.WriteLine(year + " is NOT a leap year");
            }

        }
    }
}