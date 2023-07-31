using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeDesignPattern.Klonlayici;

namespace PrototypeDesignPattern.Entites
{
    public class Pencil : IImageObjectCloner
    {
        public int KalemBoyutu { get; set; }

        public Pencil(int kalemBoyutu)
        {
            KalemBoyutu = kalemBoyutu;
        }

        // Prototype arayüzünden uygulanan Clone metodu
        public IImageObjectCloner Klonla()
        {
            return new Pencil(KalemBoyutu);
        }

        public void Ciz()
        {
            Console.WriteLine($"Kalemle çizim yapıldı - Kalem Boyutu: {KalemBoyutu}");
        }
    }
}
