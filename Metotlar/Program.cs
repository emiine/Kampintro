using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Best Practice = doğru kullanım
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyatı = 15;
            urun2.Aciklama = "amasya elması";

            //urun array oluşturucaz
            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyatı);
            }
            Console.WriteLine("---------------------");

            // İnstance - örneğini oluşturma başka bir classtan çağırma
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
        }

    }
}
