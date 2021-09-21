using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenirs = Console.ReadLine();
            int numberSouvenirs = int.Parse(Console.ReadLine());
            double amound = 0.0;
            string output = "";

            if (team == "Argentina")
            {
                switch (souvenirs)
                {
                    case "flags":
                        amound = 3.25 * numberSouvenirs;
                        break;
                    case "caps":
                        amound = 7.20 * numberSouvenirs;
                        break;
                    case "posters":
                        amound = 5.10 * numberSouvenirs;
                        break;
                    case "stickers":
                        amound = 1.25 * numberSouvenirs;
                        break;
                }
            }
            else if (team == "Brazil")
            {
                switch (souvenirs)
                {
                    case "flags":
                        amound = 4.20 * numberSouvenirs;
                        break;
                    case "caps":
                        amound = 8.50 * numberSouvenirs;
                        break;
                    case "posters":
                        amound = 5.35 * numberSouvenirs;
                        break;
                    case "stickers":
                        amound = 1.20 * numberSouvenirs;
                        break;
                }
            }
            else if (team == "Croatia")
            {
                switch (souvenirs)
                {
                    case "flags":
                        amound = 2.75 * numberSouvenirs;
                        break;
                    case "caps":
                        amound = 6.90 * numberSouvenirs;
                        break;
                    case "posters":
                        amound = 4.95 * numberSouvenirs;
                        break;
                    case "stickers":
                        amound = 1.10 * numberSouvenirs;
                        break;
                }
            }
            else if (team == "Denmark")
            {
                switch (souvenirs)
                {
                    case "flags":
                        amound = 3.10 * numberSouvenirs;
                        break;
                    case "caps":
                        amound = 6.50 * numberSouvenirs;
                        break;
                    case "posters":
                        amound = 4.80 * numberSouvenirs;
                        break;
                    case "stickers":
                        amound = 0.90 * numberSouvenirs;
                        break;
                }
            }
            else if (team != "Argentina" && team != "Brazil" && team != "Croatia" && team != "Denmark")
            {
                Console.WriteLine("Invalid country!");

            }
            else if (souvenirs != "flags" && souvenirs != "caps" && souvenirs != "posters" && souvenirs != "stickers")
            {
                Console.WriteLine("Invalid stock!");
            }
            else
            {
                Console.WriteLine($"Pepi bought {numberSouvenirs} {souvenirs} of {team} for {amound:f2} lv.");
            }
        }
    }
}
