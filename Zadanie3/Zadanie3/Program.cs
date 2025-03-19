// See https://aka.ms/new-console-template for more information

using Zadanie3;

Kontener k = new Kontener(20, 20, 10, 10000);
LKontener l = new LKontener(20, 20, 10, 1000,false);
GKontener g = new GKontener(20,20, 10, 1000,15);
//CKontener cblad = new CKontener(20, 20, 10, 1000, -1, Rodzaj_produktu.Ice_cream);
CKontener c = new CKontener(20, 20, 10, 1000, -20, Rodzaj_produktu.Ice_cream);
Kontener k1 = new Kontener(20, 20, 10, 1000);

k.Zaladuj(1000);
//k.Zaladuj(10000); //przeciaza
Console.WriteLine(k.getKONName() + "\n" + l.getKONName());
//Console.WriteLine(k.get);
l.Zaladuj(100);
l.Zaladuj(450);
Console.WriteLine(l.masa_ladunku);
l.Oproznij();
Console.WriteLine(l.masa_ladunku);
l.Zaladuj(450);

g.Zaladuj(500);
Console.WriteLine(g.masa_ladunku);
g.Oproznij();
Console.WriteLine(g.masa_ladunku);
//c.Zaladuj(100,Rodzaj_produktu.Butter);
c.Zaladuj(500);
Console.WriteLine(c.masa_ladunku);
c.Oproznij();
Console.WriteLine(c.masa_ladunku);
c.Zaladuj(500,Rodzaj_produktu.Ice_cream);
Kontenerowiec kontenerowiec = new Kontenerowiec("SS Wieloryb",6, 15, 5);

kontenerowiec.zaladuj(k); //nie zadziala
kontenerowiec.zaladuj(l);
kontenerowiec.zaladuj(g);
kontenerowiec.zaladuj(c);
Kontener[] lista = { g, k1 };
kontenerowiec.zaladuj(lista);

kontenerowiec.zaladuj(k1); //za malo miejsca

kontenerowiec.pokazKontenery();

kontenerowiec.usunKontener(1);

kontenerowiec.pokazKontenery();

LKontener l1 = new LKontener(20, 20, 10, 1000,true);
l1.Zaladuj(100);
kontenerowiec.zamienKontener(1,l1);
kontenerowiec.pokazKontenery();
Kontenerowiec kontenerowiec1 = new Kontenerowiec("SS Kaszalot",6, 15, 5);
kontenerowiec1.pokazKontenery();
kontenerowiec.przeniesKontener(2,kontenerowiec1);
kontenerowiec.pokazKontenery();
kontenerowiec1.pokazKontenery();


