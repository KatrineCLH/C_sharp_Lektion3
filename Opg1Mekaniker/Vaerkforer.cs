using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg1Mekaniker
{
    internal class Vaerkforer : Mekaniker
    {
        public String udnaevnelse;
        public int tillaeg;

        public Vaerkforer(string navn, string adresse, 
            string svendeprove, int timelon, string udnaevnelse, 
            int tillaeg) : base(navn, adresse, svendeprove, timelon)
        {
            this.udnaevnelse = udnaevnelse;
            this.tillaeg = tillaeg;
        }
    }
}
