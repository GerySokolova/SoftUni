using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] line = command.Split();

                if (line[0] == "Add")
                {
                    int toAdd = int.Parse(line[1]);
                    numbers.Add(toAdd);
                }
                else if (line[0] == "Remove")
                {
                    numbers.Remove(int.Parse(line[1]));
                }
                else if (line[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(line[1]));
                }
                else if (line[0] == "Insert")
                {
                    numbers.Insert(int.Parse(line[2]), int.Parse(line[1]));
                }
                else if (line[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(line[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (line[0] == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (line[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (line[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (line[0] == "Filter")
                {
                    List<int> newNumbers = new List<int>();
                    if (line[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (int.Parse(line[2]) < numbers[i])
                            {
                                newNumbers.Add(numbers[i]);
                            }
                        }
                    }
                    else if (line[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (int.Parse(line[2]) <= numbers[i])
                            {
                                newNumbers.Add(numbers[i]);
                            }
                        }
                    }
                    else if (line[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (int.Parse(line[2]) >= numbers[i])
                            {
                                newNumbers.Add(numbers[i]);
                            }
                        }
                    }
                    else if (line[1] == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (int.Parse(line[2]) > numbers[i])
                            {
                                newNumbers.Add(numbers[i]);
                            }
                        }
                    }
                    Console.WriteLine(string.Join(" ", newNumbers));
                }
                command = Console.ReadLine();
            }
        }
    }
}
