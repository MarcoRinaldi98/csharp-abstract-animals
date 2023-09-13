using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.@abstract
{
    public abstract class Animale
    {
        // ATTRIBUTI
        public string nomeAnimale;

        // COSTRUTTORE
        public Animale(string nomeAnimale)
        {
            this.nomeAnimale = nomeAnimale;
        }

        // METODI
        public void Dormi()
        {
            Console.WriteLine($"{nomeAnimale} si è addormentato! Zzz Zzz Zzz");
        }
        public abstract void Verso();
        public abstract void CosaMangi();
    }
}
