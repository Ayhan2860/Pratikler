// See https://aka.ms/new-console-template for more information

Console.WriteLine("************* Class *************");
Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.KisaKenar = 3;
dikdortgen.UzunKenar = 4;

Console.WriteLine("Class Metot Alan Hesabı: {0}", dikdortgen.AlanHesapla());


Console.WriteLine("\n************* Struct *************");
Dikdortgen_Struct dikdortgen_Struct;
// Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
dikdortgen_Struct.KisaKenar = 3;
dikdortgen_Struct.UzunKenar = 4;
Console.WriteLine("Struct Metot Alan Hesabı: {0}", dikdortgen_Struct.AlanHesapla());

class Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;
    public Dikdortgen()
    {
        
    }
    public long AlanHesapla()
    {
        return UzunKenar * KisaKenar;
    }
}

struct Dikdortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;
    
    public long AlanHesapla() => KisaKenar * UzunKenar;
}