namespace Zadanie3;







public class Kontener
{
    public static int numer = 0;
    private int num_seryjny;
    public static String kon = "KON";
    public Rodzaj_kontenera rodzaj = Rodzaj_kontenera.X;
    public double masa_ladunku { get; set; } //kg
    public double height { get; set; }  //cm
    public double masa_wlasna { get; set; } //kg samego kontenera
    public double depth { get; set; } //cm
    public double max_masa { get; set; } //kg

    public Kontener(double height, double depth, double masa_wlasna, double max_masa)
    {
        this.num_seryjny = numer++;
        this.masa_wlasna = masa_wlasna;
        this.depth = depth;
        this.max_masa = max_masa;
        this.height = height;
    } 
    
    public void Oproznij()
    {
        masa_ladunku = 0;
    }

    public virtual void Zaladuj(double masa_ladunku)
    {
        
    }

    public String getKONName()
    {
        return kon + "-" + rodzaj +"-" + num_seryjny;
    }

}