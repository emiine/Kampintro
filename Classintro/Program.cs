using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //kurs clasını oluşturduktan sonra kurs adında değişken tanımlayabilirim
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Emine Kahraman";
            kurs1.İzlenmeOrani = "68";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Sare Kahrama";
            kurs2.İzlenmeOrani = "88";

            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string İzlenmeOrani { get; set; }
    }

}