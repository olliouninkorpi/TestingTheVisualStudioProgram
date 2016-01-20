using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj7
{
    class Program
    {
        static void Main(string[] args)
        {
            double vuosi;
            Console.Write("Tervetuloa ohjelmaan. Ole hyva ja syota mika tahansa vuosiluku:");
            vuosi = double.Parse(Console.ReadLine());
            if ((vuosi % 4 == 0 && vuosi % 100 != 0) || (vuosi % 400 == 0))
            {
                Console.WriteLine("Kyseessa on karkausvuosi.");
            }
            else {
                Console.WriteLine("Kyseessa ei ole karkausvuosi.");
        }
        Console.ReadLine();
            
        }
    }
}
