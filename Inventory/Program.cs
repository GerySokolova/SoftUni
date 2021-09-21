using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colection = Console.ReadLine()
                                            .Split(", ")
                                            .ToList();

            while (true)
            {
                string income = Console.ReadLine();

                if (income == "Craft!")
                {
                    break;
                }

                string[] line = income.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];
                string item = line[1];

                if (command == "Collect")
                {

                    if (colection.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        colection.Add(item);
                    }

                }
                else if (command == "Drop")
                {

                    if (colection.Contains(item))
                    {
                        colection.Remove(item);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Combine Items")
                {
                    string[] combine = line[1].Split(":");
                    string oldItem = combine[0];
                    string newItem = combine[1];

                    if (colection.Contains(oldItem))
                    {
                        int index = colection.IndexOf(oldItem) + 1;
                        colection.Insert(index, newItem);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Renew")
                {
                    if (colection.Contains(item))
                    {
                        colection.Remove(item);
                        colection.Add(item);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", colection));
        }
    }
}
