
string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
string kurs3 = "java";

// array - dizi

string[] kurslar = new string[] 
{ 
  "Yazılım Geliştirici Yetiştirme Kampı", 
  "Programlamaya Başlangıç için Temel Kurs", 
  "java",
  "Python",
  "C++"

};

// Length - eleman sayısını verir
for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("For Bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);

}

Console.WriteLine("Sayfa sonu - footer");
