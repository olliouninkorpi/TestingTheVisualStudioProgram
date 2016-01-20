using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace therealteht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Ole hyva ja syota jokin numero valilta 1-3:");
            luku = int.Parse(Console.ReadLine());
            if (luku == 1)
            {
                Console.WriteLine("Annoit numeron YKSI");
            }
            else if (luku == 2)
            {
                Console.WriteLine("Annoit numeron KAKSI");
            }
            else if (luku == 3)
            {
                Console.WriteLine("Annoit numerone KOLME");
        } 
            else
        {
        Console.WriteLine("FATAL ERROR. FILE CORRUPTED. NOT VALID.");
        }
    Console.ReadLine();
    }
}
}
