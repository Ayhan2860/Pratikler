// See https://aka.ms/new-console-template for more information
Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Pazar);
int sicaklik = 22;
if(sicaklik <=(int)HavaDurumu.Normal)
    Console.WriteLine("Hava dışarı çıkmak için çok soğuk");
else if(sicaklik >= (int)HavaDurumu.Sicak)
    Console.WriteLine("Dışarıya çıkmak için  sıcak bir gün");
else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
    Console.WriteLine("Hadi dışarı çıkalım");


enum Gunler
{
    Pazartesi,
    Salı,
    Carşamba, 
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar 
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 22,
    Sicak = 32,
    CokSicak = 38
}