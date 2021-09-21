using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^([\$|%])(?<tag>[A-Z][a-z]{3,})(\1:\s)(\[(?<first>\d+)\]\|\[(?<second>\d+)\]\|\[(?<third>\d+)\]\|)$");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();

                Match valid = regex.Match(message);

                if (!valid.Success)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    string tag = valid.Groups["tag"].Value;
                    int first = int.Parse(valid.Groups["first"].Value);
                    int second = int.Parse(valid.Groups["second"].Value);
                    int third = int.Parse(valid.Groups["third"].Value);

                    char firstLetter = (char)first;
                    char secondLetter = (char)second;
                    char thirdLetter = (char)third;

                    StringBuilder sb = new StringBuilder();

                    sb.Append($"{tag}: ");
                    sb.Append($"{firstLetter}{secondLetter}{thirdLetter}");
                    Console.WriteLine(sb);
                }
            }
        }
    }
}
