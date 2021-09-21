using System;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedName = Console.ReadLine();

            while (true)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = data[0];

                if (command == "Sign")
                {
                    break;
                }

                if (command == "Case")
                {
                    string type = data[1];
                    if (type == "lower")
                    {
                        wantedName = wantedName.ToLower();
                    }
                    else
                    {
                        wantedName = wantedName.ToUpper();
                    }
                    Console.WriteLine(wantedName);
                }
                else if (command == "Reverse")
                {
                    int startIdx = int.Parse(data[1]);
                    int endIdx = int.Parse(data[2]);

                    if (startIdx < 0 || endIdx > wantedName.Length)
                    {
                        continue;
                    }
                    else
                    {
                        int len = endIdx - startIdx + 1;
                        string substring = wantedName.Substring(startIdx, len);
                        string reversed = String.Empty;

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversed += substring[i];
                        }

                        Console.WriteLine(reversed);

                    }
                }
                else if (command == "Cut")
                {
                    string substring = data[1];

                    if (wantedName.Contains(substring))
                    {
                        int start = wantedName.IndexOf(substring);

                        wantedName = wantedName.Remove(start, substring.Length);

                        Console.WriteLine(wantedName);
                    }
                    else
                    {
                        Console.WriteLine($"The word {wantedName} doesn't contain {substring}.");
                    }
                }
                else if (command == "Replace")
                {
                    char sign = char.Parse(data[1]);

                    wantedName = wantedName.Replace(sign, '*');

                    Console.WriteLine(wantedName);
                }
                else if (command == "Check")
                {
                    char sign = char.Parse(data[1]);

                    if (wantedName.Contains(sign))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {sign}.");
                    }
                }
            }
        }
    }
}