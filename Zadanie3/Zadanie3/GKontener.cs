namespace Zadanie3;

public class GKontener : Kontener, IHazardNotifier
{
    public double cisnienie; //bary

    public GKontener(double height, double depth, double masa_wlasna, double max_masa, double cisnienie) : base(height, depth, masa_wlasna, max_masa)
    {
        this.rodzaj = Rodzaj_kontenera.G;
        this.cisnienie = cisnienie;
    }

    

    public override void Oproznij()
    {
        masa_ladunku -= masa_ladunku * 0.95;
    }

    public void Notify()
    {
        throw new OverfillException(this.getKONName());
    }
}
