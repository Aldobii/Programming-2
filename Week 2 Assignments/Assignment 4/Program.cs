using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Program4 = new Program();
            Program4.Start();
        }

        void Start()
        {
            //prep
            Position Knight = null;
            int[,] Chessboard = new int[8, 8];
            InitChessboard(Chessboard);

            //chess pieces
            Knight = PositionKnight(Chessboard);
            Chessboard[Knight.row, Knight.column]++;

            //display
            PossibleKnightMoves(Chessboard, Knight);
            DisplayChessboard(Chessboard);
            
            //end
            Console.ReadKey(true);
        }

        void InitChessboard(int[,] Chessboard)
        {
            for (int row = 0; row < Chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < Chessboard.GetLength(1); col++)
                {
                    Chessboard[row, col] = 0;
                }
            }
        }

        void DisplayChessboard(int[,] Chessboard)
        {
            for (int row = 0; row < Chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < Chessboard.GetLength(1); col++)
                {
                    if (Chessboard[row, col] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("* ");
                    }
                    else if (Chessboard[row, col] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }

                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }

        Position PositionKnight(int[,] Chessboard)
        {
            Position Knight = new Position();
            Random rnd = new Random();

            Knight.row = rnd.Next(0, Chessboard.GetLength(0));
            Knight.column = rnd.Next(0, Chessboard.GetLength(1));
            
            return Knight;
        }

        void PossibleKnightMoves(int[,] Chessboard, Position Knight)
        {
            int[] Moves = new int[4] { -2, -1, 1, 2};
            int PosRow, PosCol;
            bool checking;

            for (int rowMoves = 0; rowMoves < Moves.Length; rowMoves++)
            {
                for (int colMoves = 0; colMoves < Moves.Length; colMoves++)
                {
                    int Nummbr = Moves[rowMoves] * Moves[colMoves];
                    
                    if (Math.Abs(Nummbr) == 2)
                    {
                        checking = ValidMove(Chessboard, Knight, Moves[rowMoves], Moves[colMoves]);

                        if (checking == true)
                        {
                            PosRow = Knight.row + Moves[rowMoves];
                            PosCol = Knight.column + Moves[colMoves];
                            Console.WriteLine(PosRow + " " + PosCol);
                            Console.WriteLine();
                            Chessboard[PosRow, PosCol] = 2;
                        }
                    }
                }
            }
        }

        bool ValidMove(int[,] Chessboard, Position Knight, int rowMoves, int colMoves)
        {
            int PosRow = Knight.row + rowMoves;
            int PosCol = Knight.column + colMoves;

            if (PosRow >= 0 && PosRow < Chessboard.GetLength(0) && PosCol >= 0 && PosCol < Chessboard.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}
