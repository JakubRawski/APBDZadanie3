namespace Zadanie3;

public class Kontenerowiec
{
    public int maxilosc { get; set; }
    public Kontener[] kontener { get; set; }
    public double maxPredkosc { get; set; }
    public double maxWaga { get; set; } //t
    public int currIlosc = 0;

    public Kontenerowiec(int maxilosc, double maxPredkosc, double maxWaga)
    {
        this.maxilosc = maxilosc;
        this.maxPredkosc = maxPredkosc;
        this.maxWaga = maxWaga;
        this.kontener = new Kontener[maxilosc];
        for (int i = 0; i < kontener.Length; i++)
        {
            kontener[i] = null;
        }
    }

    public void zaladuj(Kontener kontenerr)
    {
        double currmasa = 0;
        bool flag = true;
        for (int i = 0; i < currIlosc; i++)
        {
            
                currmasa += this.kontener[i].max_masa * 0.001;
            
        }
        Console.WriteLine(currmasa+kontenerr.max_masa * 0.001);
        if (currmasa+kontenerr.max_masa * 0.001 <= this.maxWaga && currIlosc < this.maxilosc)
        {
            this.kontener[currIlosc] = kontenerr;
            Console.WriteLine("Kontener " + kontenerr.getKONName() + ": zaladowano" );
            flag = false;
            currIlosc++;
        }
        
        if (flag)
        {
            Console.WriteLine("Kontenera nie udalo sie zaladowac ");
        }
    }

    public void pokazKontenery()
    {
        Console.WriteLine("Kontenery:  ");
        for (int i = 0; i < kontener.Length; i++)
        {
            Console.WriteLine($"{i} kontener: {kontener[i].getKONName()}");
        }
    }

}