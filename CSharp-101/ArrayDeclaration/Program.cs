// See https://aka.ms/new-console-template for more information
// Dizi tanımlama

string[] renkler = new string[5];
string[] hayvanlar = { "Kedi", "Köpek", "İnek", "Maymun" };

int[] dizi;
dizi = new int[5];

//Dizilere değer atama ve erişim
renkler[0] = "Mavi";

dizi[3] = 10;
Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[2]);
Console.WriteLine(renkler[0]);

// Döngüler dizi kullanımı
Console.WriteLine("Lütfen dizinin eleman sayısını giriniz :");
int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];
for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayısını giriniz : ", i + 1);
    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
}



int toplam = 0;
foreach (var sayi in sayiDizisi)
{
    toplam += sayi;

}
Console.WriteLine("Ortalama : " + toplam / diziUzunlugu);