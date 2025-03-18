// See https://aka.ms/new-console-template for more information

using Zadanie3;

Kontener k = new Kontener(20, 20, 10, 10000);
LKontener l = new LKontener(20, 20, 10, 10000,true);

Console.WriteLine(k.getKONName() + "\n" + l.getKONName());