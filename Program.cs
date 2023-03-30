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
        public static void Main(string[] args)
        {
            Directory.CreateDirectory(@"D:\csharp\testfolder1");

            //var files = Directory.GetFiles(@"D:\C# Programs\Github to C#\C-Basics", "*.sln*", SearchOption.AllDirectories);
            //foreach (var file in files)
            //    Console.WriteLine(file);

            //var directories = Directory.GetDirectories(@"D:\C# Programs\Github to C#\C-Basics", "*.*", SearchOption.AllDirectories);
            //foreach (var directory in directories)
            //    Console.WriteLine(directory);

            Directory.Exists(@"D:\csharp\testfolder1");

            var directoryInfo = new DirectoryInfo(@"D:\csharp\testfolder1");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            Console.ReadLine();
        }

        
           
    }
}
