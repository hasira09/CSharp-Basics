using System;
using ConsoleApp1.Maths;

namespace ConsoleApp1
{
    class Program
    {
        public enum Planets
        {
            Mercury = 1,
            Venus,
            Earth,
            Mars,
            Jupyter,
            Saturn,
            Uranus,
            Neptune,
            Pluto
        }

        public enum PlanetsRadius
        {
            Mercury = 2439,
            Venus = 6051,
            Earth = 6371,
            Mars = 3389,
            Jupyter = 69911,
            Saturn = 58232,
            Uranus = 25362,
            Neptune = 24622,
            Pluto = 1188
        }

        public static double Volume(PlanetsRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }

        static void Main(string[] args)
        {
            String name = PlanetsRadius.Earth.ToString();
            int radius = (int)PlanetsRadius.Earth;
            double volume = Volume(PlanetsRadius.Earth);

            Console.WriteLine("Planet: " + name);
            Console.WriteLine("Radius: " + radius + "km");
            Console.WriteLine("Volume: " + volume + "km^3");

            Console.ReadLine();
        }
    }
}

//Enums are special "class" that contains a set of named integer constants.
//Enums can be used when you have values that you know will not change.
//To get the integer value from an item, you must explicitly convert to an int.

//  name = integer
