namespace verseny_menedzsment_rendszer;

internal class Kerekpar: Verseny
{
    public Kerekpar(string nev, string kategoria, int maxIndulo) 
        : base(nev, kategoria, maxIndulo)
    {
    }

    public void KiirUtasitas()
    {
        Console.WriteLine("A versenyzők 5 kör kerékpározással kezdik.");
    }
}
