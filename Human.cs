using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Human
    {
        public string name;
        public string surname;
        public int age;
        public string gender;
        public string nationality;

        public string getFullName()
        {
            return name + " " + surname;
        }

        public int getBirthYear()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Full Name {getFullName()}");
            Console.WriteLine($"gender: {gender}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"nationality: {nationality}");
            Console.WriteLine($"birth year: {getBirthYear()}");


        }
    }
    }
