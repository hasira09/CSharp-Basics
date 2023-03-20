using ConsoleApp1.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public enum AirLines
    {
        SriLankan = 1,
        Emirates = 2,
        Quartar = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = AirLines.SriLankan;
            Console.WriteLine((int)method);

            var methoID = 2;
            Console.WriteLine((AirLines)methoID);

            Console.WriteLine(method.ToString());

            var methodName = "Airways";
            var airWayMethod = (AirLines) Enum.Parse(typeof (AirLines), methodName);
            Console.WriteLine(airWayMethod);

            Console.ReadLine();

        }
                                      
        
    }
}
