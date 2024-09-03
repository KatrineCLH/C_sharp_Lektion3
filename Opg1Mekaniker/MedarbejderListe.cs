using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Opg1Mekaniker
{
    internal class MedarbejderListe<TKey>
    {
        private readonly Dictionary<TKey, Medarbejder> collection
            = new Dictionary<TKey,Medarbejder>();

        /*
         * Inserts a Medarbejder p into the collection. 
         * The function must fail if the key is already occupied by some other element
        */
        public void AddElement(TKey key, Medarbejder p) 
        {
            collection.Add(key, p);
        }

        /*
         * Retrieves a Medarbejder identified by the TKey k. 
         * If not found then the function returns null.
         */
        public Medarbejder GetElement(TKey key) 
        {
            return null;
        }

        /*
         * Returns the number of elements in the collection
         */
        public int Size()
        {
            return collection.Count;
        }
    }
}
