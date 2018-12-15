using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Testing_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hecc = 0;

            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    hecc++;
                    Console.WriteLine(hecc);
                }
            }

            Console.ReadKey();
        }
    }
}
