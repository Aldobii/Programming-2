using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Dice
    {
        public int Value;
        static Random rnd = new Random();

        public void Throw()
        {
            Value = rnd.Next(1, 7);
        }

        public void DisplayValue()
        {
            Console.Write(Value + " ");
        }
    }
}
