using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
         public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " " + "Sepete Eklendi! ");
            Console.WriteLine("Sepet Tutarı : " + urun.Fiyati);
            Console.WriteLine();
        }
        public void Ekle2 (string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi + "" + stokAdedi);
        }
    }
}
