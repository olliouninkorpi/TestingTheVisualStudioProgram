using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtaava5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunnit;
            Console.Write("Syota sekunnit: ");
            sekunnit = int.Parse(Console.ReadLine());
            int tunti = sekunnit / 3600;
            int minuutti = sekunnit / 60 - tunti * 60;
            int sekunti = sekunnit % 60;

            Console.WriteLine("Aika: {0}h, {1}min {2}s", tunti, minuutti, sekunti);
            Console.ReadLine();
        }
    }
}
