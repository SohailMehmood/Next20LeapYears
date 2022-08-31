using System;

namespace Next20LeapYears
{
    class LeapYear
    {
        static void Main(string[] args)
        {

            int year;
            Console.WriteLine("Enter the year: ");
            int number = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < 20)
            {
                year = number + 4 - number % 4;
                if (year % 100 == 0 && year % 400 != 0)
                {
                    year += 4;
                }

                number = year;
                Console.WriteLine("Leap Year: " + year);
                i++;

            }
        }
    }
}