// See https://aka.ms/new-console-template for more information

Console.WriteLine("\n******** Calışan-1 ********");
Calisan calisan1 = new Calisan("Ahmet", "Yılmaz", 25, "İnsan Kaynakları");
calisan1.CalisanBilgileri();

Console.WriteLine("\n******** Calışan-2 ********");
Calisan calisan2 = new Calisan();
calisan2.Ad = "Ali";
calisan2.Soyad = "Kaya";
calisan2.No = 2;
calisan2.Departman = "Pazarlama";

calisan2.CalisanBilgileri();


Console.WriteLine("\n******** Calışan-3 ********");
Calisan calisan3 = new Calisan("Mustafa", "Kayabaşı");
calisan3.CalisanBilgileri();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan()
    {
        
    }
    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calışan Bilgileri");
        Console.WriteLine($"Adı: {Ad}");
        Console.WriteLine($"Soyadı: {Soyad}");
        Console.WriteLine($"Numarası: {No}");
        Console.WriteLine($"Departman: {Departman}");
    }
}