using ConsoleApp1.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


     
    class program
    {
       static void Main(string[] args)
        { 
            var random= new Random();
            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char) ('a' + random.Next(0,26));

            var password =  new string (buffer);
            Console.WriteLine(password);
            Console.ReadLine();
        }
        
    }
}
