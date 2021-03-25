using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği (değişkenin tipi tanımlanmalı)
            //Do not repeat yourself - Kendini takrarlama (bunun için değişken oluştur ve ona ata)
            string kategoriEtiketi = "Kategori";
            int ogrenciSayi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYamisMi = false;

            if (sistemeGirisYamisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
