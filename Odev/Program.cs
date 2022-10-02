Urun Urun1 = new Urun();
Urun1.UrunId = 1;
Urun1.UrunAdi = "Cep Telefonu";
Urun1.UrunKategori = "Elektronik";
Urun1.UrunFiyati = 5100;

Urun Urun2 = new Urun();
Urun2.UrunId = 2;
Urun2.UrunAdi = "Televizyon";
Urun2.UrunKategori = "Elektronik";
Urun2.UrunFiyati = 7500;

Urun Urun3 = new Urun();
Urun3.UrunId = 3;
Urun3.UrunAdi = "Beyaz Eşya";
Urun3.UrunKategori = "Elektronik";
Urun3.UrunFiyati = 3250;

Urun Urun4 = new Urun();
Urun4.UrunId = 4;
Urun4.UrunAdi = "Oyuncu Ekipmanları";
Urun4.UrunKategori = "Elektronik";
Urun4.UrunFiyati = 758;

Urun Urun5 = new Urun();
Urun5.UrunId = 5;
Urun5.UrunAdi = "Laptop & Tablet";
Urun5.UrunKategori = "Elektronik";
Urun5.UrunFiyati = 1000;

Urun Urun6 = new Urun();
Urun6.UrunId = 6;
Urun6.UrunAdi = "Ev Aletleri";
Urun6.UrunKategori = "Elektronik";
Urun6.UrunFiyati = 500;

Urun Urun7 = new Urun();
Urun7.UrunId = 7;
Urun7.UrunAdi = "Oyun Konsolları";
Urun7.UrunKategori = "Elektronik";
Urun7.UrunFiyati = 9500;

Urun Urun8 = new Urun();
Urun8.UrunId = 8;
Urun8.UrunAdi = "Monitör";
Urun8.UrunKategori = "Elektronik";
Urun8.UrunFiyati = 2500;

Urun Urun9 = new Urun();
Urun9.UrunId = 9;
Urun9.UrunAdi = "Yazıcı & Tarayıcı";
Urun9.UrunKategori = "Elektronik";
Urun9.UrunFiyati = 500;

Urun Urun10 = new Urun();
Urun10.UrunId = 10;
Urun10.UrunAdi = "Giyilebilir Teknoloji";
Urun10.UrunKategori = "Elektronik";
Urun10.UrunFiyati = 750;

Console.WriteLine("E TİCARET ADMİN PANELİNE HOŞ GELDİNİZ ");
Console.WriteLine("Lütfen Giriş Yapınız");
Console.WriteLine();

Console.Write("Kullanici Adi: ");
string kullaniciAdi = Console.ReadLine();

Console.Write("Sifrenizi Giriniz: ");
string sifre = Console.ReadLine();

if (kullaniciAdi == "admin" && sifre == "12345")
{
    Console.WriteLine("Giriş Başarılı Ürünler Listeneleniyor ...");
    Console.WriteLine();

    Urun[] Urunler = new Urun[] { Urun1, Urun2, Urun3, Urun4, Urun5, Urun6, Urun7, Urun8, Urun9, Urun10 };

    Console.WriteLine("İD   ADI          KATEGORİ  FİYATI");
    Console.WriteLine();
    foreach (var Urun in Urunler)
    {

        Console.WriteLine(Urun.UrunId + ": " + Urun.UrunAdi + ": " + Urun.UrunKategori + ": " + Urun.UrunFiyati);
    }

}
else
{
    Console.WriteLine("Kullanici Adı veya Şifre Hatalı");
}
class Urun
{
    public int UrunId { get; set; }
    public string UrunAdi { get; set; }
    public string UrunKategori { get; set; }
    public float UrunFiyati { get; set; }
}
