using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            KonutKredisiManager konutKredisiManager = new KonutKredisiManager();
            IKrediManager tasıtKredisiManager = new TasıtKredisiManager(); //Ikredimanager diyee olur tasıtKredisiManager diyede olur.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService filelogerService = new FilebaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
             basvuruManager.BasvuruYap(konutKredisiManager, new DatabaseLoggerService()); //alternatif new olarak içinde de tanımlayabilirim

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                konutKredisiManager  //hesaplamasını istediğim kredileri burda gönderiyorum
            };
            //basvuruManager.BasvuruOnBilgilendirme(krediler);
        }
    }
}
