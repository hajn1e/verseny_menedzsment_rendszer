namespace verseny_menedzsment_rendszer;

internal class Futas: Verseny
{
    public Futas(string nev, string kategoria, int maxIndulo) 
        : base(nev, kategoria, maxIndulo)
    {
    }

    public void KiirUtasitas()
    {
        Console.WriteLine("A versenyzők 3 kör futással kezdik.");
    }
}