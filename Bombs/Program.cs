using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffect = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> bombCasing = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int datura = 40;
            int cherry = 60;
            int smoke = 120;
            SortedDictionary<string, int> createdBobms = new SortedDictionary<string, int>();
            createdBobms.Add("Cherry Bombs", 0);
            createdBobms.Add("Datura Bombs", 0);
            createdBobms.Add("Smoke Decoy Bombs", 0);
            bool isCreated = false;
            while (bombEffect.Count > 0 && bombCasing.Count > 0)
            {
                if (createdBobms["Cherry Bombs"] >= 3 && createdBobms["Datura Bombs"] >= 3 && createdBobms["Smoke Decoy Bombs"] >= 3)
                {
                    isCreated = true;
                    break;
                }
                int sumElements = bombEffect.Peek() + bombCasing.Peek();
                GetElementForAdd(sumElements, datura, cherry, smoke, createdBobms, bombEffect, bombCasing);

            }
            if (isCreated)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (bombEffect.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
            }
            if (bombCasing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            foreach (var item in createdBobms)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void GetElementForAdd(int sumElements, int datura, int cherry, int smoke,
            SortedDictionary<string, int> createdBobms, Queue<int> bombEffect, Stack<int> bombCasing)
        {
            if (sumElements == datura)
            {
                createdBobms["Datura Bombs"]++;
                bombEffect.Dequeue();
                bombCasing.Pop();
            }
            else if (sumElements == cherry)
            {
                createdBobms["Cherry Bombs"]++;
                bombEffect.Dequeue();
                bombCasing.Pop();
            }
            else if (sumElements == smoke)
            {
                createdBobms["Smoke Decoy Bombs"]++;
                bombEffect.Dequeue();
                bombCasing.Pop();
            }
            else
            {
                bombCasing.Push(bombCasing.Pop() - 5);
            }
        }
    }
}
