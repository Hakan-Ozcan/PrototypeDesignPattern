using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeDesignPattern.Klonlayici;

namespace PrototypeDesignPattern.Entites
{
    public class Circle : IImageObjectCloner
    {
        public int YariCap { get; set; }

        public Circle(int yariCap)
        {
            YariCap = yariCap;
        }

        // Prototype arayüzünden uygulanan Clone metodu
        public IImageObjectCloner Klonla()
        {
            return new Circle(YariCap);
        }

        public void Ciz()
        {
            Console.WriteLine($"Daire çizildi - Yarı Çap: {YariCap}");
        }
    }
}
