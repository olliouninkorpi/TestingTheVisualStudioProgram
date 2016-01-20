using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            double matka;
            Console.Write("Tervetuloa ohjelmamme kayttajaksi. Ole hyva ja syota autolla ajamasi matka kilometrin tarkkuudella:");
            matka = double.Parse(Console.ReadLine());
            double kulutus = matka * 0.0702;
            double hinta = matka * 1.595;
            Console.Write("Ajamaasi matkaan kului bensaa {0} litraa ja kyseinen maara bensaa maksoi {1} euroa.", kulutus, hinta);
            Console.ReadLine();
        }
    }
}
