using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_abstract_animals.@abstract;
using csharp_abstract_animals.@interface;

namespace csharp_abstract_animals.@object
{
    internal class Cane : Animale, INuotante
    {
        // COSTRUTTORE
        public Cane(string nomeAnimale) : base(nomeAnimale)
        {
        }

        // METODI
        public override void CosaMangi()
        {
            Console.WriteLine($"Il {nomeAnimale} mangia i croccantini");
        }

        public override void Verso()
        {
            Console.WriteLine($"Il {nomeAnimale} abbaia");
        }

        public void Nuota()
        {
            Console.WriteLine($"{nomeAnimale} dice: Sto nuotando!!!");
        }
    }
}
