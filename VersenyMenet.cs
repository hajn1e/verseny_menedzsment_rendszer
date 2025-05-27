namespace verseny_menedzsment_rendszer;

internal class VersenyMenet
{
    public List<Verseny> versenyek = new List<Verseny>();

    public void VersenyHozzaadasa(Verseny verseny)
    {
        if (versenyek.Contains(verseny))
        {
            Console.WriteLine($"A verseny már létezik: {verseny.Nev}");
        }
        else
        {
            versenyek.Add(verseny);
            Console.WriteLine($"Verseny sikeresen hozzáadva: {verseny.Nev}");
        }
    }
    
    public void VersenyekListazasa()
    {
        if (versenyek.Count == 0)
        {
            Console.WriteLine("Nincsenek versenyek.");
            return;
        }

        Console.WriteLine("Versenyek listája:");
        foreach (var verseny in versenyek)
        {
            Console.WriteLine($"- {verseny.Nev} ({verseny.Kategoria}) - Max indulók: {verseny.MaxIndulo}");
        }
    }
    
    public void VersenyEredmenyekKiirasa()
    {
        if (versenyek.Count == 0)
        {
            Console.WriteLine("Nincsenek versenyek az eredmények kiírásához.");
            return;
        }

        foreach (var verseny in versenyek)
        {
            Console.WriteLine($"Eredmények a {verseny.Nev} versenyről:");
            
            foreach (var versenyzo in verseny.Versenyzok)
            {
                foreach (var eredmeny in versenyzo.Eredmenyek)
                {
                    Console.WriteLine($"- {versenyzo.Nev} ({eredmeny.Ido} másodperc)");
                }
                
            }
        }
    }
    
}