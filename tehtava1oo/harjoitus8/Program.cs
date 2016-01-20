using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus8
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.Write("Tervetuloa ohjelmaamme. Tulet syottamaan kolme ERI kokonaislukua. Ole hyva ja syota yksi kokonaisluku:");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Paljon kiitoksia! Ole hyva ja syota toinen kokonaisluku:");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Syota viela kolmas kokonaisluku:");
            luku3 = int.Parse(Console.ReadLine());
            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("Suurin antamasi kokonaisluku on {0}.", luku1);
            }
            else if (luku2 > luku3 && luku2 > luku1)
            {
                Console.WriteLine("Suurin antamasi kokonaisluku on {0}.", luku2);
            }
            else
            {
                Console.WriteLine("Suurin antamasi kokonaisluku on {0}.", luku3);
            }
            Console.ReadLine();
        }
    }
}
