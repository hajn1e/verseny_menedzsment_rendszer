namespace verseny_menedzsment_rendszer;

internal class Verseny
{
    public string Nev { get; set; }
    public string Kategoria { get; set; }
    public int MaxIndulo { get; set; }
    public List<Versenyzo> Versenyzok { get; set; } = new List<Versenyzo>();
    
    public Verseny(string nev, string kategoria, int maxIndulo)
    {
        Nev = nev;
        Kategoria = kategoria;
        MaxIndulo = maxIndulo;
    }
    public void HozzaadVersenyzo(Versenyzo versenyzo)
    {
        if (Versenyzok.Count < MaxIndulo)
        {
            Versenyzok.Add(versenyzo);
            Console.WriteLine($"{versenyzo.Nev} hozzáadva a {Nev} versenyhez.");
        }
        else
        {
            Console.WriteLine("A verseny tele van, nem lehet új indulót hozzáadni.");
        }
    }
}