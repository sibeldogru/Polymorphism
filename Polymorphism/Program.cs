
using Polymorphism.Models;

Kare kare = new Kare
{
    Genislik = 5,
    Yukseklik = 5,
};

Console.WriteLine("Kare için: ");
kare.AlaniYazdir();
Console.WriteLine("--------------------");

Dikdortgen dikdortgen = new Dikdortgen
{
    Genislik = 7,
    Yukseklik = 4,
};


Console.WriteLine("Dikdörtgen için: ");
dikdortgen.AlaniYazdir();
Console.WriteLine("--------------------");

DikUcgen dikucgen = new DikUcgen

{
    Genislik = 5,
    Yukseklik = 9,
};

Console.WriteLine("DikÜçgen için: ");
dikucgen.AlaniYazdir();
