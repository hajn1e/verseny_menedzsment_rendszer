namespace verseny_menedzsment_rendszer;

class Program
{
    static void Main(string[] args)
    {
        
        var kerekpar = new Kerekpar("Kerékpár Verseny", "Felnőtt", 100);
        var uszas = new Uszas("Úszó Verseny", "Gyermek", 50);
        var futas = new Futas("Futó Verseny", "Serdülő", 75);

        
        kerekpar.Versenyzok.Add(new Versenyzo("Kiss Péter", 25, "Férfi"));
        kerekpar.Versenyzok.Add(new Versenyzo("Nagy Eszter", 22, "Nő"));
        uszas.Versenyzok.Add(new Versenyzo("Tóth László", 12, "Férfi"));
        uszas.Versenyzok.Add(new Versenyzo("Nagy Anna", 15, "Nő"));
        futas.Versenyzok.Add(new Versenyzo("Szabó Gábor", 18, "Férfi"));
        futas.Versenyzok.Add(new Versenyzo("Kovács Júlia", 17, "Nő"));

        
        kerekpar.KiirUtasitas();
        uszas.KiirUtasitas();
        futas.KiirUtasitas();
        
        
        var versenyMenet = new VersenyMenet();
        versenyMenet.VersenyHozzaadasa(kerekpar);
        versenyMenet.VersenyHozzaadasa(uszas);
        versenyMenet.VersenyHozzaadasa(futas);
        versenyMenet.VersenyekListazasa();
        versenyMenet.VersenyEredmenyekKiirasa();
    }
}