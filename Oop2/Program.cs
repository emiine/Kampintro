using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adı = "Emine";
            musteri1.Soyadı = "Kahraman";
            musteri1.Musterino = "645";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Musterino="46546";
            musteri2.SirketAdı = "ksdj";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1); //istediğim musteriyi ekleyebilirim.
        }

    }
}
