using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Cane : Animale
    {
        public Cane(string nomeAnimale) : base(nomeAnimale)
        {
        }

        public override void CosaMangi()
        {
            Console.WriteLine($"Il {this.nomeAnimale} mangia i croccantini");
        }

        public override void Verso()
        {
            Console.WriteLine($"Il {this.nomeAnimale} abbaia");
        }
    }
}
