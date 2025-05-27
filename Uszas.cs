namespace verseny_menedzsment_rendszer;

internal class Uszas: Verseny
{
    public Uszas(string nev, string kategoria, int maxIndulo) 
        : base(nev, kategoria, maxIndulo)
    {
    }
    
    public void KiirUtasitas()
    {
        Console.WriteLine("A versenyzők 50 méteres úszással kezdik.");
    }
}