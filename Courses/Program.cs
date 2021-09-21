using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentsInformation = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] infoData = line.Split(" : ");

                string course = infoData[0];
                string studentName = infoData[1];

                if (studentsInformation.ContainsKey(course))
                {
                    studentsInformation[course].Add(studentName);
                }
                else
                {
                    studentsInformation.Add(course, new List<string> { studentName });
                }
            }

            foreach (var kvp in studentsInformation
                .OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var elements in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {elements}");
                }

            }


        }
    }
}
