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
            File.Copy(@"D:\csharp\Testing.png", @"E:\csharp\Testing.png", true);
            File.Delete(@"E:\csharp\Testing2.jpg");
            if (File.Exists(@"E:\csharp\Testing.png"))
            {
                Console.WriteLine("Exist");
            }

            var content = File.ReadAllText(@"E:\csharp\Testing3.docx");

            var fileInfo = new FileInfo(@"E:\csharp\Testing4.docx");
            fileInfo.CopyTo(@"D:\csharp\Testing4.docx");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("Doesn't Exists");
            }
            Console.ReadLine();
        }
           
    }
}
