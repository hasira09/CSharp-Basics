using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    public class Persons
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Persons Parse(string str) 
        {
            var person = new Persons ();
            person.Name = str;

            return person;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = Persons.Parse("Hasira");
            person.Introduce("Tharushi");

            Console.ReadLine();
        }
    }
}