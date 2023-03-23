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
            var sentence = "My Name is Hasira Mahel Koswatta. I'm a passionate developer with experience of HTML, CSS, JavaScript, Unity, C# etc. Currently I'm an Undergraduate of SLTC Research University.";
            var summary = StringUtility.SummerizeText(sentence);
            Console.WriteLine(summary);
            Console.ReadLine();


        }

        
        
                                      
        
    }
    
}
