
using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

// 2 . Yazım Şekli
Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

//PascalCase    //camelCase
//case sensitive - küçük büyük harf duyarlı
ProductManager productManager = new ProductManager();
productManager.Add(product1);
productManager.Update(product1);
