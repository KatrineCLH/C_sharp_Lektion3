using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg1Mekaniker
{
    internal class Mekaniker : Medarbejder
    {
        private String svendeprove;
        private int timelon;

        public Mekaniker(String navn, String adresse, 
            String svendeprove, int timelon, CprNr cprNr, String medarbejdernummer) : base(navn, adresse, cprNr, medarbejdernummer) 
        {
            this.svendeprove = svendeprove;
            this.timelon = timelon;
        }

        public String Svendeprove {  get { return svendeprove; } set { svendeprove = value; } }
        public int Timelon { get { return timelon; } set { timelon = value; } }

        public override int beregnUgeLon()
        {
            return TimerPrUge * timelon;
        }
    }
}
