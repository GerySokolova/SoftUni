using System;
using System.Linq;

namespace SurvivorMy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            int myTokens = 0;
            int oponentTokens = 0;
            string line = String.Empty;

            while ((line = Console.ReadLine()) != "Gong")
            {
                string[] data = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];
                int row = int.Parse(data[1]);
                int col = int.Parse(data[2]);
                switch (command)
                {
                    case "Find":
                        if (!CheckDimension(row, col, matrix))
                        {
                            continue;
                        }
                        if (matrix[row][col] == 'T')
                        {
                            matrix[row][col] = '-';
                            myTokens++;
                        }
                        break;
                    case "Opponent":
                        string direction = data[3];
                        if (!CheckDimension(row, col, matrix))
                        {
                            continue;
                        }
                        if (matrix[row][col] == 'T')
                        {
                            matrix[row][col] = '-';
                            oponentTokens++;
                            for (int i = 0; i < 3; i++)
                            {
                                row = MoveRow(row, direction);
                                col = MooveCol(col, direction);
                                if (!CheckDimension(row, col, matrix))
                                {
                                    continue;
                                }
                                if (matrix[row][col] == 'T')
                                {
                                    matrix[row][col] = '-';
                                    oponentTokens++;
                                }
                            }
                        }
                        break;
                }

            }
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(' ', matrix[i]));
            }
            Console.WriteLine($"Collected tokens: {myTokens}");
            Console.WriteLine($"Opponent's tokens: {oponentTokens}");
        }

        private static bool CheckDimension(int row, int col, char[][] matrix) => row >= 0 && col >= 0 && row < matrix.Length && col < matrix[row].Length;

        public static int MoveRow(int row, string moovment)
        {
            if (moovment == "up")
            {
                row--;
            }
            if (moovment == "down")
            {
                row++;
            }
            return row;
        }
        public static int MooveCol(int col, string moovment)
        {
            if (moovment == "left")
            {
                col--;
            }
            if (moovment == "right")
            {
                col++;
            }
            return col;
        }
    }
}
