using ConsoleApp1.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{

    class Program
    {
        struct Car
        {
            public string Brand;
            public string Model;
            public int Year;
            public float Price;
        }
        static void Main(string[] args)
        {
            Car car1;

            Console.Write("What is the Car Brand? ");
            car1.Brand = Console.ReadLine();

            Console.Write("What is the Car Model? ");
            car1.Model = Console.ReadLine();

            Console.Write("What is the Car Manufactured Year? ");
            car1.Year = int.Parse(Console.ReadLine());

            Console.Write("What is the Car Price? ");
            car1.Price = float.Parse(Console.ReadLine());

            Console.WriteLine("The Car Brand is {0} and the Model is {1}. The Manufactured Year of the Car is {2} and the Price is {3}.",car1.Brand, car1.Model, car1.Year, car1.Price);
            Console.ReadLine();

        }

        
           
    }
}

//Structs are Customer data Types
//As an Example - Defining a Car
// * Brand - string
// * Model - string
// * Year - int
// * Price - float
