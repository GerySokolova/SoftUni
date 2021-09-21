using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Generate")
                {
                    break;
                }

                string[] lineCommand = line.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = lineCommand[0];

                if (command == "Contains")
                {
                    string substring = lineCommand[1];

                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string secondCommand = lineCommand[1];
                    int stratIndex = int.Parse(lineCommand[2]);
                    int endIndex = int.Parse(lineCommand[3]);
                    int lenght = endIndex - stratIndex;

                    if (secondCommand == "Upper")
                    {
                        string old = key.Substring(stratIndex, lenght);
                        string newKey = key.ToUpper().Substring(stratIndex, lenght);
                        key = key.Replace(old, newKey);
                        Console.WriteLine(key);
                    }
                    else
                    {
                        string old = key.Substring(stratIndex, lenght);
                        string newKey = key.ToLower().Substring(stratIndex, lenght);
                        key = key.Replace(old, newKey);
                        Console.WriteLine(key);
                    }

                }
                else if (command == "Slice")
                {
                    int stratIndex = int.Parse(lineCommand[1]);
                    int endIndex = int.Parse(lineCommand[2]);
                    int lenght = endIndex - stratIndex;

                    key = key.Remove(stratIndex, lenght);
                    Console.WriteLine(key);
                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
