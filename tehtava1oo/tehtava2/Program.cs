using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvosana;
            Console.WriteLine("Ole hyva ja syota oppilaan pistemaara (0-12):");
            arvosana = int.Parse(Console.ReadLine());
            if (arvosana < 2)
            {
                Console.WriteLine("Arvosana: 0");
            } else if (arvosana >= 2 && arvosana <= 3)
            {
                Console.WriteLine("Arvosana: 1");
            }
            else if (arvosana >= 4 && arvosana <= 5)
            {
                Console.WriteLine("Arvosana: 2");
            }
            else if (arvosana >= 6 && arvosana <= 7)
            {
                Console.WriteLine("Arvosana: 3");
            }
            else if (arvosana >= 8 && arvosana <= 9)
            {
                Console.WriteLine("Arvosana: 4");
            }
            else if (arvosana >= 10 && arvosana <= 12)
            {
                Console.WriteLine("Arvosana: 5");
            } else
            {
                Console.WriteLine("Syotit virheellisen pistemaaran. Ole hyva ja yrita uudestaan pistemaaralla 0-12.");
            }
            Console.ReadLine();
        }
    }
}
