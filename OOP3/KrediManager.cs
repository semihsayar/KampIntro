using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // interface - Benim şablonum görevi görüyor
    // interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    // Loglama nedir - Kim ne zaman operasyonu çağırdıdır (Birnevi o sistemde olan haraketleri döktüğümüz bir dökümdür)
    interface IKrediManager
    {
        // Operasyon Tanımlıyoruz
        // Bu Şablona uymak zorundasın
        void Hesapla();
        void BiseyYap();
    }
}
