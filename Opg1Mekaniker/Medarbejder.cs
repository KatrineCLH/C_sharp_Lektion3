﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg1Mekaniker
{
    internal abstract class Medarbejder
    {
        private String navn;
        private String adresse;
        private const int timerPrUge = 37;
        private CprNr cprNr;
        private String medarbejdernummer;

        public Medarbejder(String navn, String adresse, CprNr cprNr, string medarbejdernummer)
        {
            this.navn = navn;
            this.adresse = adresse;
            this.cprNr = cprNr;
            this.medarbejdernummer = medarbejdernummer;
        }

        public String Navn { get { return navn; } set { navn = value; } }
        public String Adresse { get { return adresse; } set { adresse = value; } }
        public int TimerPrUge { get { return timerPrUge; } }
        public CprNr CprNr { get { return cprNr; } set { cprNr = value; } }

        public abstract int beregnUgeLon();

        public override string ToString()
        {
            return Navn + " bor på " + Adresse + " og tjener " + beregnUgeLon() + " kr. om ugen";
        }
    }
}
