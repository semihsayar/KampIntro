using System.Globalization;

Product product1 = new Product();
product1.ProductId = 1;
product1.ProductName = "Tişört";
product1.ProductCategory = "Erkek Giyim";
product1.ProductPrice = 100;

Product product2 = new Product();
product2.ProductId = 2;
product2.ProductName = "Spor Ayakkabı";
product2.ProductCategory = "Erkek Spor Ayakkabı";
product2.ProductPrice = 300;

Product[] products = new Product[] { product1,product2 };

Console.WriteLine("Foreach Döngüsü İle");
foreach (var Product in products)
{
    Console.WriteLine(Product.ProductId + ": " + Product.ProductName + ": " + Product.ProductCategory + ": " + Product.ProductPrice );
}
Console.WriteLine();

Console.WriteLine("For Döngüsü İle");
for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].ProductId + ": " + products[i].ProductName + ": " + products[i].ProductCategory + ": " + products[i].ProductPrice);
}
Console.WriteLine();

Console.WriteLine("While Döngüsü İle");

int j = 0;
while(j < products.Length)
{
    Console.WriteLine(products[j].ProductId + ": " + products[j].ProductName + ": " + products[j].ProductCategory + ": " + products[j].ProductPrice);
    j++;
}





class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ProductCategory { get; set; }
    public int ProductPrice { get; set; }


}
