using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Bu olaya Miras - Inheritance Diyoruz
     class TuzelMusteri:Musteri // Tüzel Müşteri Bir Müşteridir
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
