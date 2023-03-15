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
            /*
            //While Loop
            int i = 0, j = 1;

            while (i <= 5) {
                Console.WriteLine("i={0}", i);
                i++;

                while (j <= 2)
                {
                    Console.WriteLine("j = {0}", j);
                    j++;
                }

            }
            

            //Do While Loop
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = i;

                i++;

                do
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                } while (j < 2);
            } while (i < 2);
            */

            //For Loop
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("for Loop in C# is {0}", i);
            }

            System.Console.ReadLine();
        }
    }
}
