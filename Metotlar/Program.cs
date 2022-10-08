//Dont repeat yourself - DRY - Clean Code - Best Practice

using Metotlar;


Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

// Array - Dizi

Urun[] urunler = new Urun[] {urun1, urun2};

foreach (var Urun in urunler)
{
    Console.WriteLine(Urun.Adi + " " + Urun.Fiyati + " " + Urun.Aciklama);
    Console.WriteLine("------------");
}

Console.WriteLine("-----------Metotlar---------");

//istance - örnek
// encapsulation

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

Console.WriteLine();
sepetManager.Ekle2("Armut","Yeşil Armut",12, 10);
sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu", 12, 8);