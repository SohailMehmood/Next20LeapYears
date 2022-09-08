using System;

namespace Next20LeapYears
{
    public static class LeapYear
    {
        public static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Enter the year: ");
            var input = Console.ReadLine() ?? string.Empty;
            bool hasParsed = int.TryParse(input, out int number);
            if (!hasParsed)
            {
                Console.WriteLine("The entered value is not a valid year. Setting year to 0.");
            }
            int current = 0;
            while (current < 20)
            {
                int year = number + 4 - number % 4;
                if (year % 100 == 0 && year % 400 != 0)
                {
                    year += 4;
                }

                number = year;
                Console.WriteLine($"Leap Year: {year}");
                current++;

            }
        }
    }
}