using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1oo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;
            Console.Write("Tervetuloa ohjelmaan, ole hyva ja syota ikasi: ");
            ika = int.Parse(Console.ReadLine());
            // string line = Console.ReadLine();
            // int ika = int.Parse(line);
            if (ika < 18)
            {
                Console.WriteLine("Onnittelut, olet alaikainen.");
            } else if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("Inffo: Olet aikuinen.");
            } else
            {
                Console.WriteLine("Olet seniori-iassa.");
            }
            Console.WriteLine("Paina ENTER-nappainta lopettaaksesi.");
            Console.ReadLine();
        }
    }
}
