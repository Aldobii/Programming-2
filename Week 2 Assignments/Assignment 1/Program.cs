using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Program1 = new Program();
            Program1.Start();
        }

        void Start()
        {
            int[,] Matrix = new int[8, 8];
            //InitMatrixLinear(Matrix);
            InitMatrix2D(Matrix);
            //DisplayMatrix(Matrix);
            DisplayMatrixWithCross(Matrix);

            //end
            Console.ReadKey(true);
        }

        void InitMatrix2D(int[,] Matrix)
        {
            int number = 1;

            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    Matrix[row, col] = number;
                    number++;
                }
            }
        }

        void DisplayMatrix(int[,] Matrix)
        {
            for (int col = 0; col < Matrix.GetLength(0); col++)
            {
                for (int row = 0; row < Matrix.GetLength(1); row++)
                {
                    Console.Write("{0,3} ", Matrix[col, row]);
                }
                Console.WriteLine();
            }
        }

        void InitMatrixLinear(int[,] Matrix)
        {
            int number = 1;
            int row = 0;
            int col = 0;
            int repeater = Matrix.GetLength(1) + 1;
            int checker;

            for (int a = 0; a < (Matrix.GetLength(0)*Matrix.GetLength(1)); a++)
            {
                Matrix[row, col] = number;
                number++;
                col++;

                checker = number % repeater;
                if (checker == 0)
                {
                    repeater = repeater + Matrix.GetLength(1);
                    row++;
                    col = 0;
                }
            }
        }

        void DisplayMatrixWithCross(int[,] Matrix)
        {
            int BGcolor;
            int Limit = Matrix.GetLength(1) - 1;
            for (int col = 0; col < Matrix.GetLength(0); col++)
            {
                for (int row = 0; row < Matrix.GetLength(1); row++)
                {
                    BGcolor = col + row;
                    //red foreground color
                    if (col == row)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    if (BGcolor == Limit)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    
                    Console.Write("{0,3} ", Matrix[col, row]);

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
