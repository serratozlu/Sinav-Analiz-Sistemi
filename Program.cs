// MENÜ

Console.WriteLine("1 - Tüm Öğrencileri Listele");
Console.WriteLine("2 - Ortalama Hesapla");
Console.WriteLine("3 - Geçen/Kalanları Göster");
Console.WriteLine("4 - En Başarılı Öğrenci");


Console.Write("Lütfen seçim yapınız: ");
int secim = Convert.ToInt32(Console.ReadLine());


//VERİLERİ TANIMLAMA

string[] ogrenciler = { "Ahmet", "Ayşe", "Mehmet", "Zeynep" };

int[] notlar = { 50, 70, 90, 87 };

DateTime[] sinavTarihi =
{
    new DateTime(2026,4,30),
    new DateTime(2026,4,30),
    new DateTime(2026,4,30),
    new DateTime(2026,4,30)
};

//DÖNGÜ
if (secim == 1)
{
    for (int i = 0; i < ogrenciler.Length; i++)
    {
        Console.WriteLine(ogrenciler[i] + " - Not: " + notlar[i]);
    }
}
