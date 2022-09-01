using System;

namespace Next20LeapYears
{
    public static class LeapYear
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Enter the year: ");
            int number = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < 20)
            {
                int year = number + 4 - number % 4;
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