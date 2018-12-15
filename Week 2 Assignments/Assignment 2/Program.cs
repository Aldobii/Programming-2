using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Program2 = new Program();
            Program2.Start();
        }

        void Start()
        {
            //prep
            int[,] Matrix = new int[10, 10];
            int min = 1;
            int max = 100;
            Position numPosition = null;

            //matrix creation
            InitMatrixRandom(Matrix, min, max);
            DisplayMatrix(Matrix);

            //number search
            Console.Write("\nEnter a number (to search for): ");
            int number = int.Parse(Console.ReadLine());

            //number search method
            Console.Write("\nDo you want to search forwards(1) of backwards(2)?\nEnter the number: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                numPosition = SearchNumber(Matrix, number);
            }
            else if (input == 2)
            {
                numPosition = SearchNumberBackwards(Matrix, number);
            }
            else
            {
                Console.WriteLine("\nInvalid input");
            }

            //number search display
            Console.WriteLine("Number {0} is found at position [{1}, {2}]", number, numPosition.row, numPosition.column);

            //end
            Console.ReadKey(true);
        }

        void InitMatrixRandom(int[,] Matrix, int min, int max)
        {
            Random rnd = new Random();

            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    int number = rnd.Next(min, (max + 1));
                    Matrix[row, col] = number;
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

        Position SearchNumber(int[,] Matrix, int number)
        {
            Position numPosition = new Position();
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    if (number == Matrix[row, col])
                    {
                        numPosition.row = row;
                        numPosition.column = col;
                    }
                }
            }

            return numPosition;
        }

        Position SearchNumberBackwards(int[,] Matrix, int number)
        {
            Position numPosition = new Position();
            
            for (int row = Matrix.GetLength(0) - 1; row > 0; row--)
            {
                for (int col = Matrix.GetLength(1) - 1; col > 0; col--)
                {
                    if (number == Matrix[row, col])
                    {
                        numPosition.row = row;
                        numPosition.column = col;
                    }
                }
            }

            return numPosition;
        }
    }
}
