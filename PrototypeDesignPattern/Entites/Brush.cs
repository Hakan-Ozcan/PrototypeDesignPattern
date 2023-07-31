using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeDesignPattern.Klonlayici;

namespace PrototypeDesignPattern.Entites
{
    // Fırça sınıfı - Prototype arayüzünden türetiliyor
    public class Brush : IImageObjectCloner
    {
        public int FırçaBoyutu { get; set; }

        public Brush(int fırçaBoyutu)
        {
            FırçaBoyutu = fırçaBoyutu;
        }

        // Prototype arayüzünden uygulanan Clone metodu
        public IImageObjectCloner Klonla()
        {
            return new Brush(FırçaBoyutu);
        }

        public void Ciz()
        {
            Console.WriteLine($"Fırça ile çizim yapıldı - Fırça Boyutu: {FırçaBoyutu}");
        }
    }
}
