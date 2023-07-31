using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeDesignPattern.Klonlayici;

namespace PrototypeDesignPattern.Entites
{
    public class Rectangle : IImageObjectCloner
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public Rectangle(int genislik, int yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        // Prototype arayüzünden uygulanan Clone metodu
        public IImageObjectCloner Klonla()
        {
            return new Rectangle(Genislik, Yukseklik);
        }

        public void Ciz()
        {
            Console.WriteLine($"Dikdörtgen çizildi - Genişlik: {Genislik}, Yükseklik: {Yukseklik}");
        }
    }
}
