using System;
using System.Text.RegularExpressions;

namespace MinesOgString
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"<(?<first>[A-Za-z])(?<second>[A-Za-z])>");

            string text = Console.ReadLine();

            MatchCollection bomb = regex.Matches(text);

            foreach (Match item in bomb)
            {
                int idx = item.Index;

                char firstLt = char.Parse(item.Groups["first"].Value);
                char secondLt = char.Parse(item.Groups["second"].Value);

                int bombPower = Math.Abs(firstLt - secondLt);



                int startIndex = idx - bombPower;

                int lenght = bombPower * 2 + 4;

                if (startIndex <= 0)
                {
                    startIndex = 0;

                    lenght = lenght / 2 + idx + 2;
                }

                if (startIndex + lenght >= text.Length)
                {
                    lenght = text.Length - startIndex;
                }

                string substr = text.Substring(startIndex, lenght);

                string newSubstr = new string('_', substr.Length);

                text = text.Replace(substr, newSubstr);
            }

            Console.WriteLine(text);
        }
    }
}
