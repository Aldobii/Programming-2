using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_0
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
            int value = ReadInt("Enter a value: ");
            Console.WriteLine("You entered {0}.", value );

            int age = ReadInt("How old are you? ", 0, 120);
            Console.WriteLine("You are {0} years old.", age);

            string name = ReadString("What is your name? ");
            Console.WriteLine("Nice meeting you {0}", name);

            Console.ReadKey(true);
        }

        int ReadInt(string Question)
        {
            Console.Write(Question);
            int Answer = int.Parse(Console.ReadLine());
            return Answer;
        }

        int ReadInt(string Question, int min, int max)
        {
            Console.Write(Question);
            int Answer = int.Parse(Console.ReadLine());
            while (Answer < 0 && Answer > 120)
            {
                Console.WriteLine("Entered value is not within range (0/120)");
                Console.WriteLine("How old are you? ");
                Answer = int.Parse(Console.ReadLine());
            }

            return Answer;
        }

        string ReadString(string Question)
        {
            Console.Write(Question);
            string Answer = Console.ReadLine();
            return Answer;
        }
    }
}
