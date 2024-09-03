using System;
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

        public Medarbejder(String navn, String adresse) 
        {
            this.navn = navn;
            this.adresse = adresse;
        }

        public String Navn { get { return navn; } set { navn = value; } }
        public String Adresse { get { return adresse; } set { adresse = value; } }
    }
}
