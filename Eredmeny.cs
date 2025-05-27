namespace verseny_menedzsment_rendszer;

internal class Eredmeny
{
    public int VersenyNev{ get; set; }
    public TimeSpan Ido { get; set; }
    public int Helyezes { get; set; }
    
    public Eredmeny(int versenyNev, TimeSpan ido, int helyezes)
    {
        VersenyNev = versenyNev;
        Ido = ido;
        Helyezes = helyezes;
    }
}