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
            //PrintMonth(Months.November);
            PrintMonths();
            Months m = ReadMonth("Enter a month value: ");
            PrintMonth(m);
            //print all month options request
            // PrintMonths();

            //month number reader
            //  Months monthValue = ReadMonth("\nEnter a month value: ");
            //  int monthNumber = (int)monthValue;
            //if (monthValue >= Months.January && monthValue <= Months.December)
            //{
            //    Console.WriteLine("{0} => {1}", monthNumber, monthValue);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not a valid value", monthValue);
            //}
            //end
            Console.ReadKey();
        }

        void PrintMonth(Months month)
        {
            Console.WriteLine("{0} {1}",(int)month ,month);
        }
    

        void PrintMonths()
        {
            //int list = 1;
            for (Months m = Months.January; m <= Months.December; m++)
            {
                PrintMonth(m);
               
                //Console.WriteLine("{0:00}. {1}", (int)m, m);
                       //list++;
            }
        }

        Months ReadMonth(string question)
        {
            Console.Write(question);
            int monthValue = int.Parse(Console.ReadLine());

            while (!Enum.IsDefined(typeof(Months), monthValue))
            {
                Console.WriteLine("Invalid");
                Console.Write(question);
                monthValue = int.Parse(Console.ReadLine());
            }

            Months valueMonth = (Months)monthValue;
            return valueMonth;
        }
    }
}


