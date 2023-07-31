using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Klonlayici
{
    public interface IImageObjectCloner
    {
        IImageObjectCloner Klonla();
        void Ciz();
    }
}
