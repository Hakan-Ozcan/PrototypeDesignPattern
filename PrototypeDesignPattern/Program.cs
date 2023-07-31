using PrototypeDesignPattern.Factories;
using PrototypeDesignPattern.Klonlayici;

class Program
{
    static void Main(string[] args)
    {
        PictureObjectFactory fabrika = new PictureObjectFactory();

        // Klonlanmış dikdörtgen oluşturma
        IImageObjectCloner dikdortgen1 = fabrika.OlusturDikdortgen();
        dikdortgen1.Ciz();

        // Klonlanmış daire oluşturma
        IImageObjectCloner daire1 = fabrika.OlusturDaire();
        daire1.Ciz();

        // Klonlanmış kalem oluşturma
        IImageObjectCloner kalem1 = fabrika.OlusturKalem();
        kalem1.Ciz();

        // Klonlanmış fırça oluşturma
        IImageObjectCloner fırça1 = fabrika.OlusturFırça();
        fırça1.Ciz();
    }
}