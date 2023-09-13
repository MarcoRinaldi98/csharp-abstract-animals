using csharp_abstract_animals;

Cane cane = new Cane("Cane");
Passerotto passerotto = new Passerotto("Paserotto");
Aquila aquila = new Aquila("Aquila");
Delfino delfino = new Delfino("Delfino");

List<Animale> animali = new List<Animale>();
animali.Add(cane);
animali.Add(passerotto);
animali.Add(aquila);
animali.Add(delfino);

foreach (Animale animale in animali)
{
    Console.WriteLine($"- {animale.nomeAnimale}: ");
    animale.CosaMangi();
    animale.Verso();
    animale.Dormi();
    Console.WriteLine();
}
