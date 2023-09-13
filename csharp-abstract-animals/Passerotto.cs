using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Passerotto : Animale
    {
        public Passerotto(string nomeAnimale) : base(nomeAnimale)
        {
        }

        public override void CosaMangi()
        {
            Console.WriteLine($"Il {this.nomeAnimale} mangia fiocchi d'avena, noci e nocciole, uvette e frutta");
        }

        public override void Verso()
        {
            Console.WriteLine($"Il {this.nomeAnimale} cinguetta");
        }
    }
}
