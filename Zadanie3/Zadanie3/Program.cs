// See https://aka.ms/new-console-template for more information

using Zadanie3;

Kontener k = new Kontener(20, 20, 10, 10000);
LKontener l = new LKontener(20, 20, 10, 1000,false);
GKontener g = new GKontener(20,20, 10, 1000,15);
//CKontener cblad = new CKontener(20, 20, 10, 1000, -1, Rodzaj_produktu.Ice_cream);
CKontener c = new CKontener(20, 20, 10, 1000, -20, Rodzaj_produktu.Ice_cream);
Kontener k1 = new Kontener(20, 20, 10, 1000);

k.Zaladuj(1000);
//k.Zaladuj(10000); //pieciaza
Console.WriteLine(k.getKONName() + "\n" + l.getKONName());
//Console.WriteLine(k.get);

Kontenerowiec kontenerowiec = new Kontenerowiec(3, 15, 5);

kontenerowiec.zaladuj(k); //nie zadziala
kontenerowiec.zaladuj(l);
kontenerowiec.zaladuj(g);
kontenerowiec.zaladuj(c);
kontenerowiec.zaladuj(k1); //za malo miejsca

kontenerowiec.pokazKontenery();