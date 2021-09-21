using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine(Grade(input));

        }

        static string Grade(double grades)
        {
            string result = string.Empty;
            if (grades >= 2.00 && grades <= 2.99)
            {
                result = "Fail";
            }
            else if (grades >= 3.00 && grades <= 3.49)
            {
                result = "Poor";
            }
            else if (grades >= 3.50 && grades <= 4.49)
            {
                result = "Good";
            }
            else if (grades >= 4.50 && grades <= 5.49)
            {
                result = "Very good";
            }
            else if (grades >= 5.50 && grades <= 6.00)
            {
                result = "Exelent";
            }

            return $"{result}";
        }
    }
}
