using System.Transactions;

namespace Zadanie3;

public class LKontener : Kontener, IHazardNotifier
{
    public bool czybezpieczne;

    public LKontener(double height, double depth, double masa_wlasna, double max_masa, bool czybezpieczne) : base(height, depth, masa_wlasna, max_masa)
    {
        this.rodzaj = Rodzaj_kontenera.L;
        this.czybezpieczne = czybezpieczne;
    }

    public override void Zaladuj(double masa_ladunku)
    {
        double check_masa = czybezpieczne? max_masa * 0.9 : max_masa * 0.5;
        //Console.WriteLine(check_masa);
        if (this.masa_ladunku + masa_ladunku >= check_masa)
        {
            Notify();
        }
        else if (masa_ladunku+this.masa_ladunku >= max_masa)
        {
            throw new OverflowException();
        }
        this.masa_ladunku += masa_ladunku;
    }

    public void Notify()
    {
        Console.WriteLine($"Dla : {(czybezpieczne? "bezpieczne": "niebezpieczne")} nie zalecamy tak duzo");
    }
}