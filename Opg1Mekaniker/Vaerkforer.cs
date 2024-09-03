using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg1Mekaniker
{
    internal class Vaerkforer : Mekaniker
    {
        private String udnaevnelse;
        private int tillaeg;

        public Vaerkforer(string navn, string adresse, 
            string svendeprove, int timelon, string udnaevnelse, 
            int tillaeg) : base(navn, adresse, svendeprove, timelon)
        {
            this.udnaevnelse = udnaevnelse;
            this.tillaeg = tillaeg;
        }

        public String Udnaevnelse { get { return udnaevnelse; } }
        public int Tillaeg { get { return tillaeg; } set { tillaeg = value; } }

        public override int beregnUgeLon()
        {
            return (Timelon + tillaeg) * TimerPrUge;
        }
    }
}
