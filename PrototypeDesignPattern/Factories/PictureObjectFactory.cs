using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeDesignPattern.Entites;
using PrototypeDesignPattern.Klonlayici;

namespace PrototypeDesignPattern.Factories
{
    public class PictureObjectFactory
    {
        private IImageObjectCloner dikdortgenPrototype;
        private IImageObjectCloner dairePrototype;
        private IImageObjectCloner kalemPrototype;
        private IImageObjectCloner fırçaPrototype;

        public PictureObjectFactory()
        {
            dikdortgenPrototype = new Rectangle(100, 50);
            dairePrototype = new Circle(30);
            kalemPrototype = new Pencil(1);
            fırçaPrototype = new Brush(10);
        }

        public IImageObjectCloner OlusturDikdortgen()
        {
            return dikdortgenPrototype.Klonla();
        }

        public IImageObjectCloner OlusturDaire()
        {
            return dairePrototype.Klonla();
        }

        public IImageObjectCloner OlusturKalem()
        {
            return kalemPrototype.Klonla();
        }

        public IImageObjectCloner OlusturFırça()
        {
            return fırçaPrototype.Klonla();
        }
    }
}
