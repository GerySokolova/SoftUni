using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int totalPeople = 0;
            double finalPrice = 0;
            double ticketPrice = 5.00;
            double discount = 5.00;

            while (input != "Movie time!")
            {
                if (totalPeople <= capacity)
                {
                    int numberOfPeople = int.Parse(input);
                    totalPeople += numberOfPeople;

                    double currentSum = ticketPrice * numberOfPeople;

                    if (numberOfPeople % 3 == 0)
                    {
                        currentSum -= discount;
                    }

                    finalPrice += currentSum;

                    if (totalPeople > capacity)
                    {
                        finalPrice -= currentSum;
                        break;
                    }

                    input = Console.ReadLine();
                }
            }

            if (input == "Movie time!")
            {
                Console.WriteLine($"There are {capacity - totalPeople} seats left in the cinema.");
            }

            if (totalPeople > capacity)
            {
                Console.WriteLine("The cinema is full.");
            }

            Console.WriteLine($"Cinema income - {finalPrice} lv.");
        }
    }
}
