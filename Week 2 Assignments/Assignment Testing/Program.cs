using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Program0 = new Program();
            Program0.Start();
        }

        void Start()
        {
            int[,] matrix = new int[8, 10];
            Random rnd = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int number = rnd.Next(1, matrix.Length + 1);
                    matrix[row, col] = number;
                    Console.Write("{0,3} ", number);

                    if (number == (row * 10 + col + 1))
                        break;
                }
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
