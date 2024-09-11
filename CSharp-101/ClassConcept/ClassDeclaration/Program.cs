// See https://aka.ms/new-console-template for more information

// Söz Dizimi 
// class SiniAdi
// { 
//      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
//      [Erişim Belirleyici] [Veri Tipi] MetotAdi(Parametre Listesi)
//      {
//             // Metot Komutları
//      }
//     
// }   

// Erişim Belirleyiciler
// * public          ------->   Heryerden erişilebilir özellik sağlar.
// * private          ------->    Tanımlandığı sınıf içerisinde erişilebilir özellik sağlar.
// * internal          ------->      Tanımlandığı proje içerisinde erişilebilir özellik sağlar.
// * protected          ------->       Tanımlandığı sınıfı miras alan sınıflar içerisinde erişilebilir özellik sağlar.(A sınıfında tanımlandı, B sınıfı miras aldı. B sınıfında erişilebilir.)
Calisan calisan1 = new Calisan();
calisan1.Ad = "Ahmet";
calisan1.Soyad = "Yılmaz";
calisan1.No = 1;
calisan1.Departman = "İnsan Kaynakları";

calisan1.CalisanBilgileri();
Console.WriteLine("\n**********************\n");
Calisan calisan2 = new Calisan();
calisan2.Ad = "Ali";
calisan2.Soyad = "Kaya";
calisan2.No = 2;
calisan2.Departman = "Pazarlama";

calisan2.CalisanBilgileri();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calışan Bilgileri");
        Console.WriteLine($"Adı: {Ad}");
        Console.WriteLine($"Soyadı: {Soyad}");
        Console.WriteLine($"Numarası: {No}");
        Console.WriteLine($"Departman: {Departman}");
    }
}
