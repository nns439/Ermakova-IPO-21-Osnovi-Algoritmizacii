using System;

namespace task
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; // 1 - X, 2 - O

        static void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }

        static bool Win()
        {
            return
                board[0] == board[1] && board[1] == board[2] ||
                board[3] == board[4] && board[4] == board[5] ||
                board[6] == board[7] && board[7] == board[8] ||
                board[0] == board[3] && board[3] == board[6] ||
                board[1] == board[4] && board[4] == board[7] ||
                board[2] == board[5] && board[5] == board[8] ||
                board[0] == board[4] && board[4] == board[8] ||
                board[2] == board[4] && board[4] == board[6];
        }

        static bool Draw()
        {
            for (int i = 0; i < 9; i++)
                if (board[i] != 'X' && board[i] != 'O')
                    return false;
            return true;
        }

        static void Main()
        {
            while (true)
            {
                DrawBoard();
                Console.Write($"Игрок {player} ({(player == 1 ? 'X' : 'O')}), выбери клетку: ");

                int n;
                if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 9)
                    continue;

                if (board[n - 1] == 'X' || board[n - 1] == 'O')
                    continue;

                board[n - 1] = player == 1 ? 'X' : 'O';

                if (Win())
                {
                    DrawBoard();
                    Console.WriteLine($"Игрок {player} победил!");
                    break;
                }

                if (Draw())
                {
                    DrawBoard();
                    Console.WriteLine("Ничья!");
                    break;
                }

                player = player == 1 ? 2 : 1;
            }

            Console.ReadKey();
        }
    }
}