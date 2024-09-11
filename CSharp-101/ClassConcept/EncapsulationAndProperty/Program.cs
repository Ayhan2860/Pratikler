// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n******** Öğrenci-1 ********");
Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Isim = "Kaan";
ogrenci1.Soyisim = "Kara";
ogrenci1.OgrenciNo = 28665;
ogrenci1.Sinif = 3;

ogrenci1.OgrenciBilgileriYazdir();
ogrenci1.SinifAtlat();

Console.WriteLine("\n******** Öğrenci-1 Update ********");
ogrenci1.OgrenciBilgileriYazdir();

Console.WriteLine("\n******** Öğrenci-2 ********");

Ogrenci ogrenci2 = new Ogrenci("Aras", "Kara", 28664, 1);

ogrenci2.SinifDusur();
ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgileriYazdir();




class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim
    {
        get { return isim; }
        set { isim = value; }
    }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    {
        get => sinif;
        set 
        { 
            if(value < 1)
            {
                Console.WriteLine("Sınıf En Az 1 Olabilir");
                sinif = 1;
            }
            else 
                sinif = value;

             
        }
    }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci()
    {

    }


    public void OgrenciBilgileriYazdir()
    {
        Console.WriteLine("Öğrenci Bilgileri");
        Console.WriteLine("Isim: {0}", Isim);
        Console.WriteLine("Soyisim: {0}", Soyisim);
        Console.WriteLine("Öğrenci Numarası: {0}", OgrenciNo);
        Console.WriteLine("Sınıfı: {0}", Sinif);
    }

    public void SinifAtlat() => Sinif = Sinif + 1;
    public void SinifDusur()
    {
        this.Sinif = this.Sinif -1;
    }
}
