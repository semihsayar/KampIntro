using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager

    {       // Method İnjection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> ILoggerServices)
        {
            // Başvuran Bilgilerini değerlendirme
            //   
            krediManager.Hesapla(); // Hangi Kredi Gönderilmişse Onu Hesapla
            //ILoggerService.Log(); // Hangi Logger Servis Gönderilmişsse Onu Logla
            foreach (var loggerService in ILoggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
