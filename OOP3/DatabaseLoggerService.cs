using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //veritabanına loglama yapacaksak
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
