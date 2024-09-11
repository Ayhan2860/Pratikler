// See https://aka.ms/new-console-template for more information
Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
Calisan calisan1 = new Calisan("Mevlüt", "Karaman", "Sevkiyat");
Calisan calisan2 = new Calisan("Ümit", "Karaman", "Yemekhane");
Calisan calisan3 = new Calisan("Cihan", "Karaman", "Saha Şefi");
Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);


Console.WriteLine("\n*********** Islemler ***********");
Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));
Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(400, 50));

class Calisan
{
    private static int calisanSayisi;
    public static int CalisanSayisi { get => calisanSayisi;}
    private string Isim;
    private string SoyIsim;
    private string Departman;

    public Calisan(string isim, string soyIsim, string departman)
    {
        this.Isim = isim;
        this.SoyIsim = soyIsim;
        this.Departman = departman;
        calisanSayisi++;
    }
    static Calisan()
    {
        calisanSayisi = 0;
    }

}

static class Islemler
{
    public static long Topla(int sayi1, int sayi2) => sayi1 + sayi2;
    public static long Cikar(int sayi1, int sayi2) => sayi1 - sayi2;
}