using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        //ctrl + k ctrl+ c toplu comment alma (yorum ) ctrl + k ctrl+ u toplu yorum satırını geri alıyor
        static void Main(string[] args)
        {
            //array yerine bunu kullanırız. çünkü arraylerde sonradan bişey ekleyemeyiz 
            List<string> isimler = new List<string> { "Engin", "Murat" };
            Console.WriteLine(isimler[0]);
            isimler.Add("ilker");
            Console.WriteLine(isimler[2]);

        }
    }
}
