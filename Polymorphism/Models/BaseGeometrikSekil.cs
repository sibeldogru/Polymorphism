using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class BaseGeometrikSekil
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

     public virtual int AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    public void AlaniYazdir()

        {
            Console.WriteLine($"Alanı: {AlanHesapla()}");
        }
    }
}
