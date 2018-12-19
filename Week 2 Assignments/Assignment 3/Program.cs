using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Program3 = new Program();
            Program3.Start();
        }

        void Start()
        {
            //prep
            RegularCandies[,] PlayingField = new RegularCandies[12, 8];
            InitCandies(PlayingField);
            DisplayCandies(PlayingField);

            //scores
            Console.WriteLine();
            bool scoreRow = ScoreRowPresent(PlayingField);
            if (scoreRow == true)
            {
                Console.WriteLine("Row Score!");
            }
            else
            {
                Console.WriteLine("No Row Score :(");
            }

            bool scoreCol = ScoreColPresent(PlayingField);
            if (scoreCol == true)
            {
                Console.WriteLine("Column Score!");
            }
            else
            {
                Console.WriteLine("No Column Score :(");
            }

            //end
            Console.ReadKey(true);
        }

        void InitCandies(RegularCandies[,] PlayingField)
        {
            Random rnd = new Random();
            int num;

            for (int row = 0; row < PlayingField.GetLength(0); row++)
            {
                for (int col = 0; col < PlayingField.GetLength(1); col++)
                {
                    num = rnd.Next(0, 6);
                    RegularCandies Candy = (RegularCandies)num;
                    PlayingField[row, col] = Candy;
                }
            }
        }

        void DisplayCandies(RegularCandies[,] PlayingField)
        {
            for (int row = 0; row < PlayingField.GetLength(0); row++)
            {
                for (int col = 0; col < PlayingField.GetLength(1); col++)
                {
                    int number = (int)PlayingField[row, col];

                    switch (number)
                    {
                        case 0: Console.ForegroundColor = ConsoleColor.Yellow; break;
                        case 1: Console.ForegroundColor = ConsoleColor.Green; break;
                        case 2: Console.ForegroundColor = ConsoleColor.Blue; break;
                        case 3: Console.ForegroundColor = ConsoleColor.Magenta; break;
                        case 4: Console.ForegroundColor = ConsoleColor.Red; break;
                        case 5: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                    }

                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }

        bool ScoreRowPresent(RegularCandies[,] PlayingField)
        {
            int candyCounter = 1;
            int colCounter = 0;

            for (int row = 0; row < PlayingField.GetLength(0); row++)
            {
                for (int col = 1; col < PlayingField.GetLength(1); col++)
                {
                    if ((int)PlayingField[row, col] == (int)PlayingField[row, colCounter])
                    {
                        candyCounter++;
                    }
                    else
                    {
                        candyCounter = 1;
                    }
                    
                    if (candyCounter >= 4)
                    {
                        return true;
                    }

                    colCounter++;
                }

                colCounter = 0;
            }

            return false;
        }

        bool ScoreColPresent(RegularCandies[,] PlayingField)
        {
            int candyCounter = 1;
            int rowCounter = 0;

            for (int col = 0; col < PlayingField.GetLength(1); col++)
            {
                for (int row = 1; row < PlayingField.GetLength(0); row++)
                {
                    if ((int)PlayingField[row, col] == (int)PlayingField[rowCounter, col])
                    {
                        candyCounter++;
                    }
                    else
                    {
                        candyCounter = 1;
                    }

                    if (candyCounter >= 4)
                    {
                        return true;
                    }

                    rowCounter++;
                }

                rowCounter = 0;
            }

            return false;
        }
    }
}
