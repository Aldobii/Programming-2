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
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            yahtzeeGame.Init();

            Console.Write("Which type of Yahtzee do you want to play? Enter the number of the option.\n1: FullHouse\n2: BigStreet\n3: SmallStreet\nGame: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (input != 1 && input != 2 && input != 3)
            {
                Console.WriteLine("Invalid Number");
                Console.Write("Which type of Yahtzee do you want to play? Enter the number of the option.\n1: FullHouse\n2: BigStreet\n3: SmallStreet\nGame: ");
                input = int.Parse(Console.ReadLine());
            }

            if (input == 1)
            {
                PlayYahtzee(yahtzeeGame);
            }
            else if (input == 2)
            {
                PlayFourOfAKind(yahtzeeGame);
            }
            else
            {
                PlayThreeOfAKind(yahtzeeGame);
            }

            //end
            Console.ReadKey(true);
        }

      void PlayYahtzee(YahtzeeGame game)
        {
            int numOfAttempts = 0;

            do
            {
                game.Throw();
                game.DisplayValues();

                numOfAttempts++;
            }

            while (!game.Yahtzee());
            
            Console.WriteLine("Number of attempts need (FullHouse): {0}", numOfAttempts);
            
        }

        void PlayFourOfAKind(YahtzeeGame game)
        {
            int numOfAttempts = 0;

            do
            {
                game.Throw();
                game.DisplayValues();

                numOfAttempts++;
            }

            while (!game.FourOfAKind());

            Console.WriteLine("Number of attempts need (BigStreet): {0}", numOfAttempts);

        }

        void PlayThreeOfAKind(YahtzeeGame game)
        {
            int numOfAttempts = 0;

            do
            {
                game.Throw();
                game.DisplayValues();

                numOfAttempts++;
            }

            while (!game.ThreeOfAKind());

            Console.WriteLine("Number of attempts need (SmallStreet): {0}", numOfAttempts);

        }
    }
}
