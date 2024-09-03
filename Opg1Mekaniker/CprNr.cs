using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg1Mekaniker
{
    internal class CprNr
    {
        private String birthDate;
        private String sequenceNumber;
        public CprNr(String bDate, String sNumber)
        {
            BirthDate = bDate;
            SequenceNumber = sNumber;
        }
        public String BirthDate { get; set; }
        public String SequenceNumber { get; set; }
    }
}
