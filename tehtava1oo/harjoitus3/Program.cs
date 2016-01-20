using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            double luku1, luku2, luku3;
            Console.Write("Tervetuloa taman laskuohjelman pariin. Ole hyva ja syota yksi kokonaisluku:");
            luku1 = double.Parse(Console.ReadLine());
            Console.Write("Luku vastaanotettu. Syota nyt toinen luku:");
            luku2 = double.Parse(Console.ReadLine());
            Console.Write("Toinen luku vastaanotettu. Syota viela kolmas luku:");
            luku3 = double.Parse(Console.ReadLine());
            double summa = luku1 + luku2 + luku3;
            double keskiarvo = (luku1 + luku2 + luku3) / 3;
            Console.Write("Syottamiesi lukujen summa on {0} ja keskiarvo {1}.", summa, keskiarvo);
            Console.ReadLine();
        }
    }
}
