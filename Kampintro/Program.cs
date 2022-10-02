// type safety - tip güvenliği
// Do not yoruself - Kendini Tekrarlama
// değer tutucu, alias (takma ad)

string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.55;
double dolarBugun = 7.55;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Eşittir Butonu");
}







if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullancı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş Yap butonu");
}
Console.WriteLine(kategoriEtiketi);
