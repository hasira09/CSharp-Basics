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
                string str = "True";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch(Exception)
            {
                Console.WriteLine("this number can't convert to byte");
            }
    Console.ReadLine();


        }
    }
}