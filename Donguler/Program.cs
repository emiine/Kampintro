using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Array
            string[] kurslar = new string[] { "a", "b", "c" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
               
            }
        }
    }
}
