using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Aquila : Animale
    {
        public Aquila(string nomeAnimale) : base(nomeAnimale)
        {
        }

        public override void CosaMangi()
        {
            Console.WriteLine($"L'{this.nomeAnimale} piccoli e medi mammiferi");
        }

        public override void Verso()
        {
            Console.WriteLine($"L'{this.nomeAnimale} stridula");
        }
    }
}
