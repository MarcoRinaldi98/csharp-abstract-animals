using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_abstract_animals.@abstract;
using csharp_abstract_animals.@interface;

namespace csharp_abstract_animals.@object
{
    internal class Passerotto : Animale, IVolante
    {
        // COSTRUTTORE
        public Passerotto(string nomeAnimale) : base(nomeAnimale)
        {
        }

        // METODI
        public override void CosaMangi()
        {
            Console.WriteLine($"Il {this.nomeAnimale} mangia fiocchi d'avena, noci e nocciole, uvette e frutta");
        }

        public override void Verso()
        {
            Console.WriteLine($"Il {this.nomeAnimale} cinguetta");
        }

        public void Vola()
        {
            Console.WriteLine($"{this.nomeAnimale} dice: Sto volando!!!");
        }
    }
}
