using System;
using System.Linq;
using System.Collections.Generic;

namespace NexPRoblem2Azna
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = Console.ReadLine()
                                   .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                   .ToArray();

            double budget = double.Parse(Console.ReadLine());

            double startBudget = budget;

            List<double> bought = new List<double>();

            double clothesMaxPrice = 50;
            double shoesMaxPrice = 35;
            double accessoriesMaxPrice = 20.50;

            double profit = 0;
            double profitPerItem = 0;

            for (int i = 0; i < list.Length; i++)
            {
                string[] element = list[i].Split("->");
                string item = element[0];
                double itemPrice = double.Parse(element[1]);

                if (budget < itemPrice)
                {
                    break;
                }

                if (item == "Clothes")
                {

                    if (itemPrice > clothesMaxPrice)
                    {
                        continue;
                    }
                    else
                    {
                        budget -= itemPrice;
                        profitPerItem = itemPrice + (itemPrice * 0.40);
                        bought.Add(Math.Round(profitPerItem, 2));
                        profit += itemPrice * 0.40;
                    }
                }
                else if (item == "Shoes")
                {
                    if (itemPrice > shoesMaxPrice)
                    {
                        continue;
                    }
                    else
                    {
                        budget -= itemPrice;
                        profitPerItem = itemPrice + (itemPrice * 0.40);
                        bought.Add(Math.Round(profitPerItem, 2));
                        profit += itemPrice * 0.40;
                    }
                }
                else if (item == "Accessories")
                {
                    if (itemPrice > accessoriesMaxPrice)
                    {
                        continue;
                    }
                    else
                    {
                        budget -= itemPrice;
                        profitPerItem = itemPrice + (itemPrice * 0.40);
                        bought.Add(Math.Round(profitPerItem, 2));
                        profit += itemPrice * 0.40;
                    }
                }


            }
            Console.WriteLine(string.Join(" ", bought));
            Console.WriteLine($"Profit: {profit:f2}");

            if (startBudget + profit >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }

        }

    }
}
