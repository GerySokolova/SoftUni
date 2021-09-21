using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initial = Console.ReadLine()
                                          .Split("!")
                                          .ToList();

            while (true)
            {
                string incom = Console.ReadLine();

                if (incom == "Go Shopping!")
                {
                    break;
                }

                string[] order = incom.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = order[0];
                string product = order[1];

                if (command == "Urgent")
                {
                    if (Check(initial, product))
                    {
                        continue;
                    }
                    else
                    {
                        initial.Insert(0, product);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (!Check(initial, product))
                    {
                        continue;
                    }
                    else
                    {
                        initial.Remove(product);
                    }
                }
                else if (command == "Correct")
                {
                    string newProduct = order[2];

                    if (Check(initial, product))
                    {
                        int idx = initial.IndexOf(product);
                        initial.RemoveAt(idx);
                        initial.Insert(idx, newProduct);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Rearrange")
                {
                    if (Check(initial, product))
                    {
                        initial.Remove(product);
                        initial.Add(product);
                    }
                    else
                    {
                        continue;
                    }
                }

            }

            Console.WriteLine(string.Join(", ", initial));
        }

        private static bool Check(List<string> list, string product)
        {
            if (list.Contains(product))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
