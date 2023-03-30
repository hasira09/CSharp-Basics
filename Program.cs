using ConsoleApp1.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\C# Programs\Github to C#\C-Basics\ConsoleApp1.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " +Path.GetExtension(path));
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("FileName without Extensioin: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

            Console.ReadLine();
        }

        
           
    }
}
