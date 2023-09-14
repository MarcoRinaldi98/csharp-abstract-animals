using csharp_abstract_animals.@object;
using csharp_abstract_animals.@interface;
using csharp_abstract_animals.@abstract;

Console.WriteLine("Questi sono i miei animali: ");

// dichiaro un animale per ogni tipo
Cane cane = new Cane("Cane");
Passerotto passerotto = new Passerotto("Paserotto");
Aquila aquila = new Aquila("Aquila");
Delfino delfino = new Delfino("Delfino");

// creo la mia lista animali dove inserisco gli animali precedentemente creati
List<Animale> animali = new List<Animale>();
animali.Add(cane);
animali.Add(passerotto);
animali.Add(aquila);
animali.Add(delfino);

// ciclo la lista di animali e ne visualizzo tutti i metodi creati
foreach (Animale animale in animali)
{
    Console.WriteLine($"- {animale.nomeAnimale}: ");
    animale.CosaMangi();
    animale.Verso();
    animale.Dormi();
    if (animale is INuotante nuotante)
    {
        FaiNuotare(nuotante);
    } else if (animale is IVolante volante) 
    { 
        FaiVolare(volante);
    } else
    {
        Console.WriteLine("L'animale non sta facendo nulla!");
    }
    Console.WriteLine();
}

// Metodo per far volare un animale
static void FaiVolare(IVolante animale)
{
    animale.Vola();
}
// Metodo per far nuotare un animale
static void FaiNuotare(INuotante animale)
{
    animale.Nuota();
}