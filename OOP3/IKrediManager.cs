using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // I ile başlatmak interface plduğunu anlamak için
    interface IKrediManager
    {
        // metot aynı fakat içiriği farrlı olandurumlarda interface kullanıırz yani 
        //mesela tüm kredilerde hesaplama yapılacak ama farklı hesaplamalar olacak
        void Hesapla();
        void BiseyYap();
        
    }
}
