using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg1Mekaniker
{
    internal class Synsmand : Mekaniker
    {
        private int antalSyn;
        private int ugeLon;

        public Synsmand(string navn, string adresse, 
            string svendeprove, int antalSyn, CprNr cprNr, 
            String medarbejdernummer) : base(navn, adresse, svendeprove, cprNr, medarbejdernummer) 
        {
            this.antalSyn = antalSyn;
            this.ugeLon = antalSyn * 290;
        }

        public int AntalSyn { get { return antalSyn; } set { antalSyn = value; } }
        public int UgeLon { get { return ugeLon; } }

        public override int beregnUgeLon()
        {
            return ugeLon;
        }
    }
}
