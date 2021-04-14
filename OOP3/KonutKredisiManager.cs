using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interfaceden türettiysem ordaki tüm metotları kullanmak zorundayım
    class KonutKredisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("konut kredisi hesaplandı.");
        }
    }
}
