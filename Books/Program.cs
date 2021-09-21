using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelf = Console.ReadLine()
                .Split("&")
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }

                string[] parts = input.Split(" | ");
                string command = parts[0];
                string book = parts[1];


                if (command == "Add Book")
                {
                    if (shelf.Contains(book))
                    {
                        continue;
                    }
                    else
                    {
                        shelf.Insert(0, book);
                    }

                }
                else if (command == "Take Book")
                {
                    if (shelf.Contains(book))
                    {
                        shelf.Remove(book);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Swap Books")
                {
                    string secondBook = parts[2];

                    if (shelf.Contains(book) && shelf.Contains(secondBook))
                    {

                        int book1 = shelf.IndexOf(book);
                        int book2 = shelf.IndexOf(secondBook);

                        string temp = shelf[book1];
                        shelf[book1] = shelf[book2];
                        shelf[book2] = temp;

                    }


                }
                else if (command == "Insert Book")
                {
                    shelf.Add(book);
                }
                else if (command == "Check Book")
                {

                    int idx = int.Parse(parts[1]);

                    if (idx < 0 || idx > shelf.Count - 1)
                    {
                        continue;
                    }
                    else
                    {
                        book = shelf[idx];
                        Console.WriteLine(book);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", shelf));
        }

    }
}