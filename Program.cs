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
            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    continue;
                    //break;
                }
                Console.WriteLine(i);
            }
            System.Console.ReadLine();
        }
    }
}
