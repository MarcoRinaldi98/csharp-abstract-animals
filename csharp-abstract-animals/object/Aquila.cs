using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_abstract_animals.@abstract;
using csharp_abstract_animals.@interface;

namespace csharp_abstract_animals.@object
{
    internal class Aquila : Animale, IVolante
    {
        // COSTRUTTORE
        public Aquila(string nomeAnimale) : base(nomeAnimale)
        {
        }

        // METODI
        public override void CosaMangi()
        {
            Console.WriteLine($"L'{nomeAnimale} piccoli e medi mammiferi");
        }

        public override void Verso()
        {
            Console.WriteLine($"L'{nomeAnimale} stridula");
        }

        public void Vola()
        {
            Console.WriteLine($"{nomeAnimale} dice: Sto volando!!!");
        }
    }
}
