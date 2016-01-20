using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int summa;
            luku = 1;
            summa = 0;
            do
            {
                Console.Write("Syota luku. Voit lopettaa syottamalla 0.");
                luku = int.Parse(Console.ReadLine());
                summa = summa + luku;
            } while (luku != 0);
            Console.Write("Syottamiesi lukujen summa on {0}.", summa);
            Console.ReadLine();
        }
    }
}
