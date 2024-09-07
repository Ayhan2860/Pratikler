// See https://aka.ms/new-console-template for more information
// 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdırma.
Console.Write("Lütfen bir sayı giriniz : ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while (sayac <= sayi)
{
    toplam += sayac;
    sayac++;

}
Console.WriteLine(toplam / sayi);

// 'a' dan 'z' ye kadar tüm harfleri console a yazdırma
char charecter = 'a';
while (charecter <= 'z')
{
    Console.Write($"{charecter,-2}");
    charecter++;
}

Console.WriteLine("\n***** Foreach *****");
string[] arabalar = { "Bmw", "Ford", "Mercedes", "Volkswagen" };
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
