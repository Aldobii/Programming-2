using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadKey(true);
        }

        void Start()
        {
            int year = 2000;
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }

        bool IsLeapYear(int year)
        {
            if (year < 0) return false;

            bool deelDoor400 = ((year % 400) == 0);
            bool deelDoor100 = ((year % 100) == 0);
            bool deelDoor4 = ((year % 4) == 0);

            return (deelDoor400 || (deelDoor4 && !deelDoor100));
        }
    }
}
