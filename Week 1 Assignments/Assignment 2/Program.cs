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
            Persons[] Personas = new Persons[3];

            //reading personas
            for (int a = 0; a < Personas.Length; a++)
            {
                Personas[a] = ReadPerson();
                Console.WriteLine();
            }

            //printing personas
            for (int b = 0; b < Personas.Length; b++)
            {
                PrintPerson(Personas[b]);
            }

            //asking for birthday celebration
            Console.Write("Which person do you want to celebrate his/her birthday? Enter a number (1, 2, 3): ");
            int numPersona = int.Parse(Console.ReadLine());
            numPersona--;
            CelebrateBirthday(Personas[numPersona].Age, Personas[numPersona].FirstName);

            //end
            Console.ReadKey(true);
        }

        Persons ReadPerson()
        {
            Persons Person;
            Person.FirstName = ReadString("Enter first name: ");
            Person.LastName = ReadString("Enter last name: ");
            Person.Age = ReadInt("Enter age: ");
            Person.City = ReadString("Enter city: ");
            Person.Gender = ReadGender("Enter gender (m/f): ");
            return Person;
        }

        void PrintPerson(Persons PP)
        {
            
            Console.WriteLine("{0} {1} ({4})\n{2} years old, {3}\n", PP.FirstName, PP.LastName, PP.Age, PP.City, PP.Gender);
        }

        string ReadString(string question)
        {
            Console.Write(question);
            string Strung = Console.ReadLine();
            return Strung;
        }

        int ReadInt(string question)
        {
            Console.Write(question);
            int Ant = int.Parse(Console.ReadLine());
            return Ant;
        }

        GenderType ReadGender(string question)
        {
            Console.Write(question);
            GenderType gender;
            string input = Console.ReadLine();
            if (input == "m")
            {
                gender = GenderType.m;
            }
            else
            {
                gender = GenderType.f;
            }

            return gender;
        }

        void CelebrateBirthday(int numPersona, string Name)
        {
            numPersona++;
            Console.WriteLine("\nHappy Birthday {0}!!! You're {1} years old now!", Name, numPersona);
        }

        //Persons ReadPerson()
        //{
        //        string FirstName = readFirstName("Enter first name: ");
        //        Persons.FirstName = FirstName;
        //        string LastName = readLastName("Enter last name: ");
        //        Persons.LastName = LastName;
        //        int Age = readAge("Enter age: ");
        //        Persons.Age = Age;
        //        string City = readCity("Enter city: ");
        //        Persons.City = City;
        //    return Persons;
        //}

        //string readFirstName(string question)
        //{
        //    Console.Write(question);
        //    string FirstName = Console.ReadLine();
        //    return FirstName;
        //}

        //string readLastName(string question)
        //{
        //    Console.Write(question);
        //    string LastName = Console.ReadLine();
        //    return LastName;
        //}

        //int readAge(string question)
        //{
        //    Console.Write(question);
        //    int Age = int.Parse(Console.ReadLine());
        //    return Age;
        //}

        //string readCity(string question)
        //{
        //    Console.Write(question);
        //    string City = Console.ReadLine();
        //    return City;
        //}
    }
}
