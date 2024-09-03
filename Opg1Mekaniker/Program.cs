using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg1Mekaniker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mekaniker> m = new List<Mekaniker>();

            Mekaniker per = new Mekaniker("Per", "Gadenavn", "2000", 200, new CprNr("123456", "7890"), "1");
            Vaerkforer lis = new Vaerkforer("Lis", "Vej", "1990", 300, "2000", 50, new CprNr("098765", "4321"), "2");
            Synsmand gitte = new Synsmand("Gitte", "Allé", "1980", 80, new CprNr("567890", "1234"), "3");

            m.Add(per);
            m.Add(lis);
            m.Add(gitte);

            foreach (Mekaniker me in m) {
                //Console.WriteLine(me.Navn + " tjener: " + me.beregnUgeLon() + " kr. om ugen");
                Console.WriteLine(me.ToString());
            }

            Console.ReadLine();
        }
    }
}
