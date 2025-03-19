namespace Zadanie3;

public class Kontenerowiec
{
    public string nazwa {get; set;}
    public int maxilosc { get; set; }
    public Kontener[] kontener { get; set; }
    public double maxPredkosc { get; set; }
    public double maxWaga { get; set; } //t
    public int currIlosc = 0;

    public Kontenerowiec(string nazwa,int maxilosc, double maxPredkosc, double maxWaga)
    {
        this.nazwa = nazwa;
        this.maxilosc = maxilosc;
        this.maxPredkosc = maxPredkosc;
        this.maxWaga = maxWaga;
        this.kontener = new Kontener[maxilosc];
        for (int i = 0; i < currIlosc; i++)
        {
            kontener[i] = null;
        }
    }

    public void przeniesKontener(int i, Kontenerowiec kontenerowiec)
    {
        if (kontenerowiec.currIlosc != kontenerowiec.maxilosc)
        {
            Kontener k = this.kontener[i];
            kontenerowiec.zaladuj(k);
            this.usunKontener(i);
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
        //Console.WriteLine(currmasa+kontenerr.max_masa * 0.001);
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
    public void zaladuj(Kontener[] konteners)
    {
        double currmasa = 0;
        double currmasas = 0;
        bool flag = true;
        for (int i = 0; i < currIlosc; i++)
        {
            
            currmasa += this.kontener[i].max_masa * 0.001;
            
        }
        for (int i = 0; i < konteners.Length; i++)
        {
            
            currmasas += this.kontener[i].max_masa * 0.001;
            
        }
        //Console.WriteLine(currmasa+kontenerr.max_masa * 0.001);
        if (currmasa+currmasas <= this.maxWaga && currIlosc+konteners.Length < this.maxilosc)
        {
            for (int i = 0; i < konteners.Length; i++)
            {
                this.kontener[currIlosc] = konteners[i];
                Console.WriteLine("Kontener " + konteners[i].getKONName() + ": zaladowano" );
                flag = false;
                currIlosc++;
            }

            
        }
        
        if (flag)
        {
            Console.WriteLine("Listy kontenerow nie udalo sie zaladowac ");
        }
    }
    public void usunKontener(int index)
    {
        if (index < currIlosc)
        {
         
            Kontener kontenerr = this.kontener[currIlosc-1];
            this.kontener[index] = kontenerr;
            currIlosc--;
        }
    }
    public void zamienKontener(int index, Kontener newKontenerr)
    {
        if (index < maxilosc)
        {
            this.kontener[index] = newKontenerr;
        }
    }

    public void pokazKontenery()
    {
        Console.WriteLine($"{nazwa} zawiera kontenery:  ");
        for (int i = 0; i < currIlosc; i++)
        {
            Console.WriteLine($"{i} kontener: {kontener[i].getKONName()}");
        }
    }

}