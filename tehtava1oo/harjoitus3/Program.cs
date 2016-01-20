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
            float luku1, luku2, luku3;
            Console.Write("Tervetuloa taman laskuohjelman pariin. Ole hyva ja syota yksi kokonaisluku:");
            luku1 = float.Parse(Console.ReadLine());
            Console.Write("Luku vastaanotettu. Syota nyt toinen luku:");
            luku2 = float.Parse(Console.ReadLine());
            Console.Write("Toinen luku vastaanotettu. Syota viela kolmas luku:");
            luku3 = float.Parse(Console.ReadLine());
            Console.Write("Syottamiesi lukujen summa on ", luku1 + luku2 + luku3, "ja keskiarvo  ", Average(luku1, luku2, luku3);
        }
    }
}
