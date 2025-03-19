namespace Zadanie3;

public class CKontener : Kontener, IHazardNotifier
{
public double temperatura; //celsjusze

public Rodzaj_produktu rodzaj_produktu;

public static Dictionary<Rodzaj_produktu, double> lista_produktow = new Dictionary<Rodzaj_produktu, double>
{
    {Rodzaj_produktu.Bananas, 13.3},
    {Rodzaj_produktu.Chocolate, 18},
    {Rodzaj_produktu.Fish, 2},
    {Rodzaj_produktu.Meat, -15},
    {Rodzaj_produktu.Ice_cream, -18},
    {Rodzaj_produktu.Frozen_pizza, -30},
    {Rodzaj_produktu.Cheese, -7.2},
    {Rodzaj_produktu.Sausage, -5},
    {Rodzaj_produktu.Butter, 20.5},
    {Rodzaj_produktu.Eggs, 19}
};


public CKontener(double height, double depth, double masa_wlasna, double max_masa, double temperatura,Rodzaj_produktu rodzaj) : base(height, depth, masa_wlasna, max_masa)
{
    this.rodzaj = Rodzaj_kontenera.C;
    this.temperatura = temperatura;
    this.rodzaj_produktu = rodzaj;
    if (temperatura > lista_produktow[rodzaj])
    {
        throw new InvalidDataException();
    }

}

public override void Zaladuj(double ladunek)
{
    Zaladuj(ladunek,rodzaj_produktu);
}

public void Zaladuj(double masa_ladunku, Rodzaj_produktu rodzaj)
{
    
    if (rodzaj != rodzaj_produktu)
    {
        throw new InvalidDataException();
    }

    if (masa_ladunku+this.masa_ladunku > max_masa)
    {
        throw new OverflowException("za duzy ladunek");
    }
    else
    {
        this.masa_ladunku += masa_ladunku;
    }
}



public void Notify()
{
    throw new OverfillException(this.getKONName());
}
}