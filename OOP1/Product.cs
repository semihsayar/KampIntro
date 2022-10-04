using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snippet
    internal class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        // Ürün Fiyatı
        public double UnitPrice { get; set; }
        // Stok Adedi
        public int UnitsInStock { get; set; }
    }
}
