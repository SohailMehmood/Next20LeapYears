using System;

namespace ConsoleApp6
{
    class LeapYear
    {
        static void Main(string[] args)
        {

            int n, i, year;
            Console.WriteLine("Enter the year: ");
            n = int.Parse(Console.ReadLine());
            i = 0;
            while (i < 20)
            {
                year = n + 4 - (n % 4);
                if ((year % 100 == 0) && (year % 400 != 0))
                {
                    year += 4;
                }

                n = year;
                Console.WriteLine("Leap Year: " + year);
                i++;

            }
        }
    }
}