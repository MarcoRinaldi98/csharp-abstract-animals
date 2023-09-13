using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Delfino : Animale
    {
        public Delfino(string nomeAnimale) : base(nomeAnimale)
        {
        }

        public override void CosaMangi()
        {
            Console.WriteLine($"Il {this.nomeAnimale} mangia pesce, crostacei e calamari");
        }

        public override void Verso()
        {
            Console.WriteLine($"Il {this.nomeAnimale} fischia");
        }
    }
}
