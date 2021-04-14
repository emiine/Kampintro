using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //içinde kredi sınıfının tanımladım çünkü tüm kredi türlerini tutuyo 
        {
            //müşteri kredi tütünü girecek o krediye göre hesaplama yapılacak
            krediManager.Hesapla();
            loggerService.Log(); //hangi servis seçilmişse logla
        }
        public void BasvuruOnBilgilendirme(List<IKrediManager> krediler) // birden fazla seneçek göndereceksem bunu kullanırım
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
