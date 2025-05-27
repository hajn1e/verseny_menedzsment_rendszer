namespace verseny_menedzsment_rendszer;

internal class Versenyzo
{
    public string Nev { get; set; }
    public int Kor { get; set; }
    public string Nem { get; set; }
    public List<Eredmeny> Eredmenyek = new List<Eredmeny>();
    
    public Versenyzo(string nev, int kor, string nem)
    {
        Nev = nev;
        Kor = kor;
        Nem = nem;
    }
}