using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class YahtzeeGame
    {
        Dice[] dices = new Dice[5];

        public void Init()
        {
            for (int a = 0; a < dices.Length; a++)
            {
                dices[a] = new Dice();
            }
        }

        public void Throw()
        {
            Dice d6 = new Dice();

            for (int a = 0; a < dices.Length; a++)
            {
                dices[a].Throw();
            }
        }
        public void DisplayValues()
        {
            for (int a = 0; a < dices.Length; a++)
            {
                dices[a].DisplayValue();
            }

            Console.WriteLine();
        }

        public bool Yahtzee()
        {
            bool yahhee = true;

            for (int a = 0; a < 5; a++)
            {
                if (dices[0].Value != dices[a].Value)
                {
                    yahhee = false; 
                }
            }

            return yahhee;
        }

        public bool FourOfAKind()
        {
            bool yahhee = false;
            int[] number = new int[6];

            for (int a = 0; a < dices.Length; a++)
            {
                number[dices[a].Value - 1]++;
            }

            foreach (int numbers in number)
            {
                if (numbers == 4)
                {
                    yahhee = true;
                }
            }

            return yahhee;
        }

        public bool ThreeOfAKind()
        {
            bool yahhee = false;
            bool key1 = false;
            bool key2 = false;
            int[] number = new int[6];

            for (int a = 0; a < dices.Length; a++)
            {
                number[dices[a].Value - 1]++;
            }

            foreach (int numbers in number)
            {
                if (numbers == 3)
                {
                    key1 = true;
                }

                if (numbers == 2)
                {
                    key2 = true;
                }
            }

            if (key1 == true && key2 == true)
            {
                yahhee = true;
            }

            return yahhee;
        }
    }
}
