using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        //Topla(2,3)
        public void Topla(int sayi1, int sayi2) // methot
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + toplam);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + cikar);
        }
    }
}
