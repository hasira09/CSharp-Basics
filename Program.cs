using ConsoleApp1.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var name = "Hasira Mahel";

            //for (var i = 0;  i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            var numbers = new int[] { 0, 8, 2, 3, 2, 6 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();

        }
                                      
        
    }
}
