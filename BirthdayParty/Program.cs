using System;
using System.Collections.Generic;
using System.Linq;

namespace purvazadchka
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());
            var plates = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedGrams = 0;

            while (guests.Any() && plates.Any())
            {
                int guest = guests.Peek();
                int plate = plates.Peek();

                if (guest > plate)
                {
                    int sum = plates.Pop() + plates.Pop();
                    plates.Push(sum);
                }
                else // guest <= plate
                {
                    wastedGrams += plate - guest;
                    guests.Pop();
                    plates.Pop();
                }
            }

            if (guests.Any())
            {
                Console.WriteLine($"Guests: " + string.Join(" ", guests));

            }
            else if (plates.Any())
            {
                Console.WriteLine($"Plates: " + string.Join(" ", plates));

            }
            Console.WriteLine($"Wasted grams of food: {wastedGrams}");
        }
    }
}