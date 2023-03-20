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
            try
            {
                var number = "1234";
                byte  b = Convert.ToByte(number);
                Console.WriteLine(number);
            }
            catch(Exception)
            {
                Console.WriteLine("this number can't convert to byte");
            }
    Console.ReadLine();


        }
    }
}